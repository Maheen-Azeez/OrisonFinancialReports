using OrisonMIS.Server.Concrete.BoldReport;
using OrisonMIS.Server.Concrete.Financial;
using OrisonMIS.Server.Concrete.Financial.Main;
using OrisonMIS.Server.Concrete.General;
using OrisonMIS.Server.Concrete.Inventory;
using OrisonMIS.Server.Concrete.Inventory.BoldReport;
using OrisonMIS.Server.Concrete.Inventory.Reports;
using OrisonMIS.Server.Concrete.VAT;
using OrisonMIS.Server.Contract.BoldReport;
using OrisonMIS.Server.Contract.Financial;
using OrisonMIS.Server.Contract.Financial.Main;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Server.Contract.Inventory;
using OrisonMIS.Server.Contract.Inventory.BoldReport;
using OrisonMIS.Server.Contract.Inventory.Reports;
using OrisonMIS.Server.Contract.VAT;
using OrisonMIS.Server.Exceptions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddTransient<ICompanyManager, CompanyManager>();
builder.Services.AddTransient<IDapperManager, DapperManager>();
builder.Services.AddTransient<IUserLoginManager, UserLoginManager>();
builder.Services.AddTransient<IDBOperation, DBOperation>();
builder.Services.AddTransient<IEntryModeManager, EntryModeManager>();
builder.Services.AddTransient<IInvAccounts, InvAccounts>();
builder.Services.AddTransient<IMyApprovalsManager, MyApprovalsManager>();
builder.Services.AddTransient<IUserRightsManager, UserRightsManager>();
builder.Services.AddTransient<IUserTrackManager, UserTrackManager>();
builder.Services.AddTransient<IVoucherMasterManager, VoucherMasterManager>();

builder.Services.AddTransient<IAccountAllocationManager, AccountAllocationManager>();
builder.Services.AddTransient<IAccountList, AccountListManager>();
builder.Services.AddTransient<IBillsVw, BillsVwManager>();
builder.Services.AddTransient<ICheque, ChequeManager>();
builder.Services.AddTransient<IReceiptManager, ReceiptManager>();
builder.Services.AddTransient<IVEntry, VEntryManager>();
builder.Services.AddTransient<IVoucher, VoucherManager>();
builder.Services.AddTransient<IVoucherAllocation, VoucherAllocationManager>();
builder.Services.AddTransient<IAccStmt, AcctStmtManager>();
builder.Services.AddTransient<IBillWiseStmt, BillWiseStmtManager>();
builder.Services.AddTransient<IBS, BSManager>();
builder.Services.AddTransient<ICashFlow, CashFlowManager>();
builder.Services.AddTransient<IItemMasterManager, ItemMasterManager>();
builder.Services.AddTransient<IPartyRegister, PartyRegisterManager>();
builder.Services.AddTransient<IPnL, PnLManager>();

builder.Services.AddTransient<IReportViewerManager, ReportViewerManager>();
builder.Services.AddTransient<IReportsManager, ReportsManager>();
builder.Services.AddTransient<IInvAccountsManager, InvAccountsManager>();
builder.Services.AddTransient<IInventoryManager, InventoryManager>();
builder.Services.AddTransient<IInvGroupItemsManager, InvGroupItemsManager>();
builder.Services.AddTransient<IInvItemsManager, InvItemsManager>();
builder.Services.AddTransient<IInvTransactionsManager, InvTransactionsManager>();
builder.Services.AddTransient<IInvVoucherAdditionalsManager, InvVoucherAdditionalsManager>();
builder.Services.AddTransient<IInvVoucherEntryManager, InvVoucherEntryManager>();
builder.Services.AddTransient<IInvVoucherManager, InvVoucherManager>();
builder.Services.AddTransient<IInvVoucherStatusManager, InvVoucherStatusManager>();
builder.Services.AddTransient<ITranCostCentreManager, TranCostCentreManager>();
builder.Services.AddTransient<IVEntryCostCentreManager, VEntryCostCentreManager>();
builder.Services.AddTransient<IConsolidated, ConsolidatedManager>();
builder.Services.AddTransient<IBoldReportManager, BoldReportManager>();
builder.Services.AddTransient<IOrisonManager, OrisonManager>();
builder.Services.AddTransient<IFinancialManager, FinancialManager>();
builder.Services.AddTransient<IDateTimeRepository, DateTimeRepository>();
builder.Services.AddTransient<IVatManager, VatManager>();
builder.Services.AddScoped<IInventoryRegisterManager, InventoryRegisterManager>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
}
app.UseMiddleware<ExceptionHandlingMiddleware>();
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
