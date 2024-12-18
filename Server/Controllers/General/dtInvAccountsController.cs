using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dapper;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.General;


namespace OrisonMIS.Server.Controllers.General
{
    [Route("api/[controller]")]
    [ApiController]
    public class dtInvAccountsController : ControllerBase
    {
        private readonly IDapperManager _dapperManager;
        private IWebHostEnvironment _environment;
        private IInvAccounts _repository;
        private readonly IConfiguration _config;

        public dtInvAccountsController( IWebHostEnvironment environment, IInvAccounts repository, IDapperManager dapperManager, IConfiguration config)
        {
            _environment = environment;
            _repository = repository;
            _dapperManager = dapperManager;
            _config = config;
        }
        // GET: api/dtInvAccounts?AccCategory=Customers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<dtInvAccounts>>> GetdtInvAccounts(string AccCategory, string key)
        {
            if (AccCategory == "All")
                return await _repository.GetAllAccounts(key);
            else
                return await _repository.GetAccounts(AccCategory,key);
        }
        [HttpGet("{id}/{Category}/{key}")]
        public async Task<ActionResult<IEnumerable<dtInvAccounts>>> GetdtInvAccountsByID(int id, string Category, string key)
        {
            return await _repository.GetAccountsbyID(id, Category,key);
        }
        [HttpGet("{AccCategory}/{Designation}/{BranchID}/{key}")]
        public async Task<ActionResult<IEnumerable<dtInvAccounts>>> GetdtInvAccountsDesignation(string AccCategory, string Designation, string Branchid, string key)
        {
            return await _repository.GetAccountsByDesignation(AccCategory, Designation, Branchid,key);
        }
        [HttpGet]
        [Route("GetLevel")]
        public async Task<ActionResult<IEnumerable<ParentLevel>>> GetLevel(string key)
        {
            return await _repository.GetLevel(key);
        }
        
    }
}
