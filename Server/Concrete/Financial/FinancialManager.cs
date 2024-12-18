using Dapper;
using OrisonMIS.Server.Concrete.General;
using OrisonMIS.Server.Contract.Financial;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities;
using OrisonMIS.Shared.Entities.Financial;
using System.Data;

namespace OrisonMIS.Server.Concrete.Financial
{
    public class FinancialManager : IFinancialManager
    {
        private readonly IDapperManager dapperManager;

        public FinancialManager(IDapperManager dapperManager) {
            this.dapperManager = dapperManager;
        }

        public async Task<List<dtFinancialRegister>> GetData(int BranchId, DateTime DateFrom, DateTime DateTo, string key)
        {
            try
            {
                var dbPara = new DynamicParameters();
                //string cmdText = "SELECT c.VID,c.ID,b.ID as AccID,a.VDate,e.Abbreviation +'-'+ a.VNo as VNo,b.AccountCode,b.AccountName,A1.AccountCode as PAccountCode,A1.AccountName as PAccountName," +
                //                 "NameInArabic,c.Description,CM.Abbreviation as Currency,c.Debit,c.Credit,a.RefNo,C.Reference,d.ChequeNo,d.ChequeDate,a.CreatedDate,a.ModifiedDate," +
                //                 "(SELECT UserName FROM Users WHERE ID=a.CreatedUserID) as CreatedUser,(SELECT UserName FROM Users WHERE ID=a.ModifiedUserID) as ModifiedUser," +
                //                 "(Select VType From VTypeTran WHERE ID=a.VType) as VType,S.ID as SID,S.AccountName as StaffName,a.Voucheragainst,a.CommonNarration,0 as Alloted" +
                //                 "FROM Voucher a INNER JOIN VoucherEntry c ON a.ID = c.VID LEFT JOIN Cheques d ON c.ID = d.VEID INNER JOIN" +
                //                 "VTypeTran e ON a.VType = e.ID INNER JOIN Accounts b ON c.AccountID = b.ID Inner Join Accounts A1 On A1.ID=b.Parent" +
                //                 "Left Outer Join Accounts S On a.StaffID=S.ID Left Outer Join School_Students St On St.AccountID=b.ID" +
                //                 "Inner Join CurrencyMast CM On CM.ID=a.Currency  WHERE a.BranchID= @BranchId";

                dbPara.Add("BranchId", BranchId, DbType.Int32);
                dbPara.Add("FromDate", DateFrom, DbType.DateTime);
                dbPara.Add("ToDate", DateTo, DbType.DateTime);


                var AcctStmt = Task.FromResult(dapperManager.GetAll<dtFinancialRegister>
                                    ("FinRep_Financial_RegisterSP", key, dbPara, commandType: CommandType.StoredProcedure));
                return await AcctStmt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<dtFinancialRegisterPaging> GetData(int BranchId, DateTime DateFrom, DateTime DateTo, int pageNumber, int pageSize, string Search, string action, string? VType, string key)
        {
            try
            {
                dtFinancialRegisterPaging objFinancialRegisterPaging = new dtFinancialRegisterPaging();
                int offset = (pageNumber - 1) * pageSize;
                var dbPara = new DynamicParameters();
                dbPara.Add("BranchId", BranchId, DbType.Int32);
                dbPara.Add("FromDate", DateFrom, DbType.DateTime);
                dbPara.Add("ToDate", DateTo, DbType.DateTime);
                dbPara.Add("Offset", offset, DbType.Int32); 
                dbPara.Add("PageSize", pageSize, DbType.Int32);
                dbPara.Add("VType", VType, DbType.String);

                if (VType == "All")
                {
                    if (action == "ButtonSearch")
                    {
                        dbPara.Add("Criteria", "Count", DbType.String);
                        objFinancialRegisterPaging.Count = await Task.FromResult(dapperManager.Get<int>
                            ("FinRep_Financial_Register_PagingSP", key, dbPara, commandType: CommandType.StoredProcedure));
                        dbPara.Add("Criteria", "CreditDebit", DbType.String);
                        DebitCredit Amt = await Task.FromResult(dapperManager.Get<DebitCredit>
                            ("FinRep_Financial_Register_PagingSP", key, dbPara, commandType: CommandType.StoredProcedure));
                        objFinancialRegisterPaging.Debit = Amt.Debit;
                        objFinancialRegisterPaging.Credit = Amt.Credit;
                        if (objFinancialRegisterPaging.Count > 15000)
                        {
                            dbPara.Add("Criteria", "FinancialRegister", DbType.String);
                            objFinancialRegisterPaging.Data = await Task.FromResult(dapperManager.GetAll<dtFinancialRegister>
                                ("FinRep_Financial_Register_PagingSP", key, dbPara, commandType: CommandType.StoredProcedure));
                        }
                        else
                        {
                            objFinancialRegisterPaging.Data = await Task.FromResult(dapperManager.GetAll<dtFinancialRegister>
                                ("FinRep_Financial_RegisterSP", key, dbPara, commandType: CommandType.StoredProcedure));
                        }
                    }
                    else if (action == "PageClick")
                    {
                        dbPara.Add("Criteria", "Count", DbType.String);
                        objFinancialRegisterPaging.Count = await Task.FromResult(dapperManager.Get<int>
                            ("FinRep_Financial_Register_PagingSP", key, dbPara, commandType: CommandType.StoredProcedure));
                        dbPara.Add("Criteria", "FinancialRegister", DbType.String);
                        objFinancialRegisterPaging.Data = await Task.FromResult(dapperManager.GetAll<dtFinancialRegister>
                               ("FinRep_Financial_Register_PagingSP", key, dbPara, commandType: CommandType.StoredProcedure));
                    }
                    else if (action == "GlobalSearch")
                    {
                        dbPara.Add("@SearchValue", Search, DbType.String);
                        dbPara.Add("Criteria", "GlobalSearchCount", DbType.String);
                        objFinancialRegisterPaging.Count = await Task.FromResult(dapperManager.Get<int>
                                            ("FinRep_Financial_Register_PagingSP", key, dbPara, commandType: CommandType.StoredProcedure));
                        dbPara.Add("Criteria", "GlobalSearch", DbType.String);
                        objFinancialRegisterPaging.Data = await Task.FromResult(dapperManager.GetAll<dtFinancialRegister>
                                            ("FinRep_Financial_Register_PagingSP", key, dbPara, commandType: CommandType.StoredProcedure));
                    }
                }
                else
                {
                    if (action == "ButtonSearch")
                    {
                        dbPara.Add("Criteria", "Count_TypeWise", DbType.String);
                        objFinancialRegisterPaging.Count = await Task.FromResult(dapperManager.Get<int>
                            ("FinRep_Financial_Register_PagingSP", key, dbPara, commandType: CommandType.StoredProcedure));
                        dbPara.Add("Criteria", "CreditDebit_TypeWise", DbType.String);
                        DebitCredit Amt = await Task.FromResult(dapperManager.Get<DebitCredit>
                            ("FinRep_Financial_Register_PagingSP", key, dbPara, commandType: CommandType.StoredProcedure));
                        objFinancialRegisterPaging.Debit = Amt.Debit;
                        objFinancialRegisterPaging.Credit = Amt.Credit;
                        if (objFinancialRegisterPaging.Count > 15000)
                        {
                            dbPara.Add("Criteria", "FinancialRegister_TypeWise", DbType.String);
                            objFinancialRegisterPaging.Data = await Task.FromResult(dapperManager.GetAll<dtFinancialRegister>
                                ("FinRep_Financial_Register_PagingSP", key, dbPara, commandType: CommandType.StoredProcedure));
                        }
                        else
                        {
                            dbPara.Add("@vtypeFound",1, DbType.Int32);
                            objFinancialRegisterPaging.Data = await Task.FromResult(dapperManager.GetAll<dtFinancialRegister>
                                ("FinRep_Financial_RegisterSP", key, dbPara, commandType: CommandType.StoredProcedure));
                        }
                    }
                    else if (action == "PageClick")
                    {
                        dbPara.Add("Criteria", "FinancialRegister_TypeWise", DbType.String);
                        objFinancialRegisterPaging.Data = await Task.FromResult(dapperManager.GetAll<dtFinancialRegister>
                               ("FinRep_Financial_Register_PagingSP", key, dbPara, commandType: CommandType.StoredProcedure));
                    }
                    else if (action == "GlobalSearch")
                    {
                        dbPara.Add("@SearchValue", Search, DbType.String);
                        dbPara.Add("Criteria", "GlobalSearch_TypeWise", DbType.String);
                        objFinancialRegisterPaging.Data = await Task.FromResult(dapperManager.GetAll<dtFinancialRegister>
                                            ("FinRep_Financial_Register_PagingSP", key, dbPara, commandType: CommandType.StoredProcedure));
                    }
                }
                return objFinancialRegisterPaging;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<dtFinancialRegister>> GetDataByID(int branchId, int vId, string key)
        {
            try
            {
                var dbPara = new DynamicParameters();
                //string cmdText = "SELECT c.VID,c.ID,b.ID as AccID,a.VDate,e.Abbreviation +'-'+ a.VNo as VNo,b.AccountCode,b.AccountName,A1.AccountCode as PAccountCode,A1.AccountName as PAccountName," +
                //                 "NameInArabic,c.Description,CM.Abbreviation as Currency,c.Debit,c.Credit,a.RefNo,C.Reference,d.ChequeNo,d.ChequeDate,a.CreatedDate,a.ModifiedDate," +
                //                 "(SELECT UserName FROM Users WHERE ID=a.CreatedUserID) as CreatedUser,(SELECT UserName FROM Users WHERE ID=a.ModifiedUserID) as ModifiedUser," +
                //                 "(Select VType From VTypeTran WHERE ID=a.VType) as VType,S.ID as SID,S.AccountName as StaffName,a.Voucheragainst,a.CommonNarration,0 as Alloted" +
                //                 "FROM Voucher a INNER JOIN VoucherEntry c ON a.ID = c.VID LEFT JOIN Cheques d ON c.ID = d.VEID INNER JOIN" +
                //                 "VTypeTran e ON a.VType = e.ID INNER JOIN Accounts b ON c.AccountID = b.ID Inner Join Accounts A1 On A1.ID=b.Parent" +
                //                 "Left Outer Join Accounts S On a.StaffID=S.ID Left Outer Join School_Students St On St.AccountID=b.ID" +
                //                 "Inner Join CurrencyMast CM On CM.ID=a.Currency  WHERE a.BranchID= @BranchId";

                dbPara.Add("BranchId", branchId, DbType.Int32);
                dbPara.Add("vId", vId, DbType.Int32);
                string cmdText = "    SELECT c.VID,c.ID,b.ID as AccID,a.VDate,e.Abbreviation +'-'+ a.VNo as VNo,b.AccountCode,b.AccountName,A1.AccountCode as PAccountCode,A1.AccountName as PAccountName," +
                    "\r\n\tc.Description,CM.Abbreviation as Currency,c.Debit,c.Credit,a.RefNo,C.Reference,d.ChequeNo,d.ChequeDate,a.CreatedDate,a.ModifiedDate," +
                    "\r\n\t(SELECT UserName FROM Users WHERE ID=a.CreatedUserID) as CreatedUser,(SELECT UserName FROM Users WHERE ID=a.ModifiedUserID) as ModifiedUser," +
                    "\r\n\t(Select VType From VTypeTran WHERE ID=a.VType) as VType,S.ID as SID,S.AccountName as StaffName,a.Voucheragainst,a.CommonNarration,0 as Alloted" +
                    "\r\n\tFROM Voucher a INNER JOIN VoucherEntry c ON a.ID = c.VID LEFT JOIN Cheques d ON c.ID = d.VEID INNER JOIN " +
                    "\r\n\tVTypeTran e ON a.VType = e.ID INNER JOIN Accounts b ON c.AccountID = b.ID Inner Join Accounts A1 On A1.ID=b.Parent" +
                    " \r\n\tLeft Outer Join Accounts S On a.StaffID=S.ID" +
                    "\r\n\tInner Join CurrencyMast CM On CM.ID=a.Currency  WHERE a.BranchID= @BranchId and c.VID = @vId \r\n";

                var AcctStmt = Task.FromResult(dapperManager.GetAll<dtFinancialRegister>
                                    (cmdText, key, dbPara, commandType: CommandType.Text));
                return await AcctStmt;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public async Task<List<dtInvoiceWiseSales>> GetInvoiceWiseSales(int branchId, DateTime fDate, DateTime tDate, string? vType, string key)
        {
            try
            {
                var dbPara = new DynamicParameters();
                dbPara.Add("@BranchID", branchId, DbType.Int32);
                dbPara.Add("@DateFrom", fDate, DbType.DateTime);
                dbPara.Add("@DateUpto", tDate, DbType.DateTime);
                dbPara.Add("@BasicType", vType, DbType.String);


                var AcctStmt = Task.FromResult(dapperManager.GetAll<dtInvoiceWiseSales>
                                    ("FinRep_InvoicewiseSalesSP", key, dbPara, commandType: CommandType.StoredProcedure));
                return await AcctStmt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<dtMonthwiseSales>> GetMonthWiseSales(int branchId, string? vType, int year, string key)
        {
            try
            {
                var dbPara = new DynamicParameters();
                dbPara.Add("@BranchID", branchId, DbType.Int32);
                dbPara.Add("@Year", year, DbType.Int32);
                dbPara.Add("@BasicType", vType, DbType.String);


                var AcctStmt = Task.FromResult(dapperManager.GetAll<dtMonthwiseSales>
                                    ("FinRep_MonthwiseSalesmanwiseSP", key, dbPara, commandType: CommandType.StoredProcedure));
                return await AcctStmt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<dtSalesAnalysis>> GetSalesDateWIse(int branchId, DateTime fDate, DateTime tDate, string? vType, string key)
        {
            try
            {
                var dbPara = new DynamicParameters();
                dbPara.Add("@BranchID", branchId, DbType.Int32);
                dbPara.Add("@DateFrom", fDate, DbType.DateTime);
                dbPara.Add("@DateTo", tDate, DbType.DateTime);

                var AcctStmt = Task.FromResult(dapperManager.GetAll<dtSalesAnalysis>
                                    ("FinRep_SalesAnalysisDatewiseSP", key, dbPara, commandType: CommandType.StoredProcedure));
                return await AcctStmt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<dtTransaction>> GetTransaction(int branchId, DateTime fDate, DateTime tDate, string? vType, string key)
        {
            try
            {
                var dbPara = new DynamicParameters();
                dbPara.Add("@BranchID", branchId, DbType.Int32);
                dbPara.Add("@DateFrom", fDate, DbType.DateTime);
                dbPara.Add("@DateUpto", tDate, DbType.DateTime);
                dbPara.Add("@BasicType", vType, DbType.String);


                var AcctStmt = Task.FromResult(dapperManager.GetAll<dtTransaction>
                                    ("FinRep_InvDetailsSP", key, dbPara, commandType: CommandType.StoredProcedure));
                return await AcctStmt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<dtFinancialRegister>> GetVoucherEntry(int branchId, long vId, string key)
        {
            try
            {
                var dbPara = new DynamicParameters();
                dbPara.Add("BranchId", branchId, DbType.Int32);
                dbPara.Add("vId", vId, DbType.Int64);


                var entry = Task.FromResult(dapperManager.GetAll<dtFinancialRegister>
                                    ("select VNo,VDate,a.AccountName,a.AccountCode,Description,ve.* from voucherEntry ve inner join accounts a on a.id = ve.accountid inner join voucher v on v.id = ve.vid where vid = @vId", key, dbPara, commandType: CommandType.Text));
                return await entry;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<string>> GetVType(int branchId, string key)
        {
            try
            {
                var dbPara = new DynamicParameters();
                dbPara.Add("BranchId", branchId, DbType.Int32);

                string cmdText = "SELECT distinct (Select VType From VTypeTran WHERE ID=a.VType) as VType FROM Voucher a INNER JOIN VoucherEntry c ON a.ID = c.VID LEFT JOIN Cheques d ON c.ID = d.VEID INNER JOIN VTypeTran e ON a.VType = e.ID INNER JOIN Accounts b ON c.AccountID = b.ID Inner Join Accounts A1 On A1.ID=b.Parent Left Outer Join Accounts S On a.StaffID=S.ID Left Outer Join School_Students St On St.AccountID=b.ID Inner Join CurrencyMast CM On CM.ID=a.Currency WHERE a.BranchID= @BranchId";
                var vType = Task.FromResult(dapperManager.GetAll<string>
                                    (cmdText, key, dbPara, commandType: CommandType.Text));
                return await vType;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
