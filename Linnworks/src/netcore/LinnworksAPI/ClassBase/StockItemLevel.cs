using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemLevel
	{
        /// <summary>
        /// Location ID 
        /// </summary>
		public StockLocation Location;

        /// <summary>
        /// Stock level 
        /// </summary>
		public Int32 StockLevel;

        /// <summary>
        /// Stock value 
        /// </summary>
		public Double StockValue;

        /// <summary>
        /// Minimum level 
        /// </summary>
		public Int32 MinimumLevel;

        /// <summary>
        /// Currently in open orders 
        /// </summary>
		public Int32 InOrderBook;

        /// <summary>
        /// Due to come in purchase orders 
        /// </summary>
		public Int32 Due;

        /// <summary>
        /// Currently in open orders 
        /// </summary>
		public Int32 InOrders;

        /// <summary>
        /// StockLevel - InOrders 
        /// </summary>
		public Int32 Available;

        /// <summary>
        /// if( Quantity == 0 )
        ///     dbo.StockItem.PurchasePrice
        /// Else
        /// CurrentStockValue / Quantity 
        /// </summary>
		public Double UnitCost;

        /// <summary>
        /// Product SKU 
        /// </summary>
		public String SKU;

        /// <summary>
        /// If level is auto adjusted 
        /// </summary>
		public Boolean AutoAdjust;

        /// <summary>
        /// Last time stock level was adjusted 
        /// </summary>
		public DateTime LastUpdateDate;

        /// <summary>
        /// Name of last update operation 
        /// </summary>
		public String LastUpdateOperation;

        /// <summary>
        /// dbo.StockLevel.rowid 
        /// </summary>
		public Guid rowid;

        /// <summary>
        /// dbo.StockLevel.PendingUpdate 
        /// </summary>
		public Boolean PendingUpdate;

		public Guid StockItemId;
	} 
}