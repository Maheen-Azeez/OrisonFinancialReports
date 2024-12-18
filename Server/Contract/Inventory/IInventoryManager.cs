using OrisonMIS.Shared.Entities.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Server.Contract.Inventory
{
    public interface IInventoryManager : IDisposable
    {
        Task<long> CreateInventory(dtsInventory Inventory, string key);
        //void UpdateInventory(dtsInventory Inventory);
    }
}
