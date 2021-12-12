using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Authentication.API.Controllers
{
    [ApiController]
    public class ExampleBusinessLogicController : Controller
    {
        [HttpGet]
        [Authorize]
        [Route("/api/protectedforcommonusers")]
        public IActionResult GetProtectedData()
        {
            return Ok("Hello world from protected controller.");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        [Route("/api/protectedforadministrators")]
        public IActionResult GetProtectedDataForAdmin()
        {
            return Ok("Hello admin!");
        }
    }
}
