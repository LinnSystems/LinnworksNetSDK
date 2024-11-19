using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class SavedItem : LinnObject
	{
		public String Name { get; set; }

		public Int32 Quantity { get; set; }

		public Decimal? UnitValue { get; set; }

		public String UnitValueCurrency { get; set; }
	} 
}