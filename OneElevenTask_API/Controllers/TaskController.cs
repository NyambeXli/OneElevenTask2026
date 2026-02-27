using Microsoft.AspNetCore.Mvc;

namespace OneElevenTask_API.Controllers
{
    [ApiController]
    [Route("")] 
    public class TaskController : ControllerBase
    {
        [HttpPost("/")]
        public IActionResult Post([FromBody] RequestModel input)
        {
            if (input == null || string.IsNullOrEmpty(input.Data))
            {
                return BadRequest();
            }

            char[] chars = input.Data.ToCharArray();
            Array.Sort(chars);

            return Ok(new { word = chars });
        }
    }

    public class RequestModel
    {
        public string Data { get; set; }
    }
}
