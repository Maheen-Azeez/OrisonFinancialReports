using OrisonMIS.Shared.Entities.General;

namespace OrisonMIS.Client.Logics.Contract.Financial.Main
{
    public interface IReceiptManager
    {
        Task<IEnumerable<dtVoucherMaster>> ReceiptList(int vtype, int Id);
    }
}
