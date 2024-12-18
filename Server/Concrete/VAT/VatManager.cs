using Dapper;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Server.Contract.VAT;
using OrisonMIS.Shared.Entities.VAT;
using System.Data;
using System.Data.Common;

namespace OrisonMIS.Server.Concrete.VAT
{
    public class VatManager : IVatManager
    {
        private readonly IDapperManager dapperManager;

        public VatManager(IDapperManager dapperManager) {
            this.dapperManager = dapperManager;
        }
        public async Task<VatReportsDto> getVatReports(DateTime dateFrom, DateTime dateTo, int branchid,string key)
        {
            IDbConnection db = dapperManager.GetConnection(key);
            VatReportsDto reports = new VatReportsDto();
            try
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                using var tran = db.BeginTransaction();
                try
                {
                    DynamicParameters dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add("@DateFrom", dateFrom,DbType.DateTime);
                    dynamicParameters.Add("@Dateto", dateTo,DbType.DateTime);
                    dynamicParameters.Add("@BranchID", branchid,DbType.Int32);

                    SqlMapper.SetTypeMap(typeof(OutPutVatDto), new CustomPropertyTypeMap(
                        typeof(OutPutVatDto),
                        (type, columnName) =>
                        {
                            if (columnName == "Amount(AED)") return type.GetProperty("AmountAED");
                            if (columnName == "VAT Amount(AED)") return type.GetProperty("VatAmountAED");
                            if (columnName == "CR Amount") return type.GetProperty("CRAmount");
                            if (columnName == "CR VAT") return type.GetProperty("CRVat");
                            if (columnName == "Net Amount") return type.GetProperty("NetAmount");
                            if (columnName == "Net VAT") return type.GetProperty("NetVat");
                            if (columnName == "Adjustment(AED)") return type.GetProperty("AdjustmentAED");
                            return type.GetProperty(columnName);
                        }
                    ));

                    SqlMapper.SetTypeMap(typeof(InPutVatDto), new CustomPropertyTypeMap(
                        typeof(InPutVatDto),
                        (type, columnName) =>
                        {
                            if (columnName == "Amount(AED)") return type.GetProperty("AmountAED");
                            if (columnName == "VAT Amount(AED)") return type.GetProperty("VatAmountAED");
                            if (columnName == "DR Amount") return type.GetProperty("DRAmount");
                            if (columnName == "DR VAT") return type.GetProperty("DRVat");
                            if (columnName == "Net Amount") return type.GetProperty("NetAmount");
                            if (columnName == "Net VAT") return type.GetProperty("NetVat");
                            if (columnName == "Adjustment(AED)") return type.GetProperty("AdjustmentAED");
                            return type.GetProperty(columnName);
                        }
                    ));

                    SqlMapper.SetTypeMap(typeof(CurrentVatDto), new CustomPropertyTypeMap(
                        typeof(CurrentVatDto),
                        (type, columnName) =>
                        {
                            if (columnName == "VAT Amount(AED)") return type.GetProperty("VatAmountAED");
                            return type.GetProperty(columnName);
                        }
                    ));

                    using (var multi = await db.QueryMultipleAsync("VAT_ReportSP", dynamicParameters,tran,commandType: CommandType.StoredProcedure))
                    {
                        if(multi != null)
                        {
                            reports.vatRegister = (await multi.ReadAsync<VatRegisterDto>()).AsList();
                            reports.outPutVat = (await multi.ReadAsync<OutPutVatDto>()).AsList();
                            reports.inPutVat = (await multi.ReadAsync<InPutVatDto>()).AsList();
                            reports.currentVat = (await multi.ReadAsync<CurrentVatDto>()).AsList();
                        }
                                               
                    }

                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                if (db.State == ConnectionState.Open)
                    db.Close();
            }
            return reports;

        }
    }
}
