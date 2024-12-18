using OrisonMIS.Shared.Entities.Financial;
using OrisonMIS.Shared.Entities.General;

namespace OrisonMIS.Server.Contract.Financial
{
    public interface IItemMasterManager
    {
        public Task<List<string>> GetCombo(string Criteria, string key);
        public Task<List<dtInvAccounts>> GetAccountsCombo(string Description,string Criteria, string key);
        public Task<IEnumerable<dtItemMaster>> GetItemMasterbyID( string ID, string key);
        public Task<IEnumerable<dtItemMaster>> GetItemMaster(string key);
        Task<long> CreateItemMaster(dtItemMaster ItemMaster, string key);
    }
}
