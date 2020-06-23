using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class TestController : ControllerBase
    {
        /// <summary>
        /// 测试
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Test()
        {
            return Ok();
        }
    }
}
