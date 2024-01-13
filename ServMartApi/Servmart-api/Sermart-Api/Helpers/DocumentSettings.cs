namespace Sermart_Api.Helpers
{
    public class DocumentSettings
    {
        public static string UploadImages(IFormFile file ,string folerName)
        {
            string FolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\File\\", folerName);
            string fileName = $"{Guid.NewGuid()}{file.FileName}";

            string path = Path.Combine(FolderPath, fileName);

            using var fs = new FileStream(path, FileMode.Create);
            file.CopyTo(fs);
            return fileName;
        }
    }
}
