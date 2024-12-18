using OrisonMIS.Shared.Entities.General;

namespace OrisonMIS.Server.Contract.General
{
    public interface IEntryModeManager
    {
        public Task<IList<EntryModeMaster>> GetAllEntryMode(string key);
        public Task<EntryModeMaster> GetEntryMode(string type, string key);
    }
}
