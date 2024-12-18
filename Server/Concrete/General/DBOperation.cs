using Dapper;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.General;
using System.Data;

namespace OrisonMIS.Server.Concrete.General
{
    public class DBOperation : IDBOperation
    {
        private readonly IConfiguration _config;
        private readonly IDapperManager _dapperManager;
        public DBOperation(IConfiguration config, IDapperManager dapperManager)
        {
            _config = config;
            _dapperManager = dapperManager;
        }
        public string PasswordDecode(string Password, string key)
        {
            throw new NotImplementedException();
        }

        public string PasswordEncode(string Pwd, string key)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetVtype(string vtype, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("@Vtype", vtype, DbType.String);
            var Vouchertype = Task.FromResult(_dapperManager.Get<int>($"SELECT ID FROM VTypeTran WHERE VType=@Vtype",key, dbPara, commandType: CommandType.Text));
            return Vouchertype;
            //($"SELECT * FROM [Article] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));

            // return (int)idbopn.GetScalar("SELECT ID FROM VTypeTran WHERE VType='Sales POS'");
        }

        public Task<int> GetApprovalID(int k, string vtype, int user, string key)
        {
            var dbPara = new DynamicParameters();
            var AID = Task.FromResult(_dapperManager.Get<int>($"select ApproverID from ESSApproverSettings s inner join ESSApproverTran t on s.ID=t.ASID where s.Type='" + vtype + "Approver' and s.ApproverLevel=" + k + " and t.EmpID=(select AccountID from portalusers where id=" + user + ")",key, dbPara, commandType: CommandType.Text));
            return AID;
        }

        public Task<int> GetBranchID(int vid, string key)
        {
            var dbPara = new DynamicParameters();
            var AID = Task.FromResult(_dapperManager.Get<int>($"select branchID from voucher where id=" + vid, key, dbPara, commandType: CommandType.Text));
            return AID;
        }
        public async Task<VtypeTrans> GetVtypeTran(int ID, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("@ID", ID, DbType.String);
            var VtypeTran = Task.FromResult(_dapperManager.Get<VtypeTrans>($"SELECT * FROM VTypeTran WHERE ID=@ID",key, dbPara, commandType: CommandType.Text));
            //return ((Task<VtypeTran>)VtypeTran);
            return await VtypeTran;
        }

        public async Task<WarehouseMaster> GetWarehouse(int ID, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("@ID", ID, DbType.String);
            var Warehouse = Task.FromResult(_dapperManager.Get<WarehouseMaster>($"select W.ID,WHCode From WarehouseMaster W Inner join Users On Users.Section=W.WHCode where Users.ID=@ID", key, dbPara, commandType: CommandType.Text));
            return await Warehouse;
        }

        public async Task<List<string>> GetMasterMisc(string Source, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("@Source", Source, DbType.String);
            var Misc = Task.FromResult(_dapperManager.GetAll<string>($"select Description from MasterMisc where source=@source",key, dbPara, commandType: CommandType.Text));
            return await Misc;
        }
        public async Task<List<WarehouseMaster>> GetWarehouse(string key)
        {
            var dbPara = new DynamicParameters();
            var Warehouse = Task.FromResult(_dapperManager.GetAll<WarehouseMaster>($"select ID,WHCode From WarehouseMaster ",key, dbPara, commandType: CommandType.Text));
            return await Warehouse;
        }
        public async Task<List<BranchMaster>> GetSchoolBranch(string key)
        {
            var dbPara = new DynamicParameters();
            var Warehouse = Task.FromResult(_dapperManager.GetAll<BranchMaster>($"select ID,CompanyCode as Code,BranchName as Name from Company",key, dbPara, commandType: CommandType.Text));
            return await Warehouse;
        }
        public async Task<List<BranchMaster>> GetUserBranch(int userid, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("@id", userid, DbType.Int64);
            var Warehouse = Task.FromResult(_dapperManager.GetAll<BranchMaster>($"select BranchID,CompanyName as Branch from PortalUserBranch pb join Company c on c.id=pb.BranchID where pb.userid=@id",key, dbPara, commandType: CommandType.Text));
            return await Warehouse;
        }

