using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ProductIdentifierInformation : LinnObject
	{
		public ProductIdentifierType Type { get; set; }

		public String DisplayName { get; set; }

		public Boolean ScannedAtDispatch { get; set; }

		public List<String> Sources { get; set; }
	} 
}