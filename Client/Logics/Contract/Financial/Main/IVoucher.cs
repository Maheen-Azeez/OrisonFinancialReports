using OrisonMIS.Shared.Entities.Financial.Main;

namespace OrisonMIS.Client.Logics.Contract.Financial.Main
{
    public interface IVoucher : IDisposable
    {
        public Task<Voucher> ShowVoucher(long VId);

    }
}
