using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinnworksAPI
{
    public class LinnworksAPIException : System.Exception 
    {

        public LinnworksAPIException(string message, string code, Exception innerException):base(message,innerException)
        {
            _Code = code;
        }

        private string _Code;
        public string Code {
            get
            {
                return _Code;
            }
        }

    }
}
