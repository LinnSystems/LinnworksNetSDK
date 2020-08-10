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
		public InventoryStockLocation Location { get; set; }

        /// <summary>
        /// Stock level 
        /// </summary>
		public Int32 StockLevel { get; set; }

        /// <summary>
        /// Stock value 
        /// </summary>
		public Double StockValue { get; set; }

        /// <summary>
        /// Minimum level 
        /// </summary>
		public Int32 MinimumLevel { get; set; }

        /// <summary>
        /// Currently in open orders 
        /// </summary>
		public Int32 InOrderBook { get; set; }

        /// <summary>
        /// Due to come in purchase orders 
        /// </summary>
		public Int32 Due { get; set; }

        /// <summary>
        /// Stock Item Just In Time (JIT) status 
        /// </summary>
		public Boolean JIT { get; set; }

        /// <summary>
        /// Currently in open orders 
        /// </summary>
		public Int32 InOrders { get; set; }

        /// <summary>
        /// StockLevel - InOrders 
        /// </summary>
		public Int32 Available { get; set; }

        /// <summary>
        /// if( Quantity == 0 )
        ///     dbo.StockItem.PurchasePrice
        /// Else
        /// CurrentStockValue / Quantity 
        /// </summary>
		public Double UnitCost { get; set; }

        /// <summary>
        /// Product SKU 
        /// </summary>
		public String SKU { get; set; }

        /// <summary>
        /// If level is auto adjusted 
        /// </summary>
		public Boolean AutoAdjust { get; set; }

        /// <summary>
        /// Last time stock level was adjusted 
        /// </summary>
		public DateTime LastUpdateDate { get; set; }

        /// <summary>
        /// Name of last update operation 
        /// </summary>
		public String LastUpdateOperation { get; set; }

        /// <summary>
        /// dbo.StockLevel.rowid 
        /// </summary>
		public Guid rowid { get; set; }

        /// <summary>
        /// dbo.StockLevel.PendingUpdate 
        /// </summary>
		public Boolean PendingUpdate { get; set; }

        /// <summary>
        /// Stock item purchase price. It's used to calculate UnitCost 
        /// </summary>
		public Double StockItemPurchasePrice { get; set; }

		public Guid StockItemId { get; set; }

		public Int32 StockItemIntId { get; set; }
	} 
}