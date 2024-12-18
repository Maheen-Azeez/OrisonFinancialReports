using Dapper;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.General;
using System.Data;

namespace OrisonMIS.Server.Concrete.General
{
    public class EntryModeManager : IEntryModeManager
    {
        private readonly IDapperManager _dapperManager;

        public EntryModeManager(IDapperManager dapperManager)
        {
            _dapperManager = dapperManager;
        }
        public async Task<IList<EntryModeMaster>> GetAllEntryMode(string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Criteria", "EntryModeMast", DbType.String);
            var _EntryMode = Task.FromResult(_dapperManager.GetAll<EntryModeMaster>
                                ("[FinRep_InventoryVoucherSP]", key, dbPara,
                                commandType: CommandType.StoredProcedure));
            return await _EntryMode;
        }
        public async Task<EntryModeMaster> GetEntryMode(string type, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Keyword", type, DbType.String);
            dbPara.Add("Criteria", "EntryModeMastbyMode", DbType.String);
            var _EntryMode = Task.FromResult(_dapperManager.Get<EntryModeMaster>
                                ("[FinRep_InventoryVoucherSP]", key, dbPara,
                                commandType: CommandType.StoredProcedure));
            return await _EntryMode;
        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
