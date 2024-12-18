using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace OrisonMIS.Server.Controllers.General
{
    [Route("api/[controller]")]
    public class UploadController : ControllerBase
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public UploadController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpPost]
        [Route("UploadFile")]
        // "myFile" is the value of the Upload's "Name" property.
        public ActionResult UploadFile(IFormFile myFile)
        {
            try
            {
                // Specify the target location for the uploaded files.
                var path = Path.Combine(_hostingEnvironment.ContentRootPath, "upload");
                // Check whether the target directory exists; otherwise, create it.
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                using (var fileStream = System.IO.File.Create(Path.Combine(path, myFile.FileName)))
                {
                    // Check the file here (its extension, safity, and so on). 
                    // If all checks are passed, save the file.
                    myFile.CopyTo(fileStream);
                }
            }
            catch
            {
                Response.StatusCode = 400;
            }

            return new EmptyResult();
        }
        [HttpGet]
        public string BasePath()
        {
            return Path.Combine(_hostingEnvironment.ContentRootPath, "Upload");
        }
        [HttpPost("[action]")]
        public void Save(IList<IFormFile> chunkFile, IList<IFormFile> UploadFiles)
        {
            long size = 0;
            try
            {
                foreach (var file in UploadFiles)
                {
                    var filename = ContentDispositionHeaderValue
                            .Parse(file.ContentDisposition)
                            .FileName
                            .Trim('"');
                    var folders = filename.Split('/');
                    var uploaderFilePath = Path.Combine(_hostingEnvironment.ContentRootPath, "Upload");
                    // for Directory upload
                    if (folders.Length > 1)
                    {
                        for (var i = 0; i < folders.Length - 1; i++)
                        {
                            var newFolder = uploaderFilePath + $@"\{folders[i]}";
                            Directory.CreateDirectory(newFolder);
                            uploaderFilePath = newFolder;
                            filename = folders[i + 1];
                        }
                    }
                    filename = uploaderFilePath + $@"\{filename}";
                    size += file.Length;
                    if (!System.IO.File.Exists(filename))
                    {
                        using (FileStream fs = System.IO.File.Create(filename))
                        {
                            file.CopyTo(fs);
                            fs.Flush();
                        }

                    }
                }
            }
            catch (Exception e)
            {
                Response.Clear();
                Response.StatusCode = 204;
                Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "File failed to upload";
                Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = e.Message;
            }
        }

        [HttpPost("[action]")]
        public void Remove(IList<IFormFile> UploadFiles)
        {
            try
            {
                var filename = _hostingEnvironment.ContentRootPath + $@"\{UploadFiles[0].FileName}";
                if (System.IO.File.Exists(filename))
                {
                    System.IO.File.Delete(filename);
                }
            }
            catch (Exception e)
            {
                Response.Clear();
                Response.StatusCode = 200;
                Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "File removed successfully";
                Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = e.Message;
            }
        }
    }
}