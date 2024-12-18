using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.Inventory;
using OrisonMIS.Shared.Entities.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace OrisonMIS.Server.Controllers.Inventory
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvAccountsController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IInvAccountsManager _repository;
        public InvAccountsController(IWebHostEnvironment environment, IInvAccountsManager repository)
        {
            _environment = environment;
            _repository = repository ?? throw new ArgumentNullException(nameof(_repository));

        }
        // GET: api/<SalesController>
        [HttpGet]
        //[Route("getList")]
        public async Task<ActionResult<IEnumerable<dtInvAccounts>>> GetCustomers(string key)
        {
            return await _repository.GetCustomers(key);
        }

        // POST api/<SalesController>
        //[HttpPost("[action]")]
        //[Route("post")]
        [HttpPost]
        public async Task<HttpResponseMessage> SaveAdd(dtInvAccounts Acc, string key)
        {

            bool id = false;
            id = await _repository.SaveAdd(Acc,key);

            HttpResponseMessage msg = new HttpResponseMessage();
            msg.StatusCode = (System.Net.HttpStatusCode)1;
            return msg;
        }

        [HttpGet("[action]")]
        [Route("getCompany")]
        public Task<List<string>> GetCompanyName(string key)
        {
            return _repository.GetCompanyName(key);
        }
        // PUT api/<SalesController>/5
        [HttpGet("[action]")]
        [Route("getCurrency")]
        public Task<List<string>> GetCurrency(string key)
        {
            return _repository.GetCurrency(key);
        }

        [HttpPut("{id}/{key}")]
        //[Route("edit")]
        public void SetRemarks(int id, [FromBody] string Remarks, string key)
        {
            _repository.SetRemarks(id, Remarks,key);
        }
        [HttpGet("{Category}/{key}")]
        public async Task<string> NextCode(string Category, string key)
        {
            return await _repository.GetAccountCode(Category,key);
            //return _repository.GetNextNumFn(Category);
        }
    }
}
