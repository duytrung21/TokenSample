using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TokenSample.Data;
using TokenSample.Models;

namespace TokenSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HocSinhController : ControllerBase
    {
        public static List<HocSinh> hocSinhs = new();
        [HttpGet]
        [Authorize] //controller can token moi cho phep truy cap du lieu
        public IActionResult GetAll()
        {
            return Ok(hocSinhs);
        }
        [HttpPost] //controller khong can token cung co the truy cập dữ liệu
        public IActionResult CreateNew(HocSinhModel hsModel)
        {
            var hocsinh = new HocSinh 
            {
                Name = hsModel.Name,    
                Address = hsModel.Address,
                Age = hsModel.Age
            };
            hocSinhs.Add(hocsinh);
            return Ok(hocsinh);
        }
    }
}
