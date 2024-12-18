using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrisonMIS.Server.Controllers.General
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingsController : ControllerBase
    {
        private IWebHostEnvironment _environment;

        public SettingsController( IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        //// GET: api/Settings
        //[HttpGet]
        //public async Task<object> GetSettings(string category)
        //{
        //    Setting SettingValue;
        //    SettingValue = _context.Settings.FirstOrDefault(a => a.Category == category);
        //    if (SettingValue == null)
        //    {
        //        return "";
        //    }
        //    return (object)SettingValue.Value;
        //}
        // GET: api/Settings
        //[HttpGet]
        //public async Task<IActionResult> Get()

        //{
        //    return Ok(_context.Settings);
        //}
        //// GET api/Settings/category
        //[HttpGet("{category}")]
        //public object Get(string category)
        //{
        //    Setting SettingValue;
        //    SettingValue = _context.Settings.FirstOrDefault(a => a.Category == category);
        //    if (SettingValue == null)
        //    {
        //        return "";
        //    }
        //    return (object)SettingValue.Value;
        //}


    }
}