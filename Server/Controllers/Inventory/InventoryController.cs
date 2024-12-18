using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.Inventory;
using OrisonMIS.Shared.Entities.Inventory;


namespace OrisonMIS.Server.Controllers.Inventory
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IInventoryManager _repository;
        private IInventoryRegisterManager inventoryRegisters;
        public InventoryController(IWebHostEnvironment environment, IInventoryManager repository, IInventoryRegisterManager inventoryRegisters)
        {
            _environment = environment;
            _repository = repository ?? throw new ArgumentNullException(nameof(_repository));
            this.inventoryRegisters = inventoryRegisters;
        }
        [HttpPost]
        public async Task<HttpResponseMessage> AddData(dtsInventory value, string key)
        {
            long ID = 0;
            ID = await _repository.CreateInventory(value,key);
            HttpResponseMessage msg = new HttpResponseMessage();
            msg.StatusCode = (System.Net.HttpStatusCode)1;
            return msg;

        } 
        
        [HttpGet]
        [Route("GetStockRegister")]
        public async Task<List<StockRegisterDto>> FetchStockRegister(DateTime dateUpTo, int branchId, int wareHouseId,string key)
        {
            return await inventoryRegisters.FetchStockRegister(dateUpTo, branchId, wareHouseId, key);
        }
        [HttpGet]
        [Route("GetInventoryRegister")]
        public async Task<List<InventoryRegisterDto>> FetchInventoryRegister(int branchId, DateTime dateFrom, DateTime dateUpTo, int itemId, int categoryId, string key)
        {
            return await inventoryRegisters.FetchInventoryRegister(branchId, dateFrom, dateUpTo, itemId, categoryId, key);
        }
        [HttpGet]
        [Route("GetWarehouses")]
        public async Task<List<WareHosueDto>> FetchWarehouses(int branchId,string key)
        {
            return await inventoryRegisters.FetchWarehouses(branchId, key);
        }
        [HttpGet]
        [Route("GetItems")]
        public async Task<List<InventoryItemMasterDto>> FetchItems(int branchId,string key)
        {
            return await inventoryRegisters.FetchItems(branchId, key);
        }
        [HttpGet]
        [Route("GetCategories")]
        public async Task<List<CategoryDto>> FetchCategories(int branchId,string key)
        {
            return await inventoryRegisters.FetchCategories(branchId, key);
        }
    }
}
