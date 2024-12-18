using OrisonMIS.Shared.Entities.Inventory;

namespace OrisonMIS.Client.Logics.Contract.Inventory
{
    public interface IInvGroupItemsManager
    {
        public  Task<IEnumerable<dtInvGroupItems>> GetGroupItems(int id);


    }
}
