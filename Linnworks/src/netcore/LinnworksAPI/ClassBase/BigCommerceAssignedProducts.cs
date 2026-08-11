using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BigCommerceAssignedProducts : LinnObject
	{
		public Guid StockItemId { get; set; }

		public Guid ChildId { get; set; }

		public Int32 SkuId { get; set; }

		public String SKU { get; set; }

		public String UPC { get; set; }

		public String MPN { get; set; }

		public String GTIN { get; set; }

		public String Name { get; set; }

		public Double Price { get; set; }

		public Boolean ManageStock { get; set; }

		public Int32 CollisionNumber { get; set; }

		public ListStatus Status { get; set; }

		public Int32 Quantity { get; set; }

		public Double Weight { get; set; }

		public Double Depth { get; set; }

		public Double Height { get; set; }

		public Double Width { get; set; }

		public Boolean InStockChannel { get; set; }

		public String ProductImageURL { get; set; }

		public List<ChildOption> OptionsValues { get; set; }

		public Double? CostPrice { get; set; }

		public Double? SalePrice { get; set; }

		public Double? RetailPrice { get; set; }
	} 
}