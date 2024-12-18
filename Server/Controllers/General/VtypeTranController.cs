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
    public class VtypeTranController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IDBOperation _repository;
        public VtypeTranController( IWebHostEnvironment environment, IDBOperation repository)
        {
            _environment = environment;
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        // GET: api/VtypeTran/'Sales Order'
        [HttpGet("{ID}/{key}")]
        public async Task<object> GetVtypeTran(int ID, string key)
        {
            return await _repository.GetVtypeTran(ID,key);
        }
       
    }
}
