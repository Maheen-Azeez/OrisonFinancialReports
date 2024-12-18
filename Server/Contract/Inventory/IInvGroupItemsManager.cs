using OrisonMIS.Shared.Entities.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Server.Contract.Inventory
{
    public interface IInvGroupItemsManager : IDisposable
    {
        public Task<List<dtInvGroupItems>> GetGroupItems(long Id, string key);
    }
}
