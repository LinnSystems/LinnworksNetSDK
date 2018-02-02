using System.Collections.Generic;
using System.Text;
using System;

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