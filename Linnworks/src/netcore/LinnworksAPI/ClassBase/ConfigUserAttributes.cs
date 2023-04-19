using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ConfigUserAttributes : LinnObject
	{
		public String Id { get; set; }

		public String Type { get; set; }

		public String Name { get; set; }

		public String ExtendedProperty { get; set; }

		public Boolean IsRequired { get; set; }

		public Int32 MaxFileSize { get; set; }

		public String AllowedFileTypes { get; set; }

		public String SelectOptions { get; set; }

		public Int32 SortOrder { get; set; }
	} 
}