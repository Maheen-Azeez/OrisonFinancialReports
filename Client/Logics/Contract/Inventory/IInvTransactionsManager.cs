using OrisonMIS.Shared.Entities.Inventory;
using System.Collections.ObjectModel;
using System.Data;

namespace OrisonMIS.Client.Logics.Contract.Inventory
{
    public interface IInvTransactionsManager
    {
        public  Task<ObservableCollection<dtInvTransactions>> GetTransactions(long vid,string Criteria);
        public Task<ObservableCollection<dtInvTransactions>> GetImportTransactions(long vid, string SBasicType, string DBasicType);
        Task<long> CreateTransactions(dtInvTransactions trans, IDbConnection db, IDbTransaction tran);

        void UpdateTransactions(dtInvTransactions trans, IDbConnection db, IDbTransaction tran);

    }
}
