using OrisonMIS.Shared.Models;

namespace OrisonMISAPI.Contracts.General
{
    public interface IMailServiceSettings : IDisposable
    {
        Task SendEmailAsync(MailRequest mailRequest);
        Task SendTestEmailAsync();

        Task<MailRequest> getMailRequestSettings(string AID); //, int uid, long vid
    }
}
