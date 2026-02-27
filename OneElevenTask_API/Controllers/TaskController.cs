using Microsoft.AspNetCore.Mvc;

namespace OneElevenTask.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        public class WebhookRequest
        {
            public string Data { get; set; } = null!;
        }

        public class WebhookResponse
        {
            public char[] Word { get; set; } = null!;
        }

        [HttpPost]
        public IActionResult Post([FromBody] WebhookRequest request)
        {
            if (request == null || string.IsNullOrEmpty(request.Data))
            {
                return BadRequest(new { message = "The data field is required." });
            }

            char[] charArray = request.Data.ToCharArray();

            Array.Sort(charArray);

            return Ok(new WebhookResponse { Word = charArray });
        }
    }
}