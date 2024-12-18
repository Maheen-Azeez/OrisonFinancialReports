using OrisonMIS.Shared.Entities.Financial;
using OrisonMIS.Shared.Entities.General;

namespace OrisonMIS.Client.Logics.Contract.Financial
{
    public interface IItemMasterManager
    {
        public Task<IEnumerable<string>> GetCombo(string Criteria);
        public Task<List<dtInvAccounts>> GetAccountsCombo(string Description, string Criteria);
        public Task<IEnumerable<dtItemMaster>> GetItemMaster(string ID);
        Task<HttpResponseMessage> CreateItemMaster(dtItemMaster ItemMaster);
    }
}
