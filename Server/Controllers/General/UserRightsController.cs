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
    public class UserRightsController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IUserRightsManager _repository;

        public UserRightsController( IWebHostEnvironment environment, IUserRightsManager repository)
        {
            _environment = environment;
            _repository = repository;
        }
        // GET: api/UserRights?ID=UserID&Keyword=Keyword&Module=mod&BranchId=31
        [HttpGet]
        public async Task<ActionResult<UserRights>> GetUserRights(int ID,string Keyword, string Module, int BranchID, string key)
        {
            var UserRights = await _repository.GetUserRights(ID,Keyword,Module,BranchID,key);

            if (UserRights == null)
            {
                return UserRights=new UserRights();
            }
            return UserRights;
        }
        // GET: api/UserRights/MenuRights?Criteria=Criteria&ID=UserID&Keyword=Keyword&Module=mod&BranchId=31
        // GET: api/UserRights/Criteria/Keyword/Module/BranchId/userid

        [HttpGet]
        [Route("MenuRight")]
        public async Task<ActionResult<bool>> GetMenuRight(string Criteria, string Keyword, string Module, int BranchID, int UserID, string key)
        {
            return await _repository.GetMenuRight(Criteria, Keyword, Module, BranchID, UserID,key);
        }
    }
}
