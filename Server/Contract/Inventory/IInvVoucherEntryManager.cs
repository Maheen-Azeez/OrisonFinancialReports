using OrisonMIS.Shared.Entities.Inventory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Server.Contract.Inventory
{
   public interface IInvVoucherEntryManager : IDisposable
    {
        public Task<List<dtInvVoucherEntry>> GetVoucherEntry(long vid, string key);
        public Task<long> VoucherEntryEvents(dtInvVoucherEntry dtInvVoucherEntry, IDbConnection db, IDbTransaction tran);
    }
}
