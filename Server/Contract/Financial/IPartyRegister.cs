using OrisonMIS.Shared.Entities.Financial;

namespace OrisonMIS.Server.Contract.Financial
{
    public interface IPartyRegister : IDisposable
    {
        Task<List<PartyRegister>> Show(string AccCategory, long BranchId, string key);
    }
}
