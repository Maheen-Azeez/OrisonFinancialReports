using OrisonMIS.Shared.Entities.Inventory;

namespace OrisonMIS.Server.Contract.Inventory
{
    public interface IInventoryRegisterManager
    {
        Task<List<StockRegisterDto>> FetchStockRegister(DateTime dateUpTo, int branchId, int wareHouseId,string key);
        Task<List<InventoryRegisterDto>> FetchInventoryRegister(int branchId, DateTime dateFrom, DateTime dateUpTo, int itemId, int categoryId, string key);
        Task<List<WareHosueDto>> FetchWarehouses(int branchId,string key);
        Task<List<InventoryItemMasterDto>> FetchItems(int branchId,string key);
        Task<List<CategoryDto>> FetchCategories(int branchId,string key);

    }
}
