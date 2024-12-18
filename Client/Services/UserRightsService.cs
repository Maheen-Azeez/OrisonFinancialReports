using Blazored.SessionStorage;
using OrisonMIS.Shared.Entities.General;
using Syncfusion.Blazor.Diagrams;
using System.Net.Http.Json;
using System.Web;

namespace OrisonMIS.Client.Services
{
    public class UserRightsService
    {
        HttpClient http = new HttpClient();
        private readonly ISessionStorageService SessionStorage;
        private string? key;
        public UserRightsService(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            http = httpClient;
            this.SessionStorage = SessionStorage;
        }
        //public string GetBaseUrl()
        //{
        //    return BaseUrl;
        //}
        public async Task<UserRights> GetUserRights(int UserID, string Keyword, string Module, int BranchID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            UserRights _UserRights = await http.GetFromJsonAsync<UserRights>("api/UserRights?ID=" + UserID + "&Keyword=" + Keyword + "&Module=" + Module + "&BranchId=" + BranchID + "&key=" + key);
            return _UserRights;
        }
        public async Task<string> GetURl(string type, int AccountID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            string url = "";
            if (type == "Home")
                url = await http.GetStringAsync("api/Home/getURL?AccountID=" + AccountID + "&key=" + key);
            else if (type == "Logout")
                url = await http.GetStringAsync("api/Logout?AccountID=" + AccountID + "&key=" + key);
            return url;
        }
        public async Task<bool> GetMenuRight(string Criteria, string Keyword, string Module, int BranchID, int UserID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            //return await http.GetFromJsonAsync<int>(BaseUrl + "UserRights/" + Criteria + "/" + Keyword + "/" + Module + "/" + BranchID + "/" + UserID);
            return await http.GetFromJsonAsync<bool>("api/UserRights/MenuRight?Criteria=" + Criteria + "&Keyword=" + Keyword + "&Module=" + Module + "&BranchID=" + BranchID + "&UserID=" + UserID + "&key=" + key);
        }
    }
}
