using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TokenSample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SecureController : ControllerBase
    {
        [HttpGet("data")]
        [Authorize]
        public IActionResult GetSecureData()
        {
            var username = User.Identity.Name;
            return Ok($"Xin chao {username}, ban da truy cao du lieu bao ve!");
        }
        [HttpGet("public")]
        public IActionResult GetPublicData()
        {
            return Ok("Day la du lieu cong khai, khong can token.");
        }
    }
}
