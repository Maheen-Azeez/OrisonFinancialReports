using Dapper;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Server.Concrete.General
{
    public class InvAccounts : IInvAccounts
    {
        private readonly IDapperManager _dapperManager;

        public InvAccounts(IDapperManager dapperManager)
        {
            _dapperManager = dapperManager;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
        public Task<List<dtInvAccounts>> GetAllAccounts(string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Criteria", "AllAccounts", DbType.String);
            //dtInvVoucher voucher = new dtInvVoucher();            
            var Accounts = Task.FromResult(_dapperManager.GetAll<dtInvAccounts>
                                ("[FinRep_InventoryVoucherSP]", key, dbPara,
                                commandType: CommandType.StoredProcedure));
            //($"SELECT * FROM [Article] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return Accounts;
        }
        public Task<List<dtInvAccounts>> GetAccounts(string AccCategory, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("AccCategory", AccCategory, DbType.String);
            dbPara.Add("Criteria", "AccountMaster", DbType.String);
            //dtInvVoucher voucher = new dtInvVoucher();
            var Accounts = Task.FromResult(_dapperManager.GetAll<dtInvAccounts>
                                ("[FinRep_InventoryVoucherSP]", key, dbPara,
                                commandType: CommandType.StoredProcedure));
            //($"SELECT * FROM [Article] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return Accounts;
        }

        public async Task<List<dtInvAccounts>> GetAccountsByDesignation(string AccCategory, string Designation, string BranchID, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("AccCategory", AccCategory, DbType.String);
            dbPara.Add("Designation", Designation, DbType.String);
            dbPara.Add("BranchId", BranchID, DbType.String);
            dbPara.Add("Criteria", "AccountMasterByDesignation", DbType.String);
            //dtInvVoucher voucher = new dtInvVoucher();
            var Accounts = Task.FromResult(_dapperManager.GetAll<dtInvAccounts>
                                ("[FinRep_InventoryVoucherSP]", key, dbPara,
                                commandType: CommandType.StoredProcedure));
            //($"SELECT * FROM [Article] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return await Accounts;
        }
        public async Task<List<dtInvAccounts>> GetAccountsbyID(int id, string AccCategory, string key)
        {
            if (id == 0)
                id = Convert.ToInt32(Task.FromResult(_dapperManager.Get<int>("SELECT top 1 id FROM Accounts WHERE AccCategory=(Select distinct id from AccountCategoryMast where Description like '%" + AccCategory + "%') ORDER BY ID DESC",key, null,
                      commandType: CommandType.Text)).Result);
            var dbPara = new DynamicParameters();
            dbPara.Add("AccCategory", AccCategory, DbType.String);
            dbPara.Add("ID", id, DbType.Int32);
            dbPara.Add("Criteria", "AccountMasterbyID", DbType.String);
            //dtInvVoucher voucher = new dtInvVoucher();
            var Accounts = Task.FromResult(_dapperManager.GetAll<dtInvAccounts>
                                ("[FinRep_InventoryVoucherSP]", key, dbPara,
                                commandType: CommandType.StoredProcedure));
            //($"SELECT * FROM [Article] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return await Accounts;
        }

        public async Task<List<ParentLevel>> GetLevel(string key)
        {
            try
            {
                var levels = await Task.FromResult(_dapperManager.GetAll<ParentLevel>
                                       ("select distinct parentlevel as Level from accounts order by parentlevel", key, null,
                                       commandType: CommandType.Text));
                return levels;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
