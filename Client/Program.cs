using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using OrisonMIS.Client;
using OrisonMIS.Client.Logics.Concrete.BoldReport;
using OrisonMIS.Client.Logics.Concrete.DashBoard;
using OrisonMIS.Client.Logics.Concrete.Financial;
using OrisonMIS.Client.Logics.Concrete.Financial.Main;
using OrisonMIS.Client.Logics.Concrete.General;
using OrisonMIS.Client.Logics.Concrete.Inventory;
using OrisonMIS.Client.Logics.Concrete.Inventory.BoldReport;
using OrisonMIS.Client.Logics.Concrete.Inventory.Report;
using OrisonMIS.Client.Logics.Contract.BoldReport;
using OrisonMIS.Client.Logics.Contract.DashBoard;
using OrisonMIS.Client.Logics.Contract.Financial;
using OrisonMIS.Client.Logics.Contract.Financial.Main;
using OrisonMIS.Client.Logics.Contract.General;
using OrisonMIS.Client.Logics.Contract.Inventory;
using OrisonMIS.Client.Logics.Contract.Inventory.BoldReport;
using OrisonMIS.Client.Logics.Contract.Inventory.Report;
using OrisonMIS.Client.Services;
using OrisonMIS.Concrete.General;
using OrisonMIS.Logics.Contracts.General;
using OrisonMIS.Services;
using OrisonMIS.Client.Shared;
using Syncfusion.Blazor;
using System.Globalization;
using OrisonMIS.Client.Logics.Contract.VAT;
using OrisonMIS.Client.Logics.Concrete.VAT;

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mjg4MTM1NEAzMjMzMmUzMDJlMzBqRmVQakZoOElPUTRIeVZMUzdYdkxnVnlHSFJPdkdZNkxFc3FDeGhVYXB3PQ==");
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddSyncfusionBlazor();
builder.Services.AddBlazoredSessionStorage();

//For Arabic Language
builder.Services.AddLocalization();
builder.Services.AddSingleton(typeof(ISyncfusionStringLocalizer), typeof(SyncfusionLocalizer));
var host = builder.Build();

var jsInterop = host.Services.GetRequiredService<IJSRuntime>();
var result = await jsInterop.InvokeAsync<string>("cultureInfo.get");
CultureInfo culture;
if (result != null)
{
    culture = new CultureInfo(result);
}
else
{
    culture = new CultureInfo("en-US");
    await jsInterop.InvokeVoidAsync("cultureInfo.set", "en-US");
}
CultureInfo.DefaultThreadCurrentCulture = culture;
CultureInfo.DefaultThreadCurrentUICulture = culture;
//For Arabic Language

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ICompanyManager, CompanyManager>();
builder.Services.AddScoped<IAccounts, Account>();
builder.Services.AddScoped<IUserLoginManager, UserLoginManager>();
builder.Services.AddScoped<IAttendanceService, AttendanceService>();
builder.Services.AddScoped<IAccountAllocation, AccountAllocationManager>();
builder.Services.AddScoped<IAccountList, AccountListManager>();
builder.Services.AddScoped<IBillVw, BillVwManager>();
builder.Services.AddScoped<ICheque, ChequeManager>();
builder.Services.AddScoped<IReceiptManager, ReceiptManager>();
builder.Services.AddScoped<IVEntry, VEntryManager>();
builder.Services.AddScoped<IVoucher, VoucherManager>();
builder.Services.AddScoped<IVoucherAllocation, VoucherAllocationManager>();
builder.Services.AddScoped<IAccStmt, AcctStmtManager>();
builder.Services.AddScoped<IBillWiseStmt, BillWiseStmtManager>();
builder.Services.AddScoped<IBS, BSManager>();
builder.Services.AddScoped<ICashFlow, CashFlowManager>();
builder.Services.AddScoped<IConsolidated, ConsolidatedManager>();
builder.Services.AddScoped<IItemMasterManager, ItemMasterManager>();
builder.Services.AddScoped<IPartyRegister, PartyRegisterManager>();
builder.Services.AddScoped<IPnL, PnLManager>();
builder.Services.AddScoped<IStmt, StmtManager>();
builder.Services.AddScoped<IEntryModeManager, EntryModeManager>();
builder.Services.AddScoped<IMyApprovalsManager, MyApprovalsManager>();
builder.Services.AddScoped<IUserTrackManager, UserTrackManager>();
builder.Services.AddScoped<IVoucherMasterManager, VoucherMasterManager>();

builder.Services.AddScoped<IReportViewerManager, ReportViewerManager>();
builder.Services.AddScoped<IDailyReportManager, DailyReportManager>();
builder.Services.AddScoped<IInvAccountManager, InvAccountManager>();
builder.Services.AddScoped<IInvAccounts, InvAccounts>();
builder.Services.AddScoped<IInventoryManager, InventoryManager>();
builder.Services.AddScoped<IInvGroupItemsManager, InvGroupItemsManager>();
builder.Services.AddScoped<IInvItemsManager, InvItemsManager>();
builder.Services.AddScoped<IInvTransactionsManager, InvTransactionsManager>();
builder.Services.AddScoped<IInvVoucherAdditionalsManager, InvVoucherAdditionalsManager>();
builder.Services.AddScoped<IInvVoucherEntryManager, InvVoucherEntryManager>();
builder.Services.AddScoped<IInvVoucherManager, InvVoucherManager>();
builder.Services.AddScoped<IInvVoucherStatusManager, InvVoucherStatusManager>();
builder.Services.AddScoped<IBoldReportManager, BoldReportManager>();
builder.Services.AddScoped<IFinancialManager, FinancialManager>();
builder.Services.AddScoped<IVatManager, VatManager>();
builder.Services.AddScoped<IInventoryRegisterManager, InventoryRegisterManager>();

builder.Services.AddScoped<AccountService>();
builder.Services.AddScoped<TaxInvoiceService>();
builder.Services.AddScoped<UserRightsService>();
builder.Services.AddScoped<FinServices>();
builder.Services.AddScoped<VoucherEntryService>();
builder.Services.AddScoped<ReceiptService>();
builder.Services.AddScoped<CacheVersionService>();
builder.Services.AddScoped<GlobalService>();
builder.Services.AddScoped<ExcelService>();
builder.Services.AddScoped<FinancialDateTimeService>();
builder.Services.AddScoped<ToastService>();
builder.Services.AddScoped<AccountStatementCacheService>();

await builder.Build().RunAsync();
