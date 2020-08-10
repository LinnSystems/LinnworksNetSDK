using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PickingWaveItemTote
	{
		public Int32 RowId { get; set; }

		public Int32 PickingWaveItemsRowId { get; set; }

		public Int32? ToteId { get; set; }

		public String TrayTag { get; set; }

		public Int32 PickedQuantity { get; set; }
	} 
}