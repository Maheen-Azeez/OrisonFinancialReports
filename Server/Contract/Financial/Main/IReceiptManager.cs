using OrisonMIS.Shared.Entities.General;

namespace OrisonMIS.Server.Contract.Financial.Main
{
    public interface IReceiptManager : IDisposable
    {
        Task<List<dtVoucherMaster>> ReceiptList(int vtype, int userid, string key);
    }
}
