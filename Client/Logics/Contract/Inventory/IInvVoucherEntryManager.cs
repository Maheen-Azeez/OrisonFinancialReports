using OrisonMIS.Shared.Entities.Inventory;
using System.Collections.ObjectModel;
using System.Data;

namespace OrisonMIS.Client.Logics.Contract.Inventory
{
    public interface IInvVoucherEntryManager
    {
        public  Task<ObservableCollection<dtInvVoucherEntry>> GetVoucherEntry(long vid);
        public Task<long> CreateVoucherEntry(dtInvVoucherEntry dtInvVoucherEntry, IDbConnection db, IDbTransaction tran);
        //public void UpdateVoucherEntry(dtInvVoucherEntry dtInvVoucherEntry, IDbConnection db, IDbTransaction tran);
    }
}
