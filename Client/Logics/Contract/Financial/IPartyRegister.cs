using OrisonMIS.Shared.Entities.Financial;

namespace OrisonMIS.Client.Logics.Contract.Financial
{
    public interface IPartyRegister
    {
        Task<IEnumerable<PartyRegister>> Show(string AccCategory, long BranchId);
    }
}
