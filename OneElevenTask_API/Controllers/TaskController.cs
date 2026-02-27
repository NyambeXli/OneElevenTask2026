using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace OneElevenTask_API.Controllers
{
    [ApiController]
    [Route("/")]
    public class TaskController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] RequestModel input)
        {
            if (input == null || string.IsNullOrEmpty(input.Data))
            {
                return BadRequest();
            }

            var result = input.Data
                .ToCharArray()
                .OrderBy(c => c)
                .Select(c => c.ToString())
                .ToArray();

            return Ok(new { word = result });
        }
    }

    public class RequestModel
    {
        public string Data { get; set; }
    }
}
