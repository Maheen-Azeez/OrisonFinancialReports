using Dapper;
using Microsoft.Identity.Client;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Server.Contract.Inventory;
using OrisonMIS.Shared.Entities.Inventory;
using System.Data;

namespace OrisonMIS.Server.Concrete.Inventory
{
    public class InventoryRegisterManager : IInventoryRegisterManager
    {
        private readonly IDapperManager _dapperManager;
        public InventoryRegisterManager(IDapperManager dapperManager, IDBOperation DB)
        {
            _dapperManager = dapperManager;
        }

        public async Task<List<InventoryRegisterDto>> FetchInventoryRegister(int branchId, DateTime dateFrom, DateTime dateUpTo, int itemId, int categoryId, string key)
        {
            var dbPara = new DynamicParameters();
            string ProcName;
            ProcName = "InvTransactionsSP";
            dbPara.Add("BranchId", branchId, DbType.Int32);
            dbPara.Add("DateUpto", dateUpTo, DbType.DateTime);
            dbPara.Add("DateFrom", dateFrom, DbType.DateTime);
            dbPara.Add("ItemID", itemId == 0 ? null : itemId, DbType.Int32);
            dbPara.Add("CategoryID", categoryId == 0 ? null : categoryId, DbType.Int32);
            var invetoryRegister = Task.FromResult(_dapperManager.GetAll<InventoryRegisterDto>
                                (ProcName, key, dbPara, commandType: CommandType.StoredProcedure));
            return await invetoryRegister;
        }

        public async Task<List<InventoryItemMasterDto>> FetchItems(int branchId, string key)
        {
            try
            {
                var dbPara = new DynamicParameters();
                string ProcName;
                ProcName = "FinRep_ItemMaster";
                dbPara.Add("BranchId", branchId, DbType.Int32);
                dbPara.Add("Criteria", "ItemMasterList", DbType.String);

                var items = Task.FromResult(_dapperManager.GetAll<InventoryItemMasterDto>
                                    (ProcName, key, dbPara, commandType: CommandType.StoredProcedure));
                return await items;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public async Task<List<CategoryDto>> FetchCategories(int branchId, string key)
        {
            try
            {
                string query = "SELECT DISTINCT Id ,Category Name FROM inv.category";

                var categories = Task.FromResult(_dapperManager.GetAll<CategoryDto>
                                    (query, key, null, commandType: CommandType.Text));
                return await categories;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public async Task<List<StockRegisterDto>> FetchStockRegister(DateTime dateUpTo, int branchId, int wareHouseId,string key)
        {
            var dbPara = new DynamicParameters();
            string ProcName;
            ProcName = "StockOnDateSP";
            dbPara.Add("BranchId", branchId, DbType.Int32);
            dbPara.Add("DateUpto", dateUpTo, DbType.DateTime);
            dbPara.Add("WHID", wareHouseId == 0 ? null : wareHouseId, DbType.Int32);
            var stockRegister = Task.FromResult(_dapperManager.GetAll<StockRegisterDto>
                                (ProcName, key, dbPara, commandType: CommandType.StoredProcedure));
            return await stockRegister;
        }

        public async Task<List<WareHosueDto>> FetchWarehouses(int branchId, string key)
        {
            try
            {
                string query = $"select WHCode,b.ID WHID from WarehouseBranch b inner join WareHouseMaster m on m.id=b.whid where BranchID={branchId}";

                var warehouses = Task.FromResult(_dapperManager.GetAll<WareHosueDto>
                                    (query, key, null, commandType: CommandType.Text));
                return await warehouses;
            }
            catch (Exception e)
            {

                throw e;
            }
            
        }
    }
}
