using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Server.Contract.Inventory;
using OrisonMIS.Shared.Entities.General;


namespace OrisonMIS.Server.Concrete.Inventory
{
    public class InvAccountsManager : IInvAccountsManager
    {
        private readonly IDapperManager _dapperManager;
        private readonly IConfiguration _config;
        private IInvVoucherManager _Vrepository;
        private IInvVoucherEntryManager _VErepository;
        private IInvTransactionsManager _trepository;
        private IInvVoucherAdditionalsManager _VArepository;
        public InvAccountsManager(IDapperManager dapperManager, IConfiguration config, IInvVoucherManager vrepository, IInvVoucherEntryManager VErepository, IInvTransactionsManager trepository, IInvVoucherAdditionalsManager VArepository)
        {
            _dapperManager = dapperManager;
            _config = config;
            _Vrepository = vrepository;
            _VErepository = VErepository;
            _trepository = trepository;
            _VArepository = VArepository;
        }
        public void SetRemarks(int id, [FromBody] string Remarks, string key)
        {
            var reuslt = Task.FromResult(_dapperManager.Get<string>($"select Remarks from follow_up where AccountID='{id}'", key,null, commandType: CommandType.Text));
            if (reuslt.Result != null)
            {
                Task.FromResult(_dapperManager.Update<int>($"update follow_up set Remarks='{Remarks}',Date='{DateTime.Today}' where AccountID='{id}'",key, null, commandType: CommandType.Text));
            }
            else
            {
                Task.FromResult(_dapperManager.Insert<int>("insert into follow_up " +
                "(AccountID,Remarks,Date) values " +
                $"('{id}','{Remarks}','{DateTime.Today}')", key,null, commandType: CommandType.Text));
            }
        }
        public async Task<bool> SaveAdd(dtInvAccounts Acc, string key)
        {
            //long newID;
            using IDbConnection db = new SqlConnection(_config.GetConnectionString(key));
            try
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                var Result1 = Task.FromResult(saveAccounts(ref Acc,key));
                var Result2 = Task.FromResult(savePersonal(ref Acc,key));
                if (Result1.IsCompleted == true && Result2.IsCompleted == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (db.State == ConnectionState.Open)
                    db.Close();
            }
        }
        public Task<List<string>> GetCompanyName(string key)
        {
            var CompanyName = Task.FromResult(_dapperManager.GetAll<string>("select CompanyName from Company", key,null, commandType: CommandType.Text));
            return CompanyName;
        }
        public Task<List<string>> GetCurrency(string key)
        {
            var Currency = Task.FromResult(_dapperManager.GetAll<string>("select abbreviation from CurrencyMast", key,null, commandType: CommandType.Text));
            return Currency;
        }
        public async Task<List<dtInvAccounts>> GetCustomers(string key)
        {
            var Customers = Task.FromResult(_dapperManager.GetAll<dtInvAccounts>("select Acc.ID as ID,CreatedDate,AccountName,Emirates,Category,ContactPerson,DesignationID,Mobile,Phone1,Pdt.Fax as Fax,Pdt.email as email,Pdt.Website as Website,Pdt.Remarks as Remarks,Price,Department,C.CompanyName as CompanyName " +
                "from Accounts as Acc  inner join PersonnelDetailsTran as Pdt  on Acc.ID = Pdt.AccountID " +
                "left join Company as C on C.ID = Acc.BranchID where Acc.AccCategory=2" +
                "order by Acc.ID asc", key, null, commandType: CommandType.Text));
            return await Customers;

        }
        public bool saveAccounts(ref dtInvAccounts Acc,string key)
        {
            if (Acc.AccCategory.ToString() == "Customer")
            {
                int Plevel = Convert.ToInt32(Task.FromResult(_dapperManager.Get<int>("Select ParentLevel from Accounts where AccountName='ACCOUNTS RECEIVABLES'", key,null,
                  commandType: CommandType.Text)).Result);
                int Parent = Convert.ToInt32(Task.FromResult(_dapperManager.Get<int>("Select parent from Accounts where AccountName='ACCOUNTS RECEIVABLES'", key,null,
                      commandType: CommandType.Text)).Result);
                string FinalAccount;
                if (Task.FromResult(_dapperManager.Get<string>("Select distinct FinalAccount from Accounts where Parent='" + Parent + "'", key,null, commandType: CommandType.Text)) == null)
                    FinalAccount = "0";
                else
                    FinalAccount = Task.FromResult(_dapperManager.Get<string>("Select distinct FinalAccount from Accounts where Parent='" + Parent + "'", key,null, commandType: CommandType.Text)).Result.ToString();
                string AccountGroup;
                if (Task.FromResult(_dapperManager.Get<string>("Select distinct AccountGroup from Accounts where Parent='" + Parent + "'", key,null, commandType: CommandType.Text)) == null)
                    AccountGroup = "0";
                else
                    AccountGroup = Task.FromResult(_dapperManager.Get<string>("Select distinct AccountGroup from Accounts where Parent='" + Parent + "'", key, null, commandType: CommandType.Text)).Result.ToString();
                int SubGroup;
                if (Task.FromResult(_dapperManager.Get<int>("Select distinct SubGroup from Accounts where Parent='" + Parent + "'", key,null, commandType: CommandType.Text)) == null)
                    SubGroup = 0;
                else
                    SubGroup = Convert.ToInt32(Task.FromResult(_dapperManager.Get<int>("Select distinct SubGroup from Accounts where ID=32", key,null, commandType: CommandType.Text)).Result);
                string ShowChild;
                if (Task.FromResult(_dapperManager.Get<string>("Select distinct ShowChild from Accounts where Parent='" + Parent + "'", key,null, commandType: CommandType.Text)) == null)
                    ShowChild = "0";
                else
                    ShowChild = Task.FromResult(_dapperManager.Get<string>("Select distinct ShowChild from Accounts where Parent='" + Parent + "'", key,null, commandType: CommandType.Text)).Result.ToString();
                // int curr = Convert.ToInt32(Task.FromResult(_dapperManager.Get<int>("select id from CurrencyMast where abbreviation=" + Acc.Currency, null, commandType: CommandType.Text)).Result);
                string AccountCode = GetNextNumFn(Acc.AccCategory, key);
                string Cmd = "INSERT INTO Accounts ([AccountCode],[AccountName], [Parent], [ParentLevel], [VoucherEntry],[FinalAccount], [AccountGroup],[SubGroup],[AccCategory],[ShowChild],[ISDefault],[AllowEntry],[Currency],[InActive],[Editable],[UserTrackID],[CreatedDate],[ModifiedDate],[CreatedUser],[ModifiedUser],[BranchID])" +
                             " VALUES (@AccountCode,@AccountName,@Parent, @ParentLevel, @VoucherEntry,@FinalAccount, @AccountGroup,@SubGroup,@AccCategory,@ShowChild,@ISDefault,@AllowEntry,@Currency,@InActive,@Editable,@UserTrackID,@CreatedDate,@ModifiedDate,@CreatedUser,@ModifiedUser,@BranchID); ";
                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                dictionary.Add("@AccountCode", AccountCode);
                dictionary.Add("@AccountName", Acc.AccountName);
                dictionary.Add("@Parent", Convert.ToInt32(Task.FromResult(_dapperManager.Get<string>("Select ID from Accounts where AccountName='ACCOUNTS RECEIVABLES'",key, null, commandType: CommandType.Text)).Result));
                dictionary.Add("@ParentLevel", Plevel + 1);
                dictionary.Add("@VoucherEntry", true);
                dictionary.Add("@FinalAccount", FinalAccount);
                dictionary.Add("@AccountGroup", AccountGroup);
                dictionary.Add("@SubGroup", SubGroup);
                dictionary.Add("@AccCategory", 2);
                dictionary.Add("@ShowChild", ShowChild);
                dictionary.Add("@ISDefault", AccountGroup);
                dictionary.Add("@AllowEntry", AccountGroup);
                if (Acc.Currency != null)
                    dictionary.Add("@Currency", Convert.ToInt32(Task.FromResult(_dapperManager.Get<string>("Select ID from CurrencyMast where abbreviation like " + Acc.Currency, key,null, commandType: CommandType.Text)).Result));
                else
                    dictionary.Add("@Currency", DBNull.Value);
                dictionary.Add("@InActive", Acc.Inactive);
                dictionary.Add("@Editable", AccountGroup);
                dictionary.Add("@UserTrackID", "");
                dictionary.Add("@CreatedDate", Acc.CreatedDate);
                dictionary.Add("@ModifiedDate", DateTime.Today);
                dictionary.Add("@CreatedUser", Acc.CreatedUser);
                dictionary.Add("@ModifiedUser", "");
                dictionary.Add("@BranchID", Convert.ToInt32(Task.FromResult(_dapperManager.Get<int>($"select ID from Company where CompanyName='{Acc.CompanyName}'",key, null, commandType: CommandType.Text)).Result));
                var Result = Task.FromResult(_dapperManager.Insert<int>(Cmd,key, new DynamicParameters(dictionary), commandType: CommandType.Text));
                var ACode = AccountCode;
                if (Result.IsCompleted)
                {
                    Acc.ID = Convert.ToInt32(Task.FromResult(_dapperManager.Get<int>($"SELECT ID FROM Accounts WHERE AccountCode='{ACode}'", key,null,
                        commandType: CommandType.Text)).Result);
                }
            }
            else if (Acc.AccCategory.ToString() == "Supplier")
            {
                if (Acc.Action.ToString() == "New")
                {
                    int Plevel = Convert.ToInt32(Task.FromResult(_dapperManager.Get<int>("Select ParentLevel from Accounts where AccountName='OTH'", key,null, //Accounts Payable
                  commandType: CommandType.Text)).Result);
                    int Parent = Convert.ToInt32(Task.FromResult(_dapperManager.Get<int>("Select parent from Accounts where AccountName='OTH'", key,null,
                          commandType: CommandType.Text)).Result);
                    string FinalAccount;
                    if (Task.FromResult(_dapperManager.Get<string>("Select distinct FinalAccount from Accounts where Parent='" + Parent + "'", key,null, commandType: CommandType.Text)) == null)
                        FinalAccount = "0";
                    else
                        FinalAccount = Task.FromResult(_dapperManager.Get<string>("Select distinct FinalAccount from Accounts where Parent='" + Parent + "'", key,null, commandType: CommandType.Text)).Result.ToString();
                    string AccountGroup;
                    if (Task.FromResult(_dapperManager.Get<string>("Select distinct AccountGroup from Accounts where Parent='" + Parent + "'", key,null, commandType: CommandType.Text)) == null)
                        AccountGroup = "0";
                    else
                        AccountGroup = Task.FromResult(_dapperManager.Get<string>("Select distinct AccountGroup from Accounts where Parent='" + Parent + "'", key,null, commandType: CommandType.Text)).Result.ToString();
                    int SubGroup;
                    if (Task.FromResult(_dapperManager.Get<int>("Select distinct SubGroup from Accounts where Parent='" + Parent + "'", key,null, commandType: CommandType.Text)) == null)
                        SubGroup = 0;
                    else
                        SubGroup = Convert.ToInt32(Task.FromResult(_dapperManager.Get<int>("Select distinct SubGroup from Accounts where AccountName='OTH'", key,null, commandType: CommandType.Text)).Result);
                    string ShowChild;
                    if (Task.FromResult(_dapperManager.Get<string>("Select distinct ShowChild from Accounts where Parent='" + Parent + "' and ShowChild is not null", key,null, commandType: CommandType.Text)) == null)
                        ShowChild = "0";
                    else
                        ShowChild = Task.FromResult(_dapperManager.Get<string>("Select distinct ShowChild from Accounts where Parent='" + Parent + "' and ShowChild is not null", key,null, commandType: CommandType.Text)).Result.ToString();
                    if (Acc.AccountCode == null)
                        Acc.AccountCode = GetNextNumFn(Acc.AccCategory,key);

                    string Cmd = "INSERT INTO Accounts ([AccountCode],[AccountName], [Parent], [ParentLevel], [VoucherEntry],[FinalAccount], [AccountGroup],[SubGroup],[AccCategory],[ShowChild],[ISDefault],[AllowEntry],[Currency],[BranchID],[InActive],[Editable],[UserTrackID],[CreatedDate],[ModifiedDate],[CreatedUser],[ModifiedUser])" +
                                 " VALUES (@AccountCode,@AccountName,@Parent, @ParentLevel, @VoucherEntry,@FinalAccount, @AccountGroup,@SubGroup,@AccCategory,@ShowChild,@ISDefault,@AllowEntry,@Currency,@BranchID,@InActive,@Editable,@UserTrackID,@CreatedDate,@ModifiedDate,@CreatedUser,@ModifiedUser); ";
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    dictionary.Add("@AccountCode", Acc.AccountCode);
                    dictionary.Add("@AccountName", Acc.AccountName);
                    dictionary.Add("@Parent", Convert.ToInt32(Task.FromResult(_dapperManager.Get<string>("Select ID from Accounts where AccountName='OTH'",key, null, commandType: CommandType.Text)).Result));
                    dictionary.Add("@ParentLevel", Plevel + 1);
                    dictionary.Add("@VoucherEntry", true);
                    dictionary.Add("@FinalAccount", FinalAccount);
                    dictionary.Add("@AccountGroup", AccountGroup);
                    dictionary.Add("@SubGroup", SubGroup);
                    dictionary.Add("@AccCategory", Convert.ToInt32(Task.FromResult(_dapperManager.Get<string>("Select id from AccountCategoryMast where Description like '%" + Acc.AccCategory + "%'", key,null, commandType: CommandType.Text)).Result));
                    dictionary.Add("@ShowChild", ShowChild);
                    dictionary.Add("@ISDefault", AccountGroup);
                    dictionary.Add("@AllowEntry", AccountGroup);
                    if (Acc.Currency != null)
                        dictionary.Add("@Currency", Convert.ToInt32(Task.FromResult(_dapperManager.Get<int>("select id from CurrencyMast where abbreviation like '%" + Acc.Currency + "%'", key,null, commandType: CommandType.Text)).Result));
                    else
                        dictionary.Add("@Currency", DBNull.Value);
                    dictionary.Add("@BranchID", Acc.BranchID);
                    dictionary.Add("@InActive", Acc.Inactive);
                    dictionary.Add("@Editable", AccountGroup);
                    dictionary.Add("@UserTrackID", "");
                    dictionary.Add("@CreatedDate", Acc.CreatedDate);
                    dictionary.Add("@ModifiedDate", DateTime.Today);
                    dictionary.Add("@CreatedUser", Acc.CreatedUser);
                    dictionary.Add("@ModifiedUser", "");
                    var Result = Task.FromResult(_dapperManager.Insert<int>(Cmd,key, new DynamicParameters(dictionary), commandType: CommandType.Text));
                    var ACode = Acc.AccountCode;
                    if (Result.IsCompleted)
                    {
                        Acc.ID = Convert.ToInt32(Task.FromResult(_dapperManager.Get<int>($"SELECT ID FROM Accounts WHERE AccountCode='{ACode}'", key,null,
                            commandType: CommandType.Text)).Result);
                    }
                }
                else if (Acc.Action.ToString() == "Update")
                {
                    int curr = Convert.ToInt32(Task.FromResult(_dapperManager.Get<int>("select id from CurrencyMast where abbreviation like '%" + Acc.Currency + "%'", key,null, commandType: CommandType.Text)).Result);
                    string Cmd = "Update Accounts set [AccountCode]=@AccountCode,[AccountName]=@AccountName, " +
                        " [Currency]=@Currency,[BranchID]=@BranchID,[InActive]=@InActive,[ModifiedDate]=@ModifiedDate,[ModifiedUser]=@ModifiedUser where ID=@ID";
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    dictionary.Add("@ID", Acc.ID);
                    dictionary.Add("@AccountCode", Acc.AccountCode);
                    dictionary.Add("@AccountName", Acc.AccountName);
                    dictionary.Add("@Currency", curr);
                    dictionary.Add("@BranchID", Acc.BranchID);
                    dictionary.Add("@InActive", Acc.Inactive);
                    dictionary.Add("@ModifiedDate", DateTime.Today);
                    dictionary.Add("@ModifiedUser", Acc.ModifiedUser);
                    var Result = Task.FromResult(_dapperManager.Update<int>(Cmd,key, new DynamicParameters(dictionary), commandType: CommandType.Text));
                    if (Result.IsCompleted)
                    {

                    }
                }

            }


            return true;

        }

