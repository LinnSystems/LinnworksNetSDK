using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Order item object 
    /// </summary>
    public class OrderItem
	{
        /// <summary>
        /// Stock Item ID 
        /// </summary>
		public Guid ItemId { get; set; }

        /// <summary>
        /// Item number as on channel 
        /// </summary>
		public String ItemNumber { get; set; }

        /// <summary>
        /// Product SKU 
        /// </summary>
		public String SKU { get; set; }

        /// <summary>
        /// Item source / channel name 
        /// </summary>
		public String ItemSource { get; set; }

        /// <summary>
        /// Item title 
        /// </summary>
		public String Title { get; set; }

        /// <summary>
        /// Quantity 
        /// </summary>
		public Int32 Quantity { get; set; }

        /// <summary>
        /// Product category 
        /// </summary>
		public String CategoryName { get; set; }

        /// <summary>
        /// Composite availability 
        /// </summary>
		public Int32? CompositeAvailablity { get; set; }

        /// <summary>
        /// If stock level specified 
        /// </summary>
		public Boolean StockLevelsSpecified { get; set; }

        /// <summary>
        /// Level due in purchase orders 
        /// </summary>
		public Int32 OnOrder { get; set; }

        /// <summary>
        /// Purchase order bound to this item 
        /// </summary>
		public OrderItemOnOrder OnPurchaseOrder { get; set; }

        /// <summary>
        /// Quantity currently in open orders 
        /// </summary>
		public Int32? InOrderBook { get; set; }

        /// <summary>
        /// Current stock level 
        /// </summary>
		public Int32 Level { get; set; }

        /// <summary>
        /// Minimum level 
        /// </summary>
		public Int32? MinimumLevel { get; set; }

        /// <summary>
        /// Currently available stock level (Level-InOrderBook) 
        /// </summary>
		public Int32 AvailableStock { get; set; }

        /// <summary>
        /// Unit price 
        /// </summary>
		public Double PricePerUnit { get; set; }

        /// <summary>
        /// Unit cost 
        /// </summary>
		public Double UnitCost { get; set; }

        /// <summary>
        /// Despatch stock unit cost 
        /// </summary>
		public Double DespatchStockUnitCost { get; set; }

        /// <summary>
        /// Percentage (0%, 10%, 20%, etc...) 
        /// </summary>
		public Double Discount { get; set; }

        /// <summary>
        /// Actual tax value on an item 
        /// </summary>
		public Double Tax { get; set; }

        /// <summary>
        /// Tax rate 
        /// </summary>
		public Double TaxRate { get; set; }

        /// <summary>
        /// Total item cost (exc tax) 
        /// </summary>
		public Double Cost { get; set; }

        /// <summary>
        /// Total item cost (inc tax) 
        /// </summary>
		public Double CostIncTax { get; set; }

        /// <summary>
        /// List of order items 
        /// </summary>
		public List<OrderItem> CompositeSubItems { get; set; }

        /// <summary>
        /// if item is a service 
        /// </summary>
		public Boolean IsService { get; set; }

        /// <summary>
        /// Sales Tax 
        /// </summary>
		public Double SalesTax { get; set; }

        /// <summary>
        /// If tax is included in a cost 
        /// </summary>
		public Boolean TaxCostInclusive { get; set; }

        /// <summary>
        /// If order is partly shipped 
        /// </summary>
		public Boolean PartShipped { get; set; }

        /// <summary>
        /// Order weight 
        /// </summary>
		public Double Weight { get; set; }

        /// <summary>
        /// Product barcode 
        /// </summary>
		public String BarcodeNumber { get; set; }

        /// <summary>
        /// Market 
        /// </summary>
		public Int32 Market { get; set; }

        /// <summary>
        /// Channel product SKU 
        /// </summary>
		public String ChannelSKU { get; set; }

        /// <summary>
        /// Channel product title 
        /// </summary>
		public String ChannelTitle { get; set; }

		public Double DiscountValue { get; set; }

        /// <summary>
        /// If item got an image 
        /// </summary>
		public Boolean HasImage { get; set; }

        /// <summary>
        /// Image ID 
        /// </summary>
		public Guid? ImageId { get; set; }

        /// <summary>
        /// List of order item options 
        /// </summary>
		public List<OrderItemOption> AdditionalInfo { get; set; }

        /// <summary>
        /// Stock level indicator 
        /// </summary>
		public Int32 StockLevelIndicator { get; set; }

        /// <summary>
        /// If batch number scan required 
        /// </summary>
		public Double ShippingCost { get; set; }

        /// <summary>
        /// ShippingCost 
        /// </summary>
		public Int32 PartShippedQty { get; set; }

        /// <summary>
        /// PartShippedQty 
        /// </summary>
		public String ItemName { get; set; }

        /// <summary>
        /// ItemName 
        /// </summary>
		public Boolean BatchNumberScanRequired { get; set; }

        /// <summary>
        /// If serial number scan required 
        /// </summary>
		public Boolean SerialNumberScanRequired { get; set; }

        /// <summary>
        /// Binrack location 
        /// </summary>
		public String BinRack { get; set; }

        /// <summary>
        /// List of BinRacks used for OrderItem 
        /// </summary>
		public List<OrderItemBinRack> BinRacks { get; set; }

        /// <summary>
        /// Identifies whether the item has a sell by date or other defined order in which inventory is to be sold 
        /// </summary>
		public Int32 InventoryTrackingType { get; set; }

        /// <summary>
        /// If item has batches 
        /// </summary>
		public Boolean isBatchedStockItem { get; set; }

		public Boolean IsWarehouseManaged { get; set; }

		public Boolean IsUnlinked { get; set; }

		public Int32 StockItemIntId { get; set; }

		public StockItemBoxConfiguration[] Boxes { get; set; }

		public Guid RowId { get; set; }

		public Guid OrderId { get; set; }

		public Guid StockItemId { get; set; }
	} 
}