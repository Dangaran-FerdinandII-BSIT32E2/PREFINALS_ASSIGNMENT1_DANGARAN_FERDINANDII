using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProtectedApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            
            var userInfo = new
            {
                Name = "Ferdinand II Dangaran",
                Section = "BSIT32E2",
                Course = "Information Technology"
            };

            var funFacts = new[]
            {
                "I want to be a Fullstack Developer.",
                "I am good at Valorant.",
                "I love to watch anything.",
            };

            return Ok(new { UserInfo = userInfo, FunFacts = funFacts });
        }
    }
}
