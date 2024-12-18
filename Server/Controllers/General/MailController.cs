using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrisonMIS.Shared.Models;

namespace OrisonMISAPI.Controllers.General
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly IMailServiceSettings mailService;
        public MailController(IMailServiceSettings mailService)
        {
            this.mailService = mailService;
        }
        [HttpPost("send")]
        public async void SendMail([FromForm] MailRequest request)
        {
            try
            {
                await mailService.SendEmailAsync(request);
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        [HttpGet()]
        public async void SendTestMail()
        {
            try
            {
                await mailService.SendTestEmailAsync();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        [HttpGet("{ID}")]
        public async Task<MailRequest> GetMailDetails(string ID)
        {
            try
            {
                
                return await mailService.getMailRequestSettings(ID);
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
