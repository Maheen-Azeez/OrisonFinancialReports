using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Server.Controllers.Inventory
{
    [Route("api/[controller]")]
    [ApiController]
    public class dtInvGroupItemController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IInvGroupItemsManager _repository;
        public dtInvGroupItemController(IWebHostEnvironment environment, IInvGroupItemsManager repository)
        {
            _environment = environment;
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));

        }
        // GET: api/dtInvGroupItem?Id=10293
        [HttpGet]
        public async Task<IActionResult> Get(long Id, string key)
        {
            return Ok(await _repository.GetGroupItems(Id,key));
        }
    }
}
