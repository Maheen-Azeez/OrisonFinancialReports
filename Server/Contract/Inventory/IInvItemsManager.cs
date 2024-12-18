using OrisonMIS.Shared.Entities.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Server.Contract.Inventory
{
    public interface IInvItemsManager : IDisposable
    {
        public Task<List<dtItems>> GetItems(int BranchId, string key);

        public Task<dtItems> GetItemsbyID(int BranchId, int ItemID, string key);
    }
}
