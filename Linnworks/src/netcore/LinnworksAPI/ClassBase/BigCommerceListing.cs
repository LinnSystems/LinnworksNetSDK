using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BigCommerceListing : LinnObject
	{
		public Byte Adjustments { get; set; }

		public Double Width { get; set; }

		public Double Height { get; set; }

		public Double Depth { get; set; }

		public List<BigCommerceConfigAttributes> Attributes { get; set; }

		public List<VarAttribute> VarAttributes { get; set; }

		public List<BigCommerceAssignedProducts> Children { get; set; }

		public List<BigCommerceAssignedProducts> OldChildren { get; set; }

		public AssignedOptionSet OptionSet { get; set; }

		public List<BigCommerceImageData> Images { get; set; }

		public Int32 Version { get; set; }

		public Guid ListingId { get; set; }

		public Guid TemplateId { get; set; }

		public Guid InventoryItemId { get; set; }

		public Guid ConfigId { get; set; }

		public String UsedConfigName { get; set; }

		public Int32 ProductId { get; set; }

		public Boolean UpdateConfig { get; set; }

		public BaseListingType Type { get; set; }

		public String ListingURL { get; set; }

		public String Name { get; set; }

		public String Description { get; set; }

		public String ShortDescription { get; set; }

		public String SKU { get; set; }

		public String Barcode { get; set; }

		public String TitleSource { get; set; }

		public Double Price { get; set; }

		public Double Weight { get; set; }

		public Boolean ShowListing { get; set; }

		public Boolean ManageStock { get; set; }

		public Int32 Quantity { get; set; }

		public Boolean IsReadOnly { get; set; }

		public List<ConfigCategory> Categories { get; set; }

		public Boolean HasCollisions { get; set; }

		public Boolean UseMainItemImages { get; set; }

		public ListStatus Status { get; set; }

		public String Site { get; set; }

		public Boolean IsErrorMsg { get; set; }

		public List<BigCommerceCustomField> CustomFields { get; set; }
	} 
}