using CloudinaryDotNet.Actions;

namespace API.Interfaces;

public interface IPhotoService
{
    Task<ImageUploadResult> AddPhotoAsyncs(IFormFile file);
    Task<DeletionResult> DeletePhotoAsync(string publicId);
}
