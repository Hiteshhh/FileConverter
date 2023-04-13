namespace FileConverter
{
    public enum Result 
    { 
        Success,
        failure
    }
    public class ResponseObj
    {
        public Result result { get; set; }
        public int statusCode { get; set; }
        public string Message { get; set; }
    }
}