using OrisonMIS.Shared.Entities.Inventory;
using System.Data;

namespace OrisonMIS.Client.Logics.Contract.Inventory
{
    public interface IInvVoucherManager
    {
        //public  Task<dtInvVoucher> GetVoucher(long id);
        public  Task<dtInvVoucher> GetVoucher(long VId);
        //public long CreateVoucher(dtInvVoucher InvVoucher);
         Task<long> CreateVoucher(dtInvVoucher InvVoucher, IDbConnection db, IDbTransaction tran);
        public void CancelVoucher(long vID);
        public void DeleteVoucher(long VId);
        //public Task<List<dtInvVoucher>> CreateVoucher(List<dtInvVoucher> InvVoucher);

    }
}
