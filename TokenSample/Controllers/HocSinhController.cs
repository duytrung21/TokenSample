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
        public static List<HocSinh> hocSinhs = new List<HocSinh>();
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(hocSinhs);
        }
        [HttpPost]
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
