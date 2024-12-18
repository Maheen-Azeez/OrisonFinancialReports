using Dapper;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Server.Contract.Inventory.Reports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Server.Concrete.Inventory.Reports
{
    public class ReportsManager : IReportsManager
    {
        private readonly IDapperManager _dapperManager;
        public ReportsManager(IDapperManager dapperManager)
        {
            _dapperManager = dapperManager;
        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
        public async Task<List<object>> DailyReport(int userid, DateTime FDate, DateTime TDate, string key)
        {
            var dbPara = new DynamicParameters();

            dbPara.Add("BranchId", 31, DbType.Int32);
            dbPara.Add("userId", userid, DbType.Int32);
            dbPara.Add("DateFrom", FDate, DbType.DateTime);
            dbPara.Add("DateUpTo", TDate, DbType.DateTime);
            var vouchermaster = Task.FromResult(_dapperManager.GetAll<object>
                                ("[FinWeb_UserDailyReportSP]", key,dbPara,
                                commandType: CommandType.StoredProcedure));
            //($"SELECT * FROM [Article] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return await vouchermaster;
        }

        public async Task<List<object>> DailyReportDetailed(int userid, DateTime FDate, DateTime TDate, string Crt, string key)
        {
            var dbPara = new DynamicParameters();

            dbPara.Add("BranchId", 31, DbType.Int32);
            dbPara.Add("userId", userid, DbType.Int32);
            dbPara.Add("DateFrom", FDate, DbType.DateTime);
            dbPara.Add("DateUpTo", TDate, DbType.DateTime);
            dbPara.Add("Criteria", Crt, DbType.String);
            var vouchermaster = Task.FromResult(_dapperManager.GetAll<object>
                                ("[FinWeb_UserDailyReportSP]",key, dbPara,
                                commandType: CommandType.StoredProcedure));
            //($"SELECT * FROM [Article] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return await vouchermaster;
        }

    }
}
