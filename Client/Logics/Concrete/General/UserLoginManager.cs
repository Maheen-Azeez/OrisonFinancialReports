using Blazored.SessionStorage;
using OrisonMIS.Client.Logics.Contract.General;
using OrisonMIS.Shared.Entities.General;
using Syncfusion.Blazor.Diagrams;
using System.Net.Http.Json;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.General
{
    public class UserLoginManager : IUserLoginManager
    {
       
        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        private string? key;
        public UserLoginManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;
           
        }
        public async Task<IEnumerable<UserLogin>> GetUserData(int UserID, int BranchID)
        {
            try
            {
                key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
                //key = HttpUtility.UrlEncode("0788raV9skPhrv+Bn2YGUp2A86qS5x1kh7H3J6zSxbz985wC3Xx4YJ4qHNkpoypq");
                return await httpClient.GetFromJsonAsync<UserLogin[]>("api/UserLogin?UserID=" + UserID + "&BranchID=" + BranchID + "&key=" + key);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<IEnumerable<UserLogin>> GetUserDataAllBranches(int UserID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetFromJsonAsync<IEnumerable<UserLogin>>("api/UserLogin/GetUserDataAllBranches?UserID=" + UserID + "&key=" + key);
        }
        public async Task<IEnumerable<MenuMasterData>> GetMenuData(int UserID, string BranchID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetFromJsonAsync<IEnumerable<MenuMasterData>>("api/UserLogin/GetMenuData?UserID=" + UserID + "&BranchID" + BranchID + "&key=" + key);
            //throw new NotImplementedException();
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
                // Dispose of any managed resources here
            }
            // Dispose of any unmanaged resources here
        }
    }
}



