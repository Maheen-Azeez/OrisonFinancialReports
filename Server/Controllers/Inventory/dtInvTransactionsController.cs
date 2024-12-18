using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.Inventory;
using OrisonMIS.Shared.Entities.Inventory;


namespace OrisonMIS.Server.Controllers.Inventory
{
    [Route("api/[controller]")]
    [ApiController]
    public class dtInvTransactionsController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IInvTransactionsManager _repository;
        public dtInvTransactionsController(IWebHostEnvironment environment, IInvTransactionsManager repository)
        {
            _environment = environment;
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        // GET: api/dtInvTransactions?VId=10293
        [HttpGet]
        public async Task<ActionResult<IEnumerable<dtInvTransactions>>> GetTransactions(long VId, string criteria, string key)
        {
            return await _repository.GetTransactions(VId, criteria,key);

        }
        [HttpGet("{vid}/{SBasicType}/{DBasicType}/{key}")]
        public async Task<ActionResult<IEnumerable<dtInvTransactions>>> GetImportTransactions(long vid, string SBasicType, string DBasicType, string key)
        {
            return await _repository.GetImportTransactions(vid, SBasicType, DBasicType,key);

        }
    }
}
