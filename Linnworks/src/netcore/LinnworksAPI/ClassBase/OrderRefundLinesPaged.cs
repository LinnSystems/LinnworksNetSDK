using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderRefundLinesPaged
	{
		public Int32 Page;

		public Int32 TotalReferences;

		public Int32 ReferencesPerPage;

		public Int32 ActualItemsPerPage;

		public List<OrderRefundLine> OrderRefundLines;
	} 
}