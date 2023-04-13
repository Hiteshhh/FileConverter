namespace FileConverter
{
    public interface IOptions
    {
        string source { get; set; }
        string target { get; set; }
    }
}