using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.Financial.Main;
using OrisonMIS.Shared.Entities.Financial;


namespace OrisonMIS.Server.Controllers.Financial.Main
{
    [Route("api/[controller]")]
    [ApiController]
    public class VEntryController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IVEntry _repository;
        public VEntryController(IWebHostEnvironment environment, IVEntry repository)
        {
            _environment = environment;
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));

        }

        // GET: api/VEntry?VId=16534
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VEntry>>> Get(long VId, string key)
        {
            return await _repository.Show(VId, key);

        }
    }
}
