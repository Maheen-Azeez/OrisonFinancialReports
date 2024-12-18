using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.General;

namespace OrisonMIS.Server.Controllers.General
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrisonDataController : ControllerBase
    {
        private readonly IOrisonManager orisonManager;

        public OrisonDataController(IOrisonManager orisonManager)
        {
            this.orisonManager = orisonManager;
        }
        [HttpGet]
        [Route("GetDashBoardData")]
        public async Task<IActionResult> GetDashBoardData(string Head,string SchoolCode,int Branchid, string key) { 
            var result = await orisonManager.Get(Head, SchoolCode, Branchid, key);
            return Ok(result);
        }
        [HttpGet]
        [Route("GetDashBoardDataFT")]
        public async Task<IActionResult> GetDashBoardDataFT(string Head, string SchoolCode, DateTime fromdate, DateTime todate, int Branchid, string key) { 
            var result = await orisonManager.Get(Head, SchoolCode,fromdate,todate, Branchid, key);
            return Ok(result);
        }
        [HttpGet]
        [Route("GetDashBoardDataFTA")]
        public async Task<IActionResult> GetDashBoardDataFTA(String Head, String SchoolCode, DateTime fromdate, DateTime todate, int Branchid, int AccountID, string key) { 
            var result = await orisonManager.Get(Head, SchoolCode,fromdate,todate, Branchid,AccountID, key);
            return Ok(result);
        }
    }
}
