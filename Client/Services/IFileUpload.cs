using BlazorInputFile;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace OrisonMIS.Services
{
    public interface IFileUpload
    {
        Task<string> UploadAsync(IFileListEntry file, int BranchID);
        void FileDelete(IFileListEntry fileEntry,int BranchID);
        void ImageDelete(string path);
        string PathFinder(string Action);
        Task<string> BasePath();
        string PathFinder(string filename, int branchid);
         Task<string> GetPath(int BranchID);
       Task<string> MoveFile(IFormFile myFile);
    }
}