using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
//using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace OrisonMIS.Client.Services
{
    public class ReceiptService
    {
        int vtype, AccID;
        string Bal;
        HttpClient http = new HttpClient();
        private readonly ISessionStorageService SessionStorage;
        private string? key;
        //IDBOperation idbopn;
        public ReceiptService(HttpClient httpClient , ISessionStorageService SessionStorage)
        {
            http = httpClient;
            this.SessionStorage = SessionStorage;
           
        }

        public async Task<object> GetBalance(long AccId, int _BranchId)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            var Balc = await http.GetFromJsonAsync<object>("api/Balance/" + AccId + "/" + _BranchId + "/" + key);
            return Balc;
        }
    }

}