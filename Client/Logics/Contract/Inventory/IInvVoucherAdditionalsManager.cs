using OrisonMIS.Shared.Entities.Inventory;
using System.Data;

namespace OrisonMIS.Client.Logics.Contract.Inventory
{
    public interface IInvVoucherAdditionalsManager
    {
        public Task<dtInvVoucherAdditionals> GetVoucherAdditionals(long VId);
         Task<long> CreateVoucherAdditionals(dtInvVoucherAdditionals dtInvVoucherAdditionals, IDbConnection db, IDbTransaction tran);
        public void UpdateVoucherAdditionals(dtInvVoucherAdditionals dtInvVoucherAdditionals, IDbConnection db, IDbTransaction tran);
    }
}
