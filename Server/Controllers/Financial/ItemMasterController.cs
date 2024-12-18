using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.Financial;
using OrisonMIS.Shared.Entities.Financial;
using OrisonMIS.Shared.Entities.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace OrisonMIS.Server.Controllers.Financial
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemMasterController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IItemMasterManager _repository;
        public ItemMasterController(IWebHostEnvironment environment, IItemMasterManager repository)
        {
            _environment = environment;
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));

        }
        // GET: api/ItemMaster/(unitmaster/category/MajorGroup/MiddleGroup/MinorGroup)
        [HttpGet]
        [Route("GetCombo")]
        public async Task<ActionResult<IEnumerable<string>>> GetdtItems(string Criteria, string key)
        {
            return await _repository.GetCombo(Criteria,key);
        }
        // GET: api/ItemMaster/Item Cost Account/Accounts
        [HttpGet]
        [Route("GetAccountsCombo")]
        public async Task<ActionResult<IEnumerable<dtInvAccounts>>> GetAccounts(string Description, string Criteria, string key)
        {
            return await _repository.GetAccountsCombo(Description, Criteria, key);
        }
        // POST api/ItemMaster
        [HttpPost]
        public async Task<HttpResponseMessage> AddData(dtItemMaster value, string key)
        {
            long ID = 0;
            ID = await _repository.CreateItemMaster(value, key);
            HttpResponseMessage msg = new HttpResponseMessage();
            msg.StatusCode = (System.Net.HttpStatusCode)1;
            return msg;

        }
        //[HttpGet]
        //public async Task<IEnumerable<dtItemMaster>> GetItemMasterbyID( string itemid)
        //{
        //    return await _repository.GetItemMasterbyID(itemid);

        //}
        [HttpGet]
        [Route("GetItemMaster")]
        public async Task<IEnumerable<dtItemMaster>> GetItemMaster(string ItemID, string key)
        {
            if (ItemID == null)
                return await _repository.GetItemMaster(key);
            else
                return await _repository.GetItemMasterbyID(ItemID, key);

        }
    }
}
