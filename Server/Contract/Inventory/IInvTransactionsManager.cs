using OrisonMIS.Shared.Entities.Inventory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Server.Contract.Inventory
{
    public interface IInvTransactionsManager : IDisposable
    {
        public Task<List<dtInvTransactions>> GetTransactions(long vid, string criteria, string key);
        public Task<List<dtInvTransactions>> GetImportTransactions(long vid, string SBasicType, string DBasicType, string key);
        Task<long> TransactionsEvents(dtInvTransactions trans, IDbConnection db, IDbTransaction tran);
        Task<long> CreateTransactions(dtInvTransactions trans, IDbConnection db, IDbTransaction tran);

        void UpdateTransactions(dtInvTransactions trans, IDbConnection db, IDbTransaction tran);
        void DeleteTransactions(dtInvTransactions trans, IDbConnection db, IDbTransaction tran);

    }
}
