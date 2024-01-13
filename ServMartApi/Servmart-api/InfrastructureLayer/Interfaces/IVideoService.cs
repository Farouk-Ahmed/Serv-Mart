using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;

namespace Application_Layer.Interfaces
{
	public interface IVideoService
	{
		Task<VideoUploadResult> AddVideoAsync( IFormFile file );
		Task<DeletionResult> DeleteVideoAsync( string publicid );
	}
}
