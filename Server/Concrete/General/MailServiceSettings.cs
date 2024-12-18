using Dapper;
using MailKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using OrisonMISAPI.Contracts.General;
using OrisonMISAPI.Entities.General;
using OrisonMISAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMISAPI.Concrete.General
{
    public class MailServiceSettings: IMailServiceSettings
    {
        private readonly MailSettings _mailSettings;
        private readonly IDapperManager _dapperManager;
        public MailServiceSettings( IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
        public async Task<MailSettings> getMailSettings()
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Criteria", "MailSettings", DbType.String);
            var settings = Task.FromResult(_dapperManager.Get<MailSettings>
                                ("[FINWEB_MailSettingsSP]", dbPara,
                                commandType: CommandType.StoredProcedure));
            return await settings;
        }

        public async Task<MailRequest> getMailRequestSettings(string AID) //, int uid, long vid
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("AID", AID, DbType.String);
            dbPara.Add("Criteria", "MailRequest", DbType.String);
            var settings = Task.FromResult(_dapperManager.Get<MailRequest>
                                ("[FINWEB_MailSettingsSP]", dbPara,
                                commandType: CommandType.StoredProcedure));
            return await settings;
        }

        public async Task SendEmailAsync(MailRequest mailRequest) //
        {
            var email = new MimeMessage();
            var settings = await getMailSettings();
            email.Sender = MailboxAddress.Parse(settings.Mail);
            email.To.Add(MailboxAddress.Parse(mailRequest.ToEmail));
            email.Subject = mailRequest.Subject;
            var builder = new BodyBuilder();
            //if (mailRequest.Attachments != null)
            //{
            //    byte[] fileBytes;
            //    foreach (var file in mailRequest.Attachments)
            //    {
            //        if (file.Length > 0)
            //        {
            //            using (var ms = new MemoryStream())
            //            {
            //                file.CopyTo(ms);
            //                fileBytes = ms.ToArray();
            //            }
            //            builder.Attachments.Add(file.FileName, fileBytes, ContentType.Parse(file.ContentType));
            //        }
            //    }
            //}
            builder.HtmlBody = mailRequest.Body;
            email.Body = builder.ToMessageBody();
            using var smtp = new SmtpClient();
            smtp.Connect(settings.Host, settings.Port, SecureSocketOptions.StartTls);
            smtp.Authenticate(settings.Mail, settings.Password);
            await smtp.SendAsync(email);
            smtp.Disconnect(true);
        }

        public async Task SendTestEmailAsync()
        {
            var email = new MimeMessage();
            var settings = await getMailSettings();
            email.Sender = MailboxAddress.Parse(settings.Mail);
            email.To.Add(MailboxAddress.Parse("neethu.mv.02@gmail.com"));
            email.Subject = "Test Mail";//mailRequest.Subject;
            var builder = new BodyBuilder();
            builder.HtmlBody = "Test Mail sent successfully!! <br> www.google.com";// mailRequest.Body;
            email.Body = builder.ToMessageBody();
            using var smtp = new SmtpClient();
            smtp.Connect(settings.Host, settings.Port, SecureSocketOptions.StartTls);
            smtp.Authenticate(settings.Mail, settings.Password);
            await smtp.SendAsync(email);
            smtp.Disconnect(true);
        }
    }
}
