using Dapper;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Server.Contract.Inventory;
using OrisonMIS.Shared.Entities.Inventory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Server.Concrete.Inventory
{
    public class VEntryCostCentreManager: IVEntryCostCentreManager
    {
        private readonly IDapperManager _dapperManager;

        public VEntryCostCentreManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
        public void VEntryCostCentreEvents(dtVentryCostCentre Ventry, IDbConnection db, IDbTransaction tran)
        {
            
            var dbPara = new DynamicParameters();
            if(Ventry.RowState=="Insert")
            {
                dbPara.Add("VEID", Ventry.Veid, DbType.Int32);
                dbPara.Add("CCID", Ventry.Ccid, DbType.Int32);
                dbPara.Add("CostPhaseID", Ventry.CostPhaseId, DbType.Int32);
                dbPara.Add("CostUnitID", Ventry.CostUnitId, DbType.Int32);
                dbPara.Add("CostCategoryID", Ventry.CostCategoryId, DbType.Int32);
                dbPara.Add("Debit", Ventry.Debit, DbType.Decimal);
                dbPara.Add("Credit", Ventry.Credit, DbType.Decimal);
                dbPara.Add("Description", Ventry.Description, DbType.String);
                dbPara.Add("Criteria", "Insert", DbType.String);
                dbPara.Add("NewID", dbType: DbType.Int64, direction: ParameterDirection.Output);

                long newID = _dapperManager.Insert("[FINWEB_DMLVENTRYCOSTCENTRESP]", dbPara, db, tran, commandType: CommandType.StoredProcedure);
            }
            else if(Ventry.RowState=="Update")
            {
                dbPara.Add("VEID", Ventry.Veid, DbType.Int32);
                dbPara.Add("CCID", Ventry.Ccid, DbType.Int32);
                dbPara.Add("CostPhaseID", Ventry.CostPhaseId, DbType.Int32);
                dbPara.Add("CostUnitID", Ventry.CostUnitId, DbType.Int32);
                dbPara.Add("CostCategoryID", Ventry.CostCategoryId, DbType.Int32);
                dbPara.Add("Debit", Ventry.Debit, DbType.Decimal);
                dbPara.Add("Credit", Ventry.Credit, DbType.Decimal);
                dbPara.Add("Description", Ventry.Description, DbType.String);
                dbPara.Add("Criteria", "Update", DbType.String);
                dbPara.Add("ID", Ventry.Id, DbType.Int32);
                dbPara.Add("NewID", dbType: DbType.Int64, direction: ParameterDirection.Output);

                long newID = _dapperManager.Insert("[FINWEB_DMLVENTRYCOSTCENTRESP]", dbPara, db, tran, commandType: CommandType.StoredProcedure);
            }
            else if(Ventry.RowState=="Delete")
            {
                dbPara.Add("Id", Ventry.Id, DbType.Int64);
                //_dapperManager.Execute("delete from VoucherEntry where id=@Id", dbPara, commandType: CommandType.Text);
            }
  
        }
        public async Task<List<dtVentryCostCentre>> GetVEntryCostCentre(long vid, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("VId", vid, DbType.Int32);
            dbPara.Add("Criteria", "VEntryCostCentre", DbType.String);
            var _dtVentryCostCentres = Task.FromResult(_dapperManager.GetAll<dtVentryCostCentre>
                                ("[FINWEB_INVENTORYVoucherSP]", key,dbPara,
                                commandType: CommandType.StoredProcedure));
            return await _dtVentryCostCentres;
        }
    }
}
