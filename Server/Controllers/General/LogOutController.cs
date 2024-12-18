using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Server.Controllers.General
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogOutController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IDBOperation _repository;

        public LogOutController(IWebHostEnvironment environment, IDBOperation repository)
        {
            _environment = environment;
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));


        }
        [HttpGet]
        public async Task<string> getLogoutUrl(int AccountID, string key)
        {
            return await _repository.getLogoutUrl(AccountID,key);
        }

    }
}
