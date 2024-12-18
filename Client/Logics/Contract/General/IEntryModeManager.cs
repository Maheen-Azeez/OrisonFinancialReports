using OrisonMIS.Shared.Entities.General;

namespace OrisonMIS.Logics.Contracts.General
{
    public interface IEntryModeManager
    {
        public Task<IList<EntryModeMaster>> GetAllEntryMode();
        public Task<EntryModeMaster> GetEntryMode(string type);
    }
}