        public bool savePersonal(ref dtInvAccounts Acc, string key)
        {
            int EID, c;
            if (int.TryParse(Acc.Emirates, out c))
            {
                EID = c;
            }
            else
            {
                EID = Convert.ToInt32(Task.FromResult(_dapperManager.Get<int>($"SELECT ID FROM EmiratesMast WHERE  description ='" + Acc.Emirates + "'", key,null,
                        commandType: CommandType.Text)).Result);
            }
            string Cmd = "";
            if (Acc.Action.ToString() == "New")
            {
                Cmd = "INSERT INTO [dbo].[PersonnelDetailsTran] ([AccountID],[Phone1],[Address1],[Fax],[Mobile],[Email],[Website],[ContactPerson],[Emirates],[Category],[Country],[DesignationID],[Remarks],[Department],[VATPlace],[TRNNo],[AllowCredit],[CreditDays],[CreditLimit],[Price])" +
                          " VALUES (@AccountID,@Phone1,@Address1,@Fax,@Mobile,@Email,@Website,@ContactPerson,@Emirates,@Category,@Country,@DesignationID,@Remarks,@Department,@VATPlace,@TRNNo,@AllowCredit,@CreditDays,@CreditLimit,@Price); ";
                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                dictionary.Add("@AccountID", Acc.ID);
                dictionary.Add("@Phone1", Acc.Phone1);
                dictionary.Add("@Address1", Acc.Address1);
                dictionary.Add("@Fax", Acc.Fax);
                dictionary.Add("@Mobile", Acc.Mobile);
                dictionary.Add("@Email", Acc.Email);
                dictionary.Add("@Website", Acc.Website);
                dictionary.Add("@ContactPerson", Acc.ContactPerson);
                dictionary.Add("@Emirates", EID);
                dictionary.Add("@Category", Acc.Category);
                dictionary.Add("@Country", Acc.Country);
                dictionary.Add("@DesignationID", Acc.DesignationID);
                dictionary.Add("@Remarks", Acc.Remarks);
                dictionary.Add("@Department", Acc.Department);
                dictionary.Add("@VATPlace", Acc.VATPlace);
                dictionary.Add("@TRNNo", Acc.TRNNo);
                dictionary.Add("@AllowCredit", Acc.AllowCredit);
                dictionary.Add("@CreditDays", Acc.CreditDays);
                dictionary.Add("@CreditLimit", Acc.CreditLimit);
                dictionary.Add("@Price", Acc.Price);
                var Result = Task.FromResult(_dapperManager.Insert<int>(Cmd,key, new DynamicParameters(dictionary), commandType: CommandType.Text));
            }
            else if (Acc.Action.ToString() == "Update")
            {
                Cmd = "Update  [dbo].[PersonnelDetailsTran] set [Phone1]=@Phone1,[Address1]=@Address1,[Fax]=@Fax,[Mobile]=@Mobile,[Email]=@Email,[Website]=@Website,[ContactPerson]=@ContactPerson,[Emirates]=@Emirates,[Category]=@Category," +
                    "[Country]=@Country,[DesignationID]=@DesignationID,[Remarks]=@Remarks,[Department]=@Department,[VATPlace]=@VATPlace,[TRNNo]=@TRNNo,[AllowCredit]=@AllowCredit,[CreditDays]=@CreditDays,[CreditLimit]=@CreditLimit" +
                        " where AccountID=@AccountID ";
                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                dictionary.Add("@AccountID", Acc.ID);
                dictionary.Add("@Phone1", Acc.Phone1);
                dictionary.Add("@Address1", Acc.Address1);
                dictionary.Add("@Fax", Acc.Fax);
                dictionary.Add("@Mobile", Acc.Mobile);
                dictionary.Add("@Email", Acc.Email);
                dictionary.Add("@Website", Acc.Website);
                dictionary.Add("@ContactPerson", Acc.ContactPerson);
                dictionary.Add("@Emirates", EID);
                dictionary.Add("@Category", Acc.Category);
                dictionary.Add("@Country", Acc.Country);
                dictionary.Add("@DesignationID", Acc.DesignationID);
                dictionary.Add("@Remarks", Acc.Remarks);
                dictionary.Add("@Department", Acc.Department);
                dictionary.Add("@VATPlace", Acc.VATPlace);
                dictionary.Add("@TRNNo", Acc.TRNNo);
                dictionary.Add("@AllowCredit", Acc.AllowCredit);
                dictionary.Add("@CreditDays", Acc.CreditDays);
                dictionary.Add("@CreditLimit", Acc.CreditLimit);
                var Result = Task.FromResult(_dapperManager.Update<int>(Cmd,key, new DynamicParameters(dictionary), commandType: CommandType.Text));
            }


            return true;
        }

