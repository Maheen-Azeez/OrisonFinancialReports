using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.General;

namespace OrisonMIS.Server.Controllers.General
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IDBOperation _repository;
        public WarehouseController( IWebHostEnvironment environment, IDBOperation repository)
        {
            _environment = environment;
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        // GET: api/Warehouse/id
        [HttpGet("{ID}/{key}")]
        public async Task<object> GetWarehouse(int ID, string key)
        {
            WarehouseMaster objWarehouse = new WarehouseMaster() { ID = 0, WHCode = "" };
            var Warehouse = await _repository.GetWarehouse(ID,key);
            if (Warehouse == null)
            {
                return objWarehouse;
            }

            return Warehouse;
        }
        public async Task<ActionResult<IEnumerable<WarehouseMaster>>> GetWarehouse(string key)
        {
            //WarehouseMaster objWarehouse = new WarehouseMaster() { ID = 0, WHCode = "" };
            var Warehouse = await _repository.GetWarehouse(key);
            if (Warehouse == null)
            {
                return null;
            }

            return Warehouse;
        }
    }
}
