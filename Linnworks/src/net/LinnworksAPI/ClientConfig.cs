using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinnworksAPI
{
    public static class ClientConfig
    {

        private static bool _ThrowExceptions;

        public static bool ThrowExceptions
        {
            get
            {
                return _ThrowExceptions;
            }
            set
            {
                _ThrowExceptions = value;
            }
        }

    }
}
