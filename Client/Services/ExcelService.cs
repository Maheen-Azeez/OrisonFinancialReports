using Blazored.SessionStorage;
using System.Net.Http.Json;
using System.Web;
using static System.Net.WebRequestMethods;

namespace OrisonMIS.Client.Services
{
    public class ExcelService
    {
        private readonly HttpClient httpClient;
        private readonly ISessionStorageService sessionStorage;
        private string? key;
        public ExcelService(HttpClient httpClient, ISessionStorageService sessionStorage)
        {
            this.httpClient = httpClient;
            this.sessionStorage = sessionStorage;
        }
        public async Task<MemoryStream> DownloadExcel(int BranchId, string DateFrom, string DateTo)
        {
            try
            {
                key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
                var response = await httpClient.GetAsync($"api/ExcelExport/DownloadExcel?BranchId={BranchId}&DateFrom={DateFrom}&DateTo={DateTo}&key={key}");

                if (response.IsSuccessStatusCode)
                {
                    var ms = new MemoryStream();
                    await response.Content.CopyToAsync(ms);
                    ms.Position = 0;
                    return ms;
                }
            }
            catch (Exception ex)
            {
                // Log the error message
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}
