using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class eBayItem
	{
		public String SKU { get; set; }

		public String ItemNumber { get; set; }

		public String MappedBy { get; set; }

		public Boolean RelistPending { get; set; }

		public String ChannelReferenceId { get; set; }

		public Boolean StrickenOff { get; set; }

		public Guid StockItemId { get; set; }

		public DateTime StartTime { get; set; }

		public DateTime EndTime { get; set; }

		public DateTime StrikeOffDate { get; set; }

		public String StrikeReason { get; set; }

		public String LinkedWith { get; set; }

		public Boolean IsVariation { get; set; }

		public Boolean FixedPrice { get; set; }

		public String ReslistedFrom { get; set; }

		public Guid ListId { get; set; }

		public Double ListingPrice { get; set; }

		public List<eBayItem> VariationItems { get; set; }

		public Boolean IsGTC { get; set; }

		public Boolean IsActive { get; set; }

		public Guid ChannelSKURowId { get; set; }

		public Guid LinkedItemId { get; set; }

		public Boolean IgnoreSync { get; set; }

		public String Title { get; set; }

		public String LinkedItemSku { get; set; }

		public String LinkedItemTitle { get; set; }

		public Int32 MaxListedQuantity { get; set; }

		public Int32 EndWhenStock { get; set; }

		public Double StockPercentage { get; set; }

		public Int32 Quantity { get; set; }

		public Boolean IsLinked { get; set; }

		public Boolean IsSuggestedToLink { get; set; }

		public Boolean IsMatchByTitle { get; set; }

		public Int64 TotalRows { get; set; }
	} 
}