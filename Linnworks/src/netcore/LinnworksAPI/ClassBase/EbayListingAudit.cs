using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class EbayListingAudit
	{
		public String ItemNumber { get; set; }

		public String ActionType { get; set; }

		public String ActionText { get; set; }

		public Guid AffectivefkStockItemId { get; set; }

		public Guid ListId { get; set; }

		public DateTime ActionDateTime { get; set; }

		public Int32 SetQuantity { get; set; }

		public Double SetPrice { get; set; }

		public Boolean IsError { get; set; }

		public String SKU { get; set; }
	} 
}