using OrisonMIS.Shared.Entities.Inventory;

namespace OrisonMIS.Client.Logics.Contract.Inventory
{
    public interface IInventoryRegisterManager
    {
        Task<List<StockRegisterDto>> FetchStockRegister(string dateUpTo, int branchId,int wareHouseId);
        Task<List<WareHosueDto>> FetchWarehouses(int branchId);
        Task<List<InventoryItemMasterDto>> FetchItems(int branchId);
        Task<List<CategoryDto>> FetchCategories(int branchId);
        Task<List<InventoryRegisterDto>> FetchInventoryRegister(int branchId, string dateFrom, string dateUpTo,int itemId, int categoryId);
    }
}
