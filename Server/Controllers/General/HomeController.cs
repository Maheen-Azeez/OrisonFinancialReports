using Microsoft.AspNetCore.Hosting;
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
    public class HomeController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IDBOperation _repository;
 
        public HomeController( IWebHostEnvironment environment, IDBOperation repository)
        {
            _environment = environment;
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
            

        }
        [HttpGet]
        [Route("getURL")]
        public async Task<string> getHomeUrl(int AccountID, string key)
        {
            return await _repository.getHomeUrl(AccountID,key);
        }
        public async Task<ActionResult<IEnumerable<BranchMaster>>> GetSchoolBranch(string key)
        {
            var Warehouse = await _repository.GetSchoolBranch(key);
            if (Warehouse == null)
            {
                return null;
            }

            return Warehouse;
        }
    }
}
