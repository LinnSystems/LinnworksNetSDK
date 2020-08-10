using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class EbayListingAudit
	{
		public String ItemNumber;

		public String ActionType;

		public String ActionText;

		public Guid AffectivefkStockItemId;

		public Guid ListId;

		public DateTime ActionDateTime;

		public Int32 SetQuantity;

		public Double SetPrice;

		public Boolean IsError;

		public String SKU;
	} 
}