using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
    public class EntryModeController : ControllerBase
    {
        private IEntryModeManager _repository;

        public EntryModeController( IEntryModeManager repository)
        {
            _repository = repository;
        }
        // GET: api/UserRights?ID=UserID&Keyword=Keyword&Module=mod&BranchId=31
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EntryModeMaster>>> GetAllEntryMode(string key)
        {
            List<EntryModeMaster> EEM = (List<EntryModeMaster>)await _repository.GetAllEntryMode(key);

            if (EEM == null)
            {
                return NotFound();
            }

            return EEM;
        }
        [HttpGet("{type}/{key}")]
        public async Task<ActionResult<EntryModeMaster>> GetEntryMode(string type, string key)
        {
            var EEM = await _repository.GetEntryMode(type,key);

            if (EEM == null)
            {
                return EEM = new EntryModeMaster();
            }

            return EEM;
        }
    }
}
