using OrisonMIS.Shared.Entities.Financial.Main;

namespace OrisonMIS.Client.Logics.Contract.Financial.Main
{
    public interface ICheque : IDisposable
    {
        Task<IEnumerable<Cheque>> ShowCheque(long VId);
    }
}
