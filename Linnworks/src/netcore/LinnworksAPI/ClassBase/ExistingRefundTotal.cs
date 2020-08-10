using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ExistingRefundTotal
	{
        /// <summary>
        /// Amount refunded 
        /// </summary>
		public Double Amount { get; set; }

        /// <summary>
        /// Total order charge 
        /// </summary>
		public Double TotalCharge { get; set; }

        /// <summary>
        /// Refundable amount 
        /// </summary>
		public Double Refundable { get; set; }
	} 
}