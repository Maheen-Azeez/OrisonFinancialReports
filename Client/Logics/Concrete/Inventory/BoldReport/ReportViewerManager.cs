using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Client.Logics.Contract.Inventory.BoldReport;
using OrisonMIS.Shared.Entities.Inventory;
using OrisonMIS.Shared.Entities.Inventory.BoldReport;
using System.Text.RegularExpressions;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.Inventory.BoldReport
{
    public class ReportViewerManager : IReportViewerManager
    {

        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        string? key;
        public ReportViewerManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;

        }
        public async Task<PurchaseOrder> GetPurchaseOrder(string VoucherID, string BranchID)
        {
            PurchaseOrder Result = new PurchaseOrder();
            try
            {
                key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
                Result = await httpClient.GetJsonAsync<PurchaseOrder>("api/ReportViewer?VoucherID=" + VoucherID + "&BranchID=" + BranchID + "&key=" + key);
            }
            catch (Exception ex) { }

            foreach (Transaction i in Result.TransactionDetails) { if (i.VarField3 != null) i.VarField3 = StripHTML(i.VarField3); }
            foreach (PurchaseDetails i in Result.OrderDetails) { if (i.FooterText != null) i.FooterText = StripHTML(i.FooterText); }
            return Result;
        }

        public async Task<List<Company>> GetCompany(string VoucherID, string BranchID)
        {
            var Result = await httpClient.GetJsonAsync<List<Company>>("api/ReportViewer/GetCompany?VoucherID=" + VoucherID + "&BranchID=" + BranchID);
            return Result;
        }
        public async Task<List<Transaction>> GetTransaction(string VoucherID, string BranchID)
        {
            var Result = await httpClient.GetJsonAsync<List<Transaction>>("api/ReportViewer/GetTransaction?VoucherID=" + VoucherID + "&BranchID=" + BranchID);
            foreach (Transaction i in Result) i.VarField3 = StripHTML(i.VarField3);
            return Result;
        }
        public async Task<List<dtInvVoucher>> GetVoucher(string VoucherID, string BranchID)
        {
            var Result = await httpClient.GetJsonAsync<List<dtInvVoucher>>("api/ReportViewer/GetVoucher?VoucherID=" + VoucherID);
            return Result;
        }
        public async Task<List<dtInvVoucherAdditionals>> GetVoucherAdditionals(string VoucherID, string BranchID)
        {
            var Result = await httpClient.GetJsonAsync<List<dtInvVoucherAdditionals>>("api/ReportViewer/GetVoucherAdditionals?VoucherID=" + VoucherID);
            foreach (dtInvVoucherAdditionals i in Result)
            {
                if (i.FooterText != null)
                    i.FooterText = StripHTML(i.FooterText);
                if (i.HeaderText != null)
                    i.HeaderText = StripHTML(i.HeaderText);
            }
            return Result;
        }
        public static string StripHTML(string input)
        {
            if (input != null)
            {
                input = input.Replace("&nbsp;", string.Empty);
                return Regex.Replace(input, "<.*?>", string.Empty);
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
