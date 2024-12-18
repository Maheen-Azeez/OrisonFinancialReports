using Dapper;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.General;
using System.Data;

namespace OrisonMIS.Server.Concrete.General
{
    public class DateTimeRepository : IDateTimeRepository
    {
        private readonly IDapperManager dapperManager;

        public DateTimeRepository(IDapperManager dapperManager)
        {
            this.dapperManager = dapperManager;
        }
        public async Task<DateTime> GetEntryFromDateTimeAsync(int branchId,string key)
        {
            try
            {
                var dbPara = new DynamicParameters();
                dbPara.Add("@BranchID", branchId, DbType.Int32);
                var entryFrom = Task.FromResult(dapperManager.Get<DateTime>
                                    ("Select Entryfrom from company where id = @BranchID", key, dbPara, commandType: CommandType.Text));
                return await entryFrom;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<FinancialDateTime> GetFinancialDateTimeAsync(int branchId, string key)
        {
            try
            {
                var dbPara = new DynamicParameters();
                dbPara.Add("@BranchID", branchId, DbType.Int32);
                FinancialDateTime financialDateTime = await Task.FromResult(dapperManager.Get<FinancialDateTime>
                                    ("SELECT entryfrom AS startDate,DATEADD(YEAR, 1, DATEADD(DAY, -1, entryfrom)) AS endDate FROM company where id = @BranchID", key, dbPara, commandType: CommandType.Text));
                financialDateTime.EndDate = financialDateTime.EndDate < DateTime.Now ? DateTime.Now : financialDateTime.EndDate;
                return financialDateTime;
            }
            catch (Exception)
            {

                throw;
            }
        } 
        public async Task<DateTime> GetVatDateTimeAsync(int branchId, string key)
        {
            try
            {
                var dbPara = new DynamicParameters();
                dbPara.Add("@BranchID", branchId, DbType.Int32);
                var DateTime = Task.FromResult(dapperManager.Get<DateTime?>
                                    ("Select VALUE FROM SETTINGS WHERE Category='CLOSINGDATETemp'", key, dbPara, commandType: CommandType.Text)).Result;
                if(DateTime != null)
                {
                    return Convert.ToDateTime(DateTime);
                }
                return new DateTime(2017, 12, 31); ;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
