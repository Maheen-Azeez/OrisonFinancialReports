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
    public class ChequeController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private ICheque _repository;
        public ChequeController(IWebHostEnvironment environment, ICheque repository)
        {
            _environment = environment;
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));

        }

        // GET: api/Cheque?VId=16534
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cheque>>> Get(long VId, string key)
        {
            return await _repository.ShowCheque(VId, key);

        }
    }
}
