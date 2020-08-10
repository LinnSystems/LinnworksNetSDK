using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PickingWaveOptions
	{
        /// <summary>
        /// Item scan type, dictates if the user must scan all items or can provide aggregate count 
        /// </summary>
		public ItemSanType ItemScanType { get; set; }

        /// <summary>
        /// If the user must scan the tray the item went into. 
        /// </summary>
		public Boolean TrayScanRequired { get; set; }

        /// <summary>
        /// If the user must scan the tot before scanning items. 
        /// </summary>
		public Boolean TotScanRequired { get; set; }

        /// <summary>
        /// If the user must scan the binrack before picking an item. 
        /// </summary>
		public Boolean BinRackScanRequired { get; set; }
	} 
}