using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorInputFile;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;

namespace OrisonMIS.Services
{
    public class FileUpload : IFileUpload
    {
        private readonly IWebHostEnvironment _environment;
        private string BaseUrl;
        HttpClient http = new HttpClient();
        private readonly IConfiguration _config;
        public FileUpload(IWebHostEnvironment environment, HttpClient httpClient, IConfiguration config)
        {
            _environment = environment;
            http = httpClient;
            //idbopn = idb;
            this._config = config;
            BaseUrl = _config.GetValue<string>("APIURL:MISBaseUrl");
        }

        public async Task<string> UploadAsync(IFileListEntry fileEntry, int BranchID)
        { 
            var path = Path.Combine(_environment.ContentRootPath, "wwwroot\\Upload\\"+ BranchID, fileEntry.Name);
            var ms = new MemoryStream();
            await fileEntry.Data.CopyToAsync(ms);
            using (FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                ms.WriteTo(file);
            }
            return path;
        }
        public void FileDelete(IFileListEntry fileEntry,int BranchID)
        {
            var path = PathFinder(fileEntry.Name, BranchID);
            File.Delete(path);
        }

        public void ImageDelete(string path)
        {
            File.Delete(path);
        }
        public string PathFinder(string filename,int branchid)
        {
            var path = Path.Combine(_environment.ContentRootPath, "Upload\\" + filename);
            return path;
        }
        public string PathFinder(string Action)
        {
            var path = Path.Combine(BaseUrl, "Upload/"+Action);
            return path;
        }
        public async Task<string> GetPath(int BranchID)
        {
            var path = Path.Combine(_environment.ContentRootPath, "wwwroot\\Upload\\" + BranchID);
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            return path;
        }
        public Task<string> BasePath()
        {
            var path =http.GetStringAsync(BaseUrl + "Upload");
            //.GetFromJsonAsync<string>(BaseUrl + "Upload");
            return path;
        }
        //public ActionResult UploadFile(IFormFile myFile)
        //{
        //    try
        //    {
        //        var path = Path.Combine(_environment.ContentRootPath, "wwwroot\\Upload");
        //        using (var fileStream = System.IO.File.Create(Path.Combine(path, myFile.FileName)))
        //        {
        //            myFile.CopyTo(fileStream);
        //        }
        //    }
        //    catch
        //    {
        //        //Response.StatusCode = 400;
        //    }
        //    return new EmptyResult();
        //}
        public async Task<string> MoveFile(IFormFile myFile)
        {
            try
            {
                var path = Path.Combine(_environment.ContentRootPath, "wwwroot\\Upload");
                using (var fileStream = System.IO.File.Create(Path.Combine(path, myFile.FileName)))
                {
                    myFile.CopyTo(fileStream);
                }
            }
            catch
            {
                //Response.StatusCode = 400;
            }
            return "ok";
        }
    }
}
