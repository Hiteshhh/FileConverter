using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConverter
{
    internal class customException : Exception
    {
        static Dictionary<int, string> errors = new Dictionary<int, string>
        {
            {0,"success" },
            {1,"source location is invalid" },
            {2,"Target location is invalid" },
            {3,"File already Present at target location" },
            {4,"Conversion failed" }
        };
        public int errorCode { get; set; }
        public customException(int errorCode):base(errors.FirstOrDefault(t => t.Key.Equals(errorCode)).Value)
        {
            this.errorCode = errorCode;
        }

    }
}
