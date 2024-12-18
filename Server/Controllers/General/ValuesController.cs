using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.General;


namespace OrisonMIS.Server.Controllers.General
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IDBOperation _repository;
        private IUserTrackManager _userTrack;
        public ValuesController( IWebHostEnvironment environment, IDBOperation repository)
        {
            _environment = environment;
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        // GET: api/values/'Sales POS'
        [HttpGet("{vtype}/{key}")]
        public async Task<int> GetVtype(string vtype, string key)
        {
            return await _repository.GetVtype(vtype,key);
        }

        [HttpGet("{k}/{vtype}/{user}/{key}")]
        public async Task<int> GetApprovalID(int k, string vtype, int user, string key)
        {
            return await _repository.GetApprovalID(k, vtype, user,key);
        }

        

        // GET: api/values/75/31
        [HttpGet("{vtype}/{_BranchId}/{key}")]
        public async Task<int> GetVNo(int vtype, int _BranchId, string key)
        {
            return await _repository.GetNextNo(vtype, _BranchId,key);
        }

        // GET: api/values?cmd=Select%20EntryFrom%20from%20company
        [HttpGet()]
        public async Task<object> GetScalar(string cmd, string key)
        {
           return await _repository.GetScalar(cmd,key);
        }
       
    }
}
