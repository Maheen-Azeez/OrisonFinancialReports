using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.Financial;
using OrisonMIS.Shared.Entities.Financial;


namespace OrisonMIS.Server.Controllers.Financial
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartyRegisterController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IPartyRegister _repository;
        private IAccStmt _repo;
        public PartyRegisterController(IWebHostEnvironment environment, IPartyRegister repository, IAccStmt repo)
        {
            _environment = environment;
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _repo = repo ?? throw new ArgumentNullException(nameof(repo));

        }
        // GET: api/PartyRegister?AccCategory=Customer&BranchId=31
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<PartyRegister>>> Get(string AccCategory, long BranchId, string key)
        //{
        //    return await _repository.Show(AccCategory, BranchId, key);

        //}
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PDC>>> GetPDC(long BranchId, string status, string key)
        {
            DateTime _Date, _TDate;
            var AcctStmt = new List<PDC>();
            try
            {
                AcctStmt = await _repo.ShowPDC(BranchId, status, key);
            }
            catch (Exception ex)
            { }
            return AcctStmt;


        }
    }
}
