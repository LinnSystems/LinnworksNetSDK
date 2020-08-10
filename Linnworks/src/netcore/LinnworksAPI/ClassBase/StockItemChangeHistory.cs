using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemChangeHistory
	{
        /// <summary>
        /// When changes were made 
        /// </summary>
		public DateTime Date { get; set; }

        /// <summary>
        /// Change level 
        /// </summary>
		public Int32 Level { get; set; }

        /// <summary>
        /// Stock value change 
        /// </summary>
		public Double StockValue { get; set; }

        /// <summary>
        /// Change note 
        /// </summary>
		public String Note { get; set; }

        /// <summary>
        /// Changed quantity 
        /// </summary>
		public Int32 ChangeQty { get; set; }

        /// <summary>
        /// Changed value 
        /// </summary>
		public Double ChangeValue { get; set; }

		public Guid StockItemId { get; set; }

		public Int32 StockItemIntId { get; set; }
	} 
}