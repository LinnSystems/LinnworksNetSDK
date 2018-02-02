using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Simple stock item image record 
    /// </summary>
    public class StockItemImageSimple
	{
        /// <summary>
        /// Unique id of image 
        /// </summary>
		public Guid pkRowId;

        /// <summary>
        /// Is the image the main image 
        /// </summary>
		public Boolean IsMain;

        /// <summary>
        /// Sort order for the image 
        /// </summary>
		public Int32 SortOrder;

		public Guid StockItemId;
	} 
}