        public Task<string> GetAccountCode(string Category, string key)
        {
            return Task.Run(() =>
            {
                var v = GetNextNumFn(Category,key);
                return v;
            });
        }

        public string GetNextNumFn(string Category,string key)
        {
            string cat = "%" + Category + "%";
            string AccStr = "";
            string AccStr1 = "";
            int AccNum = 0;
            object AccCode = null;
            var dt = Task.FromResult(_dapperManager.GetAll<string>("SELECT TOP 1 AccountCode FROM Accounts WHERE AccountCode LIKE '" + AccStr + "%' AND AccCategory=(Select distinct id from AccountCategoryMast where Description like '" + cat + "' ) ORDER BY AccountCode DESC", key,null,
                commandType: CommandType.Text));
            string Code = Convert.ToString(dt.Result[0].ToString());
            int b;
            if (int.TryParse(Code, out b))
            {
                AccStr = "";
                AccCode = Task.FromResult(_dapperManager.Get<string>("SELECT TOP 1 AccountCode FROM Accounts WHERE AccountCode LIKE '" + AccStr + "%' AND AccCategory=(Select distinct id from AccountCategoryMast where Description like '" + cat + "' ) ORDER BY AccountCode DESC",key, null,
                     commandType: CommandType.Text)).Result[0].ToString();
                AccNum = int.Parse(AccCode.ToString()) + 1;
                AccStr1 = AccNum.ToString().PadLeft(AccCode.ToString().Length, '0');
            }
            else
            {
                int len = Code.Length;
                for (int i = 0; i < len - 1; i++)
                {
                    int c;
                    if (int.TryParse(Code.Substring(i + 1), out c))
                    {
                        AccStr = Code.Substring(0, i + 1);
                        var dt1 = Task.FromResult(_dapperManager.GetAll<string>("SELECT TOP 1 AccountCode FROM Accounts WHERE AccountCode LIKE '" + AccStr + "%' AND AccCategory=(Select distinct id from AccountCategoryMast where Description like '" + cat + "') ORDER BY ID DESC",key, null,
                              commandType: CommandType.Text));
                        AccCode = dt1.Result[0].ToString();
                        Code = AccCode.ToString();
                        len = Code.Length;
                        for (int j = 0; j < len - 1; j++)
                        {
                            int k;
                            if (int.TryParse(Code.Substring(j + 1), out k))
                            {
                                AccNum = int.Parse(Code.Substring(j + 1)) + 1;
                                string no = AccNum.ToString();
                                AccStr1 = no.ToString().PadLeft(Code.Substring(j + 1).Length, '0');
                                break;
                            }
                        }
                        break;
                    }
                }
            }
            return AccStr + AccStr1;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
