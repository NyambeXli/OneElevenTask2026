using Microsoft.AspNetCore.Mvc;

namespace OneElevenTask_API.Controllers
{
    [ApiController]
    [Route("/")] // This fixes the 404! It makes your API listen at the main URL.
    public class TaskController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] RequestModel input)
        {
            if (input == null || string.IsNullOrEmpty(input.Data))
            {
                return BadRequest();
            }

            // Convert to char array and sort alphabetically
            char[] chars = input.Data.ToCharArray();
            Array.Sort(chars);

            // Return in the exact format they asked for: { "word": [...] }
            return Ok(new { word = chars });
        }
    }

    public class RequestModel
    {
        public string Data { get; set; }
    }
}
