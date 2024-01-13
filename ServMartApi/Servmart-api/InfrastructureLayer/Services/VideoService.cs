using Application_Layer.Interfaces;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Application_Layer.Services
{
	public class VideoService : IVideoService
	{
		private readonly Cloudinary _cloudinary;
		private readonly IConfiguration _config;
		public VideoService( IConfiguration config )
		{
			_config = config;
			var acc = new Account(
				config[ "CloudinarySettings:CloudName" ],
				config[ "CloudinarySettings:ApiKey" ],
				config[ "CloudinarySettings:ApiSecret" ] );
			_cloudinary = new Cloudinary( acc );
		}

		public async Task<VideoUploadResult> AddVideoAsync( IFormFile file )
		{
			var uploadResult = new VideoUploadResult();
			if ( file.Length > 0 )
			{
				using var stream = file.OpenReadStream();
				var uploadParams = new VideoUploadParams
				{
					File = new FileDescription( file.FileName, stream ),
					Transformation = new Transformation().Crop( "pad" )
				};
				uploadResult = await _cloudinary.UploadAsync( uploadParams );
			}

			return uploadResult;
		}

		public Task<DeletionResult> DeleteVideoAsync( string publicid )
		{
			var deleteParams = new DeletionParams( publicid );
			var result = _cloudinary.DestroyAsync( deleteParams );
			return result;
		}

	}
}
