﻿using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Client.Logics.Contract.Financial;
using OrisonMIS.Shared.Entities.Financial;
using Syncfusion.Blazor.Diagrams;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.Financial
{
    public class CashFlowManager : ICashFlow
    {

        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        string? key;
        public CashFlowManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;

        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public async Task<IEnumerable<CashFlow>> Show(long BranchId, string DateFrom, string DateTo)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<CashFlow[]>("api/CashFlow?BranchId=" + BranchId + "&_FD=" + DateFrom + "&_TD=" + DateTo + "&key=" + key);

        }


    }
}