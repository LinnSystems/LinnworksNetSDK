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
		public DateTime Date;

        /// <summary>
        /// Change level 
        /// </summary>
		public Int32 Level;

        /// <summary>
        /// Stock value change 
        /// </summary>
		public Double StockValue;

        /// <summary>
        /// Change note 
        /// </summary>
		public String Note;

        /// <summary>
        /// Changed quantity 
        /// </summary>
		public Int32 ChangeQty;

        /// <summary>
        /// Changed value 
        /// </summary>
		public Double ChangeValue;

		public Guid StockItemId;
	} 
}