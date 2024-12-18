using OrisonMIS.Shared.Entities.Financial;

namespace OrisonMIS.Client.Logics.Contract.Financial.Main
{
    public interface IVEntry
    {
        Task<IEnumerable<VEntry>> Show(long VID);
    }
}
