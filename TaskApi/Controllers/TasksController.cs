using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet] //read
        public IActionResult Tasks()
        {
            var tasks= new string[] { "Task 1", "Task 2", "Task 3" };
            return Ok(tasks);
        }

        [HttpPost] //create
        public IActionResult NewTask()
        {
            return Ok();
        }

        [HttpPut] //update
        public IActionResult UpdateTask()
        {
            return Ok();
        }

        [HttpDelete] //delete
        public IActionResult DeleteTask() 

        {
            var somethingWentWrong = true;
            if (somethingWentWrong) 
            return BadRequest();
            return Ok();
        }
    }
}
