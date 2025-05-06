using Microsoft.AspNetCore.Mvc;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace TokenSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel user)
        {
            if (user.Username != "admin" || user.Password != "123456")
                return Unauthorized("Sai thong tin dang nhap!");

            var tokenHandle = new JwtSecurityTokenHandler(); //tạo và xác thực token JWT 
            var key = Encoding.ASCII.GetBytes("this is my custom Secret key for auth");

            var tokenDescriptor = new SecurityTokenDescriptor //mô tả Token
            {
                Subject = new ClaimsIdentity(new[] //thông tin người dùng: tên và vai trò
                {
                    new Claim(ClaimTypes.Name, user.Username), 
                    new Claim(ClaimTypes.Role, "Admin")
                }),
                Expires = DateTime.UtcNow.AddHours(1), //hạn sử dụng token

                //xác định cách thức ký của token, sử dụng khóa bí mật và thuật toán HMACSHA-256 để đảm bảo tính toàn vẹn của token
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandle.CreateToken(tokenDescriptor); //tạo token dựa trên mô tả Token
            string jwt = tokenHandle.WriteToken(token); //chuyển token thành chuỗi để trả về cho client
            return Ok(new { token = jwt });
        } 
    }
    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
