using System;
using System.Reflection;

namespace LinnworksAPI
{
    public class PreExecuteQueriesProcessDelegate
    {
        public MethodInfo Method;
        public Object Target;
    }
}