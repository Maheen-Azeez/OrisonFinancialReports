using OrisonMIS.Shared.Entities.Financial;

namespace OrisonMIS.Server.Contract.Financial.Main
{
    public interface IVEntry : IDisposable
    {
        Task<List<VEntry>> Show(long VID, string key);
    }
}
