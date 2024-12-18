using OrisonMIS.Shared.Entities.Inventory;

namespace OrisonMIS.Client.Logics.Contract.Inventory
{
    public interface IInvItemsManager
    {
         Task<IEnumerable<dtItems>> GetItems(int BranchID);

         Task<dtItems> GetItemsbyID(int BranchID,int ItemID);

    }
}
