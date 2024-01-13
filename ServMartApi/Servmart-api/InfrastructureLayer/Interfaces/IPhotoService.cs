using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;

namespace InfrastructureLayer.Interfaces
{
    public interface IPhotoService
    {
        Task<ImageUploadResult> AddPhotoAsync(IFormFile file);
        Task<DeletionResult> DeletionPhotoAsync(string publicid);
    }
}
