using Microsoft.AspNetCore.Mvc;

namespace SquadML.Application.Controllers
{
    [Controller]
    [Route("api/[controller]/[action]")]
    //[Authorize]
    public class AIController : Controller
    {
        [ActionName("predictMembers")]
        [HttpGet("{id}")]
        public ActionResult PredictMembers(long serverID)
        {
            /*Some Actions with AI*/
            return Ok(/*some data to recieve*/);
        }
        [ActionName("predictMembersActivity")]
        [HttpGet("{id}")]
        public ActionResult PredictMembersActivity(long serverID)
        {
            /*Some Actions with AI*/
            return Ok(/*some data to recieve*/);
        }
        [ActionName("predictVoiceActivity")]
        [HttpGet("{id}")]
        public ActionResult PredictVoiceActivity(long serverID)
        {
            /*Some Actions with AI*/
            return Ok(/*some data to recieve*/);
        }
        [ActionName("predictMessagesActivity")]
        [HttpGet("{id}")]
        public ActionResult PredictMessagesActivity(long serverID)
        {
            /*Some Actions with AI*/
            return Ok(/*some data to recieve*/);
        }
    }
}
