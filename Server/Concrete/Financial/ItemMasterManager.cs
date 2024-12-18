using Dapper;
using Microsoft.Data.SqlClient;
using OrisonMIS.Server.Contract.Financial;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.Financial;
using OrisonMIS.Shared.Entities.General;
using System.Data;

namespace OrisonMIS.Server.Concrete.Financial
{
    public class ItemMasterManager : IItemMasterManager
    {
        private readonly IDapperManager _dapperManager;
        private readonly IConfiguration _config;

        public ItemMasterManager(IDapperManager dapperManager, IConfiguration config)
        {
            this._dapperManager = dapperManager;
            _config = config;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
        public async Task<List<string>> GetCombo(string Criteria, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Criteria", Criteria, DbType.String);
            var Items = Task.FromResult(_dapperManager.GetAll<string>
                                ("[FINWEB_GetItemMasterSP]", key, dbPara,
                                commandType: CommandType.StoredProcedure));
            return await Items;
        }
        public async Task<List<dtInvAccounts>> GetAccountsCombo(string Description, string Criteria, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Description", Description, DbType.String);
            dbPara.Add("Criteria", Criteria, DbType.String);
            var Accounts = Task.FromResult(_dapperManager.GetAll<dtInvAccounts>
                                ("[FINWEB_GetItemMasterSP]", key, dbPara,
                                commandType: CommandType.StoredProcedure));
            return await Accounts;
        }
        public async Task<IEnumerable<dtItemMaster>> GetItemMasterbyID(string ID, string key)
        {
            if (ID.ToString() == "0")
                ID = Convert.ToInt32(Task.FromResult(_dapperManager.Get<int>("SELECT top 1 id FROM inv.itemmaster ORDER BY ID DESC", key,null,
                      commandType: CommandType.Text)).Result).ToString();
            var dbPara = new DynamicParameters();
            dbPara.Add("ID", ID, DbType.String);
            dbPara.Add("Criteria", "ItemMasterbyID", DbType.String);
            //dtInvVoucher voucher = new dtInvVoucher();
            var Items = Task.FromResult(_dapperManager.GetAll<dtItemMaster>
                                ("[FINWEB_GetItemMasterSP]", key, dbPara,
                                commandType: CommandType.StoredProcedure));
            return await Items;
        }
        public async Task<IEnumerable<dtItemMaster>> GetItemMaster(string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Criteria", "ItemMaster", DbType.String);
            var vouchermaster = Task.FromResult(_dapperManager.GetAll<dtItemMaster>
                                 ("[FINWEB_INVENTORYVoucherSP]", key,dbPara,
                                 commandType: CommandType.StoredProcedure));
                return await vouchermaster;
            
        }
        public async Task<long> CreateItemMaster(dtItemMaster ItemMaster, string key)
        {
            long newID = 0;
            using IDbConnection db = new SqlConnection(_config.GetConnectionString(key));
            try
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                using var tran = db.BeginTransaction();
                try
                {
                    var dbPara = new DynamicParameters();
                    dbPara.Add("ItemCode", ItemMaster.ItemCode, DbType.String);
                    dbPara.Add("ItemName", ItemMaster.ItemName, DbType.String);
                    dbPara.Add("SellingPrice", ItemMaster.SellingPrice, DbType.Decimal);
                    dbPara.Add("OEMNo", ItemMaster.Oemno, DbType.String);
                    dbPara.Add("PartNo", ItemMaster.PartNo, DbType.String);
                    var CatID = Convert.ToInt32(Task.FromResult(_dapperManager.Get<int>("Select ID from inv.category where Category='" + ItemMaster.Category + "'", key,null, commandType: CommandType.Text)).Result);
                    dbPara.Add("CategoryID", CatID, DbType.Int32);
                    dbPara.Add("Manufacturer", ItemMaster.Manufacturer, DbType.String);
                    dbPara.Add("BarCode", ItemMaster.BarCode, DbType.String);
                    dbPara.Add("ModelNo", ItemMaster.ModelNo, DbType.String);
                    dbPara.Add("Unit", ItemMaster.Unit, DbType.String);
                    dbPara.Add("Remarks", ItemMaster.Remarks, DbType.String);
                    dbPara.Add("IsGroup", ItemMaster.IsGroup, DbType.String);
                    dbPara.Add("StockItem", ItemMaster.StockItem, DbType.Boolean);
                    dbPara.Add("Inactive", ItemMaster.Inactive, DbType.Boolean);
                    dbPara.Add("InvAccountID", ItemMaster.InvAccountId, DbType.Int32);
                    dbPara.Add("CostAccountID", ItemMaster.CostAccountId, DbType.Int32);
                    dbPara.Add("PurchaseAccountID", ItemMaster.PurchaseAccountId, DbType.Int32);
                    dbPara.Add("SalesAccountID", ItemMaster.SalesAccountId, DbType.Int32);
                    dbPara.Add("ROL", ItemMaster.Rol, DbType.Decimal);
                    dbPara.Add("CreatedUserID", ItemMaster.CreatedUserId, DbType.Int32);
                    dbPara.Add("ModifiedUserID", ItemMaster.ModifiedUserId, DbType.Int32);
                    dbPara.Add("BranchID", ItemMaster.BranchId, DbType.Int32);
                    dbPara.Add("MajorGroup", ItemMaster.MajorGroup, DbType.String);
                    dbPara.Add("MiddleGroup", ItemMaster.MiddleGroup, DbType.String);
                    dbPara.Add("MinorGroup", ItemMaster.MinorGroup, DbType.String);
                    dbPara.Add("Location", ItemMaster.Location, DbType.String);
                    dbPara.Add("CashPrice", ItemMaster.CashPrice, DbType.Decimal);
                    dbPara.Add("CreditPrice", ItemMaster.CreditPrice, DbType.Decimal);
                    dbPara.Add("ROQ", ItemMaster.Roq, DbType.Decimal);
                    dbPara.Add("Field1", ItemMaster.Field1, DbType.String);
                    dbPara.Add("Field2", ItemMaster.Field2, DbType.String);
                    dbPara.Add("Field3", ItemMaster.Field3, DbType.String);
                    dbPara.Add("Field4", ItemMaster.Field4, DbType.String);
                    dbPara.Add("Field5", ItemMaster.Field5, DbType.String);
                    dbPara.Add("FixedAssetItem", ItemMaster.FixedAssetItem, DbType.Boolean);
                    dbPara.Add("VATPerCen", ItemMaster.Vatpercen, DbType.Decimal);
                    dbPara.Add("ExcisePercen", ItemMaster.ExcisePercen, DbType.Decimal);
                    dbPara.Add("VRATE", ItemMaster.Vrate, DbType.Decimal);
                    dbPara.Add("Criteria", ItemMaster.Criteria, DbType.String);
                    if(ItemMaster.Criteria=="Update")
                        dbPara.Add("Original_ID", ItemMaster.Id, DbType.Int32);
                    else
                        dbPara.Add("NewID", dbType: DbType.Int64, direction: ParameterDirection.Output);


                    newID = _dapperManager.Execute("[FINWEB_ItemMasterSP]", key, dbPara, commandType: CommandType.StoredProcedure);

                    tran.Commit();

                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
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

            return newID;
        }

    }
}
