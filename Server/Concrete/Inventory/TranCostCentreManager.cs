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
    public class TranCostCentreManager: ITranCostCentreManager
    {
        private readonly IDapperManager _dapperManager;

        public TranCostCentreManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
        public void CreateTranCostCentre(dtTranCostCentre trans, IDbConnection db, IDbTransaction tran)
        {
            long newID = 0;
            var dbPara = new DynamicParameters();
            //dbPara.Add("ID", trans.ID, DbType.Int64);
            if(trans.RowState=="Insert")
            {
                dbPara.Add("TranID", trans.TranId, DbType.Int32);
                dbPara.Add("CCID", trans.Ccid, DbType.Int32);
                dbPara.Add("CostPhaseID", trans.CostPhaseId, DbType.Int32);
                dbPara.Add("CostUnitID", trans.CostUnitId, DbType.Int32);
                dbPara.Add("Qty", trans.Qty, DbType.String);
                dbPara.Add("BasicQty", trans.BasicQty, DbType.Decimal);
                dbPara.Add("VarField2", trans.VarField2, DbType.String);
                dbPara.Add("VarField3", trans.VarField3, DbType.String);
                dbPara.Add("NumField1", trans.NumField1, DbType.Decimal);
                dbPara.Add("NumField2", trans.NumField2, DbType.Decimal);
                dbPara.Add("NumField3", trans.NumField3, DbType.Decimal);
                dbPara.Add("RowType", trans.RowType, DbType.Int32);
                dbPara.Add("VarField1", trans.VarField1, DbType.String);
                dbPara.Add("StockType", trans.StockType, DbType.Int32);
                dbPara.Add("Criteria", "Insert", DbType.String);
                dbPara.Add("NewID", dbType: DbType.Int64, direction: ParameterDirection.Output);

                newID = _dapperManager.Insert("[FINWEB_DMLTRANSCOSTCENTRESP]", dbPara, db, tran, commandType: CommandType.StoredProcedure);
            }
            else if (trans.RowState == "Update")
            {
                dbPara.Add("TranID", trans.TranId, DbType.Int32);
                dbPara.Add("CCID", trans.Ccid, DbType.Int32);
                dbPara.Add("CostPhaseID", trans.CostPhaseId, DbType.Int32);
                dbPara.Add("CostUnitID", trans.CostUnitId, DbType.Int32);
                dbPara.Add("Qty", trans.Qty, DbType.String);
                dbPara.Add("BasicQty", trans.BasicQty, DbType.Decimal);
                dbPara.Add("VarField2", trans.VarField2, DbType.String);
                dbPara.Add("VarField3", trans.VarField3, DbType.String);
                dbPara.Add("NumField1", trans.NumField1, DbType.Decimal);
                dbPara.Add("NumField2", trans.NumField2, DbType.Decimal);
                dbPara.Add("NumField3", trans.NumField3, DbType.Decimal);
                dbPara.Add("RowType", trans.RowType, DbType.Int32);
                dbPara.Add("VarField1", trans.VarField1, DbType.String);
                dbPara.Add("StockType", trans.StockType, DbType.Int32);
                dbPara.Add("Criteria", "Update", DbType.String);
                dbPara.Add("ID", trans.Id, DbType.Int32);
                dbPara.Add("NewID", dbType: DbType.Int64, direction: ParameterDirection.Output);

                newID = _dapperManager.Insert("[FINWEB_DMLTRANSCOSTCENTRESP]", dbPara, db, tran, commandType: CommandType.StoredProcedure);
            }
            else if(trans.RowState=="Delete")
            {
                dbPara.Add("Id", trans.Id, DbType.Int64);
                //_dapperManager.Execute("delete from Inv.TranCostCentre where id=@Id", dbPara, commandType: CommandType.Text);
            }
        }
        public async Task<List<dtTranCostCentre>> GetTranCostCentre(long vid, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("VId", vid, DbType.Int32);
            dbPara.Add("Criteria", "TranCostCentre", DbType.String);
            var _dtTranCostCentre = Task.FromResult(_dapperManager.GetAll<dtTranCostCentre>
                                ("[FINWEB_INVENTORYVoucherSP]", key,dbPara,
                                commandType: CommandType.StoredProcedure));
            return await _dtTranCostCentre;
        }
    }
}
