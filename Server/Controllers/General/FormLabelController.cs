using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Server.Controllers.General
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormLabelController : ControllerBase
    {
        private IWebHostEnvironment _environment;
        private IDBOperation _repository;

        public FormLabelController( IWebHostEnvironment environment, IDBOperation repository)
        {
            _environment = environment;
            _repository = repository;
        }
        // GET: api/FormLabel?FormName=frmEmployee
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FormLabel>>> GetUserRights(string FormName, string key)
        {
            var FormLabelMast = await _repository.GetFormLabels(FormName,key);

            if (FormLabelMast == null)
            {
                return NotFound();
            }

            return FormLabelMast;
        }
    }
}
