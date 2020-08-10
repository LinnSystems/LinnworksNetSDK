using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class RefundOrder
	{
        /// <summary>
        /// Order ID (unique order identifier) 
        /// </summary>
		public Guid pkOrderID { get; set; }

        /// <summary>
        /// Linnworks order ID 
        /// </summary>
		public Int32 nOrderId { get; set; }

        /// <summary>
        /// Customer name 
        /// </summary>
		public String cFullName { get; set; }

        /// <summary>
        /// ChannelName/Source (e.g. AMAZON) 
        /// </summary>
		public String Source { get; set; }

		public String SubSource { get; set; }

        /// <summary>
        /// Refund amount 
        /// </summary>
		public Double Amount { get; set; }

        /// <summary>
        /// Refund URL 
        /// </summary>
		public String IssueRefundUrl { get; set; }

        /// <summary>
        /// Refund currency 
        /// </summary>
		public String cCurrency { get; set; }

        /// <summary>
        /// Order reference number 
        /// </summary>
		public String ReferenceNum { get; set; }

        /// <summary>
        /// Order secondary reference number 
        /// </summary>
		public String SecondaryReference { get; set; }

        /// <summary>
        /// Refund reference number 
        /// </summary>
		public String RefundReference { get; set; }

        /// <summary>
        /// Date when refund were made 
        /// </summary>
		public DateTime RefundDate { get; set; }

		public Double SubTotal { get; set; }

		public Double Total { get; set; }

		public Double TaxRate { get; set; }
	} 
}