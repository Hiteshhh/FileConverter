using FileConverter;
using System;


namespace FormatConverter
{
    internal class Options : IOptions
    {
        public Options(string source, string target)
        {
            this.source = source;
            this.target = target;
        }
        public string source { get; set; }
        public string target { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            IOptions options = new Options("C:\\Users\\hqwx9p\\Downloads\\M1_TrackAndTrace.API.Tests.json", "D:\\phone backup");
            FileFormatConverter converter = new FileFormatConverter(options);
            var pp = converter.Convert();
            Console.WriteLine(pp.Message);
            Console.ReadLine();
        }
    }
    
}
