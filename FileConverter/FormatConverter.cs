using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConverter
{
    public class FileFormatConverter
    {
        
        public IOptions options { get; set; }
        public FileFormatConverter(IOptions options)
        {
            this.options = options;
        }

        public ResponseObj Convert() 
        {
            try
            {
                if (!File.Exists(options.source)) throw new customException(1);
                if (!Directory.Exists(options.target)) throw new customException(2);
                if (File.Exists(options.target)) throw new customException(3);

                using (StreamReader reader = new StreamReader(options.source))
                {
                    using (StreamWriter writetext = new StreamWriter(Path.Combine(options.target, $"{Path.GetFileNameWithoutExtension(options.source)}.txt")))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
                return new ResponseObj() { Message = "File created succesfully", statusCode = 0, result = Result.Success };
            }
            catch (customException ex)
            {
                return new ResponseObj() { Message = ex.Message, statusCode = ex.errorCode, result = Result.failure };
            }
            catch (Exception ex)
            {
                return new ResponseObj() { Message = ex.Message, statusCode = 4, result = Result.failure };
            }
        }
    }
}
