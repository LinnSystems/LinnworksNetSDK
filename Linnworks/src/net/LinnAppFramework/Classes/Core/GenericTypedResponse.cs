using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinnAppFramework.Classes.Core
{
    public class GenericTypedResponse<T> : GenericResponse
    {
        public T Data;
    }
}