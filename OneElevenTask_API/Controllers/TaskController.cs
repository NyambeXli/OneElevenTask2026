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

            var sortedList = input.Data
                .ToCharArray()
                .OrderBy(c => c)
                .Select(c => c.ToString())
                .ToList();

            return Ok(new { word = sortedList });
        }
    }

    public class RequestModel
    {
        public string Data { get; set; }
    }
}
