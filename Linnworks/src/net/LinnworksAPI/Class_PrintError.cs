using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class PrintError
    {
        public String TemplateType;
        public Guid Id;
        public String Error;
        public List<PrintErrorTags> Tags;
    }
}