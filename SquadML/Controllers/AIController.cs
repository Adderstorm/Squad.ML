using Microsoft.AspNetCore.Mvc;
using SquadML.Application.Data;
using SquadML.Application.Models;
using SquadML.Application.Logging;

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
        [HttpGet("{id}")]
        public ActionResult PredictMembers(long serverID)
        {
            AIPrep? data = _context.AIPrep.FirstOrDefault(x => x.Server == serverID);
            if (data == null)
            {
                Logger.LogInfo($"No info about {serverID} server");
                return NotFound($"No info about {serverID} server");
            }



            return Ok(/*some data to recieve*/);
        }

        [ActionName("predictMembersActivity")]
        [HttpGet("{id}")]
        public ActionResult PredictMembersActivity(long serverID)
        {
            AIPrep? data = _context.AIPrep.FirstOrDefault(x => x.Server == serverID);
            if (data == null)
            {
                Logger.LogInfo($"No info about {serverID} server");
                return NotFound($"No info about {serverID} server");
            }



            return Ok(/*some data to recieve*/);
        }

        [ActionName("predictVoiceActivity")]
        [HttpGet("{id}")]
        public ActionResult PredictVoiceActivity(long serverID)
        {
            AIPrep? data = _context.AIPrep.FirstOrDefault(x => x.Server == serverID);
            if (data == null)
            {
                Logger.LogInfo($"No info about {serverID} server");
                return NotFound($"No info about {serverID} server");
            }



            return Ok(/*some data to recieve*/);
        }

        [ActionName("predictMessagesActivity")]
        [HttpGet("{id}")]
        public ActionResult PredictMessagesActivity(long serverID)
        {
            AIPrep? data = _context.AIPrep.FirstOrDefault(x => x.Server == serverID);
            if (data == null)
            {
                Logger.LogInfo($"No info about {serverID} server");
                return NotFound($"No info about {serverID} server");
            }



            return Ok(/*some data to recieve*/);
        }
    }
}
