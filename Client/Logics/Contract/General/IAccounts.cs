using OrisonMIS.Shared.Entities.General;

namespace OrisonMIS.Client.Logics.Contract.General
{
    public interface IAccounts
    {
        Task<IEnumerable<LoginModel>> LoginUserNew(LoginModel obj);
    }
}
