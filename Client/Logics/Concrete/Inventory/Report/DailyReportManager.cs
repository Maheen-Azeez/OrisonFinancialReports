using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Client.Logics.Contract.Inventory.Report;
using OrisonMIS.Shared.Entities.Inventory.Reports;
using Syncfusion.Blazor.Diagrams;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.Inventory.Report
{
    public class DailyReportManager : IDailyReportManager
    {

        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        string? key;
        public DailyReportManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;

        }
        public async Task<IEnumerable<DailyReport>> DailyReport(int userid, string FDate, string TDate)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<DailyReport[]>("api/DailyReport/" + userid + "/" + FDate + "/" + TDate + "/" + key);//"/"+FDate+"/"+TDate
        }
        public async Task<IEnumerable<DailyReport>> DailyReportDetailed(int userid, string FDate, string TDate, string Crt)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<DailyReport[]>("api/DailyReport/" + userid + "/" + FDate + "/" + TDate + "/" + Crt + "/" + key);//"/"+FDate+"/"+TDate+"/
        }

    }
}
