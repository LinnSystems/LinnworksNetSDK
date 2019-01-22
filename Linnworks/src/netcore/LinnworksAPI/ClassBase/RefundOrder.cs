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
		public Guid pkOrderID;

        /// <summary>
        /// Linnworks order ID 
        /// </summary>
		public Int32 nOrderId;

        /// <summary>
        /// Customer name 
        /// </summary>
		public String cFullName;

        /// <summary>
        /// ChannelName/Source (e.g. AMAZON) 
        /// </summary>
		public String Source;

		public String SubSource;

        /// <summary>
        /// Refund amount 
        /// </summary>
		public Double Amount;

        /// <summary>
        /// Refund URL 
        /// </summary>
		public String IssueRefundUrl;

        /// <summary>
        /// Refund currency 
        /// </summary>
		public String cCurrency;

        /// <summary>
        /// Order reference number 
        /// </summary>
		public String ReferenceNum;

        /// <summary>
        /// Order secondary reference number 
        /// </summary>
		public String SecondaryReference;

        /// <summary>
        /// Refund reference number 
        /// </summary>
		public String RefundReference;

        /// <summary>
        /// Date when refund were made 
        /// </summary>
		public DateTime RefundDate;

		public Double SubTotal;

		public Double Total;

		public Double TaxRate;
	} 
}