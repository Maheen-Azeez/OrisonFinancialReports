using Blazored.SessionStorage;
using OrisonMIS.Shared.Entities.Financial;
using OrisonMIS.Shared.Entities.General;
using System.Collections.ObjectModel;
using System.Web;

namespace OrisonMIS.Client.Services
{
    public class GlobalService
    {
        private string? key;
        private string? globalCurrencyFormat;
        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;

        public GlobalService(HttpClient _httpClient, ISessionStorageService _SessionStorage)
        {
            this.httpClient = _httpClient;
            this.SessionStorage = _SessionStorage;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
        }

        public List<TrialBal>  TrialBalance { get; set; } = new List<TrialBal>();
        public List<TrialBal>  TrialBalanceDetailed { get; set; } = new List<TrialBal>();
        
        public IList<dtInvAccounts> AccountStatement = new List<dtInvAccounts>();
        
        
        public string? GlobalCurrencyFormat
        {
            get => globalCurrencyFormat;
            private set => globalCurrencyFormat = value;
        }
        public async Task<string> GetCurrencyMaster(int? BranchID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            string result = await httpClient.GetStringAsync("API/GlobalService/CurrencyMaster?BranchID=" + BranchID + "&Key=" + key);
            GlobalCurrencyFormat = result;
            return result;
        }
    }
}
