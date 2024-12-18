using OrisonMIS.Shared.Entities.Financial.Main;

namespace OrisonMIS.Server.Contract.Financial.Main
{
    public interface IVoucher : IDisposable
    {
        Task<Voucher> ShowVoucher(long VId, string key);
    }
}
