using OrisonMIS.Shared.Entities.Financial.Main;

namespace OrisonMIS.Server.Contract.Financial.Main
{
    public interface ICheque : IDisposable
    {
        Task<List<Cheque>> ShowCheque(long VId, string key);
    }
}
