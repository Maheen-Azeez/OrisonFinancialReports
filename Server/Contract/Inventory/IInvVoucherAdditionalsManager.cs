using OrisonMIS.Shared.Entities.Inventory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Server.Contract.Inventory
{
    public interface IInvVoucherAdditionalsManager : IDisposable
    {
        public Task<dtInvVoucherAdditionals> GetVoucherAdditionals(long VId, string key);
        Task<long> CreateVoucherAdditionals(dtInvVoucherAdditionals dtInvVoucherAdditionals, IDbConnection db, IDbTransaction tran);
        void UpdateVoucherAdditionals(dtInvVoucherAdditionals dtInvVoucherAdditionals, IDbConnection db, IDbTransaction tran);
    }
}
