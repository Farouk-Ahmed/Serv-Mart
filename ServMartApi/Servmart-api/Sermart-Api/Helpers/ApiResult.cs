namespace Sermart_Api.Helpers
{
    public class ApiResult<T>
    {
        public int status { get; set; }
        public string massage { get; set; }
        public bool success { get; set; }
        public T data { get; set; }
    }
}
