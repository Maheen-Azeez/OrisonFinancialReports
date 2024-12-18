using Blazored.SessionStorage;

namespace OrisonMIS.Client.Services
{
    public class FinancialDateTimeService
    {
        private DateTime _startDate { get; set; }
        private DateTime _endDate { get; set; }

        private readonly ISessionStorageService _sessionStorage;
        public FinancialDateTimeService(ISessionStorageService _sessionStorage)
        {
            this._sessionStorage = _sessionStorage;
        }
        public DateTime StartDate
        {
            get => _startDate;
            set
            {
                if (_startDate != value)
                {
                    _startDate = value;
                    _sessionStorage.SetItemAsync("StartDate", _startDate);
                }
            }
        }

        public DateTime EndDate
        {
            get => _endDate;
            set
            {
                if (_endDate != value)
                {
                    _endDate = value;
                    _sessionStorage.SetItemAsync("EndDate", _endDate);
                }
            }
        }

        public async Task InitializeDates()
        {
            StartDate = await _sessionStorage.GetItemAsync<DateTime>("StartDate");
            EndDate = await _sessionStorage.GetItemAsync<DateTime>("EndDate");
        }

        public async Task SetDates(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
            await _sessionStorage.SetItemAsync("StartDate", startDate);
            await _sessionStorage.SetItemAsync("EndDate", endDate);
        }
    }
}
