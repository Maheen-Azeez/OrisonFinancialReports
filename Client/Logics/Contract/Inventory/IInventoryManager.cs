using OrisonMIS.Shared.Entities.Inventory;

namespace OrisonMIS.Client.Logics.Contract.Inventory
{
    public interface IInventoryManager
    {
        Task<HttpResponseMessage> CreateInventory(dtsInventory Inventory);
        //Task<HttpResponseMessage> UpdateInventory(dtsInventory Inventory);

    }
}