        public async Task<Salesman> GetSalesman(int ID, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("@ID", ID, DbType.String);
            var Salesman = Task.FromResult(_dapperManager.Get<Salesman>($"select AccountID,AccountName from Accounts Inner join Users On Users.AccountID=Accounts.ID where Users.ID=@ID", key, dbPara, commandType: CommandType.Text));
            return await Salesman;
        }

        public async Task<List<FormLabel>> GetFormLabels(string FormName, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("@FormName", FormName, DbType.String);
            dbPara.Add("@Criteria", "FormLabelMaster", DbType.String);
            var FormLabelMast = Task.FromResult(_dapperManager.GetAll<FormLabel>("[FinRep_InventoryVoucherSP]", key, dbPara, commandType: CommandType.StoredProcedure));
            return await FormLabelMast;
        }

        public Task<int> GetNextNo(int vtype, int _BranchId, string key)
        {
            //DateTime dt = DateTime.Parse(d);
            var dbPara = new DynamicParameters();
            dbPara.Add("@Vtype", vtype, DbType.Int32);
            //dbPara.Add("@date", dt, DbType.DateTime);
            dbPara.Add("@BranchId", _BranchId, DbType.Int32);
            var Vouchertype = Task.FromResult(_dapperManager.Get<int>("Select cast([dbo].NextNumber(@vtype,@BranchId,NULL,NULL) as int)",key, dbPara, commandType: CommandType.Text));
            return Vouchertype;
        }

        public Task<object> GetScalar(string CommandText, string key)
        {
            object obj = Task.FromResult(_dapperManager.Get<object>(CommandText, key,null, commandType: CommandType.Text));
            return (Task<object>)obj;
        }
        public Task<List<string>> GetList(string CommandText, string key)
        {
            return Task.FromResult(_dapperManager.GetAll<string>(CommandText, key,null, commandType: CommandType.Text));
        }
        public object GetScalarValue(string CommandText, string key)
        {
            object obj = Task.FromResult(_dapperManager.Get<object>(CommandText,key, null, commandType: CommandType.Text));
            return obj;
        }
        public string IsSchool(string key)
        {
            var obj = GetScalar("select value from Settings where Category like '%isschool%'",key);
            string var = obj.Result.ToString();
            return var.Split("=")[1].Replace("'", " ").Replace("}", " ").Trim();
        }
        public Task<string> GetBalance(long AccId, int _BranchId, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("@AccountID", AccId, DbType.Int32);
            dbPara.Add("@BranchId", _BranchId, DbType.Int32);
            var Balance = Task.FromResult(_dapperManager.Get<string>("Select cast([dbo].[GetBalance](@AccountID,NULL,@BranchId) as varchar(100))",key, dbPara, commandType: CommandType.Text));
            return Balance;
        }
        public Task<List<Budget>> GetBudget(long AccId, string Fiancialyear, int _BranchId, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("@AccountID", AccId, DbType.Int32);
            dbPara.Add("@Fiancialyear", Fiancialyear, DbType.String);
            dbPara.Add("@BranchId", _BranchId, DbType.Int32);
            var Budget = Task.FromResult(_dapperManager.GetAll<Budget>
                               ("[FINWEB_BudgetSP]", key,dbPara,
                               commandType: CommandType.StoredProcedure));
            return Budget;
        }
        public async Task<List<string>> GetFinYear(string key)
        {
            var dbPara = new DynamicParameters();
            var yr = Task.FromResult(_dapperManager.GetAll<string>($"select distinct AcademicYear from Portal_AcademicYear",key, dbPara, commandType: CommandType.Text));
            return await yr;
        }

        public Task<string> getHomeUrl(int AccountID, string key)
        {
            var code = Task.FromResult(_dapperManager.Get<string>("select top 1 Description from MasterMisc where Source='Home'", key,null, commandType: CommandType.Text));
            return code;
        }

        public Task<string> getLogoutUrl(int AccountID, string key)
        {
            var code = Task.FromResult(_dapperManager.Get<string>("select top 1 Description from MasterMisc where Source='Logout'", key,null, commandType: CommandType.Text));
            return code;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
