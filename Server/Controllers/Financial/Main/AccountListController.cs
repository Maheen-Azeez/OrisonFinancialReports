using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.Financial.Main;
using OrisonMIS.Shared.Entities.Financial.Main;


namespace OrisonMIS.Server.Controllers.Financial.Main
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountListController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IAccountList _repository;
        public AccountListController( IWebHostEnvironment environment, IAccountList repository)
        {
            _environment = environment;
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));

        }

        // GET: api/AccountList?AccList=Cash&BranchId=31
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccountList>>> Get(string AccList, long BranchId, string key)
        {
            return await _repository.Get(AccList, BranchId, key);

        }
    }
}
