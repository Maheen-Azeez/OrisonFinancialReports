using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.General;

namespace OrisonMIS.Server.Controllers.General
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IUserLoginManager _repository;

        public UserLoginController(IWebHostEnvironment environment, IUserLoginManager repository)
        {
            _environment = environment;
            _repository = repository;
        }
        // GET: api/UserLogin?UserID=606&BranchID=31
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserLogin>>> GetUserData(int UserID, int BranchID, string key)
        {
            var UserData = await _repository.GetUserData(UserID, BranchID,key);

            if (UserData == null)
            {
                return NotFound();
            }

            return UserData;
        }
        [HttpGet]
        [Route("GetMenuData")]
        public async Task<ActionResult<IEnumerable<MenuMasterData>>> GetMenuData(int UserID, string BranchID, string key)
        {
            var Data = await _repository.GetMenuData(UserID, BranchID,key);

            if (Data == null)
            {
                return NotFound();
            }

            return Data;
        }
        //[HttpGet("{UserID}/{key}")]
        [HttpGet]
        [Route("GetUserDataAllBranches")]
        public async Task<ActionResult<IEnumerable<UserLogin>>> GetUserDataAllBranches(int UserID, string key)
        {
            var UserData = await _repository.GetUserDataAllBranches(UserID,key);

            if (UserData == null)
            {
                return NotFound();
            }

            return UserData;
        }
        //public async Task<string> UserPhoto(int EmpID)
        //{
        //    return await _repository.UserPhoto(EmpID);
        //}
    }
}
