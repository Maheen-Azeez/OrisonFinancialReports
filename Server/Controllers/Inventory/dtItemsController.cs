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
    public class dtItemsController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IInvItemsManager _repository;
        public dtItemsController(IWebHostEnvironment environment, IInvItemsManager repository)
        {
            _environment = environment;
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));

        }
        // GET: api/dtItems
        [HttpGet("{BranchID}/{key}")]
        public async Task<ActionResult<IEnumerable<dtItems>>> GetdtItems(int BranchID, string key)
        {
            return await _repository.GetItems(BranchID,key);

        }
        [HttpGet("{BranchID}/{ItemID}/{key}")]
        public async Task<ActionResult<dtItems>> GetdtItemsbyID(int branchID, int itemid, string key)
        {
            return await _repository.GetItemsbyID(branchID, itemid,key);

        }
    }
}
