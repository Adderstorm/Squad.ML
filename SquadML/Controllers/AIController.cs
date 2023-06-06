using Microsoft.AspNetCore.Mvc;
using SquadML.Application.Data;
using SquadML.Application.Models;
using SquadML.Application.Logging;
using SquadML.Application.Services;

namespace SquadML.Application.Controllers
{
    [Controller]
    [Route("api/[controller]/[action]")]
    //[Authorize]
    public class AIController : ControllerBase
    {
        private readonly SquadAIDbContext _context;

        public AIController(SquadAIDbContext context)
        {
            _context = context;
        }

        [ActionName("predictMembers")]
        [HttpGet("{serverID}")]
        public ActionResult<AIMembersPred> PredictMembers(long serverID)
        {
            AIPrep? data = _context.AIPrep.FirstOrDefault(x => x.Server == serverID);
            if (data == null)
            {
                Logger.LogInfo($"No data about {serverID} server");
                return NotFound($"No data about {serverID} server");
            }

            AIMembersInput input = new() {
                MembersActivity = data.MembersActivity,
                MessagesActivity = data.MessagesActivity,
                NewMembers = data.NewMembers,
                VoiceActivity = data.VoiceActivity,
            };

            AIMembersPred predicted = AIService.MembersPred(input);

            return Ok(predicted);
        }

        [ActionName("predictMembersActivity")]
        [HttpGet("{serverID}")]
        public ActionResult<AIMembersActivityPred> PredictMembersActivity(long serverID)
        {
            AIPrep? data = _context.AIPrep.FirstOrDefault(x => x.Server == serverID);
            if (data == null)
            {
                Logger.LogInfo($"No data about {serverID} server");
                return NotFound($"No data about {serverID} server");
            }

            AIMembersActivityInput input = new()
            {
                MessagesActivity = data.MessagesActivity,
                VoiceActivity = data.VoiceActivity,
                NewMembers = data.NewMembers,
                TotalMembers = data.TotalMembers,
            };

            AIMembersActivityPred predicted = AIService.MembersActivityPred(input);

            return Ok(predicted);
        }

        [ActionName("predictVoiceActivity")]
        [HttpGet("{serverID}")]
        public ActionResult<AIVoiceActivityPred> PredictVoiceActivity(long serverID)
        {
            AIPrep? data = _context.AIPrep.FirstOrDefault(x => x.Server == serverID);
            if (data == null)
            {
                Logger.LogInfo($"No data about {serverID} server");
                return NotFound($"No data about {serverID} server");
            }

            AIVoiceActivityInput input = new()
            {
                MembersActivity = data.MembersActivity,
                NewMembers = data.NewMembers,
                TotalMembers = data.TotalMembers,
                MessagesActivity = data.MessagesActivity,
            };

            AIVoiceActivityPred predicted = AIService.VoiceActivityPred(input);

            return Ok(predicted);
        }

        [ActionName("predictMessagesActivity")]
        [HttpGet("{serverID}")]
        public ActionResult PredictMessagesActivity(long serverID)
        {
            AIPrep? data = _context.AIPrep.FirstOrDefault(x => x.Server == serverID);
            if (data == null)
            {
                Logger.LogInfo($"No data about {serverID} server");
                return NotFound($"No data about {serverID} server");
            }

            AIMessagesActivityInput input = new()
            {
                MembersActivity = data.MembersActivity,
                VoiceActivity = data.VoiceActivity,
                NewMembers = data.NewMembers,
                TotalMembers = data.TotalMembers,
            };

            AIMessagesActivityPred predicted = AIService.MessagesActivityPred(input);

            return Ok(predicted);
        }
    }
}
