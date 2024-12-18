using OrisonMIS.Shared.Entities.Inventory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Server.Contract.Inventory
{
   public interface IInvVoucherManager:IDisposable
    {
        public Task<dtInvVoucher> GetVoucher(long VId, string key);
		Task<long> VoucherEvent(dtInvVoucher InvVoucher, IDbConnection db, IDbTransaction tran);
        Task<long> CreateVoucher(dtInvVoucher InvVoucher, IDbConnection db, IDbTransaction tran);
        void UpdateVoucher(dtInvVoucher InvVoucher, IDbConnection db, IDbTransaction tran);
        public void CancelVoucher(long vID, string key);
        public void DeleteVoucher(long VId, string key);
    }
}
