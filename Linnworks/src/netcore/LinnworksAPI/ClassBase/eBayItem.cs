using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class eBayItem
	{
		public String SKU;

		public String ItemNumber;

		public String MappedBy;

		public Boolean RelistPending;

		public String ChannelReferenceId;

		public Boolean StrickenOff;

		public Guid StockItemId;

		public DateTime StartTime;

		public DateTime EndTime;

		public DateTime StrikeOffDate;

		public String StrikeReason;

		public String LinkedWith;

		public Boolean IsVariation;

		public Boolean FixedPrice;

		public String ReslistedFrom;

		public Guid ListId;

		public Double ListingPrice;

		public List<eBayItem> VariationItems;

		public Boolean IsGTC;

		public Boolean IsActive;

		public Guid ChannelSKURowId;

		public Guid LinkedItemId;

		public Boolean IgnoreSync;

		public String Title;

		public String LinkedItemSku;

		public String LinkedItemTitle;

		public Int32 MaxListedQuantity;

		public Int32 EndWhenStock;

		public Double StockPercentage;

		public Int32 Quantity;

		public Boolean IsLinked;

		public Boolean IsSuggestedToLink;

		public Boolean IsMatchByTitle;

		public Int64 TotalRows;
	} 
}