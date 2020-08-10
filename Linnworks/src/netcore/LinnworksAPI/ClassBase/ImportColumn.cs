using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ImportColumn
	{
		public List<AddData> AdditionalData { get; set; }

		public String FileColumn { get; set; }

		public String Column { get; set; }

		public String Expression { get; set; }

		public String DefaultValue { get; set; }

		public Boolean Visible { get; set; }
	} 
}