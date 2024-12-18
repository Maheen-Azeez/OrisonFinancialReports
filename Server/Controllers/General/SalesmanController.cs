using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Server.Controllers.General
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesmanController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IDBOperation _repository;
        public SalesmanController( IWebHostEnvironment environment, IDBOperation repository)
        {
            _environment = environment;
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        // GET: api/Salesman/id
        [HttpGet("{ID}/{key}")]
        public async Task<object> GetSalesman(int ID, string key)
        {
            Salesman objSalesman = new Salesman() { AccountID=0,AccountName=""};
            var Salesman= await _repository.GetSalesman(ID,key);
            if (Salesman == null)
            {
                return objSalesman;
            }

            return Salesman;
        }
    }
}
