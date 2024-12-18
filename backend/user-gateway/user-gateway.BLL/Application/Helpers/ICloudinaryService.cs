using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_gateway.BLL.Application.Helpers
{
    public interface ICloudinaryService
    {
        Task<ImageUploadResult> UploadFileAsync(IFormFile file, string FolderName);
        Task<DeletionResult> DeleteFileAsync(string publicId);
    }
}
