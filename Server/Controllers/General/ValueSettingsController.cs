using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.General;


namespace OrisonMISAPI.Controllers.General
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueSettingsController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IDBOperation _repository;
        public ValueSettingsController( IWebHostEnvironment environment, IDBOperation repository)
        {
            _environment = environment;
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        [HttpGet("{Source}/{key}")]
        public async Task<ActionResult<IEnumerable<string>>> GetMasterMisc(string Source, string key)
        {
            var a= await _repository.GetMasterMisc(Source,key);
            return a;
        }
        [HttpGet()]
        public async Task<ActionResult<IEnumerable<string>>> GetList(string cmd, string key)
        {
            return await _repository.GetList(cmd,key);
        }
    }
}
