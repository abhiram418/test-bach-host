using Microsoft.AspNetCore.Mvc;

namespace test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestClass : ControllerBase
    {
        [HttpGet("{number}")]
        public ActionResult Sum([FromRoute] int number)
        {
            return Ok(number + 1000);
        }
    }
}
