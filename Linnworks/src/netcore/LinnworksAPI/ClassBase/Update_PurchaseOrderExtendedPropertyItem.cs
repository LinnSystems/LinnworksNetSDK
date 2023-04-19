using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Update_PurchaseOrderExtendedPropertyItem : LinnObject
	{
		public Int32 RowId { get; set; }

		public String PropertyName { get; set; }

		public String PropertyValue { get; set; }
	} 
}