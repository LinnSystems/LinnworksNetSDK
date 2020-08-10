using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Order General Info class 
    /// </summary>
    public class OrderGeneralInfo
	{
        /// <summary>
        /// Order Status (0 = UNPAID, 1 = PAID,2 = RETURN,3 = PENDING,4 = RESEND) 
        /// </summary>
		public Int32 Status { get; set; }

        /// <summary>
        /// Is label printed 
        /// </summary>
		public Boolean LabelPrinted { get; set; }

        /// <summary>
        /// Is there a label error 
        /// </summary>
		public String LabelError { get; set; }

        /// <summary>
        /// Is invoice printed 
        /// </summary>
		public Boolean InvoicePrinted { get; set; }

        /// <summary>
        /// Is pick list printed 
        /// </summary>
		public Boolean PickListPrinted { get; set; }

        /// <summary>
        /// If rules engine rule ran on an order 
        /// </summary>
		public Boolean IsRuleRun { get; set; }

        /// <summary>
        /// Quantity of order notes 
        /// </summary>
		public Int32 Notes { get; set; }

        /// <summary>
        /// If order partly shipped 
        /// </summary>
		public Boolean PartShipped { get; set; }

        /// <summary>
        /// Order marker (0 = NOT TAG,1 = Tag 1,2 = Tag 2,3 = Tag 3,4 = Tag 4,5 = Tag 5,6 = Tag 6,7 = Parked) 
        /// </summary>
		public Byte? Marker { get; set; }

        /// <summary>
        /// Is the order parked? 
        /// </summary>
		public Boolean IsParked { get; set; }

        /// <summary>
        /// Order identifiers. [Prime | Scheduled] 
        /// </summary>
		public List<Identifier> Identifiers { get; set; }

        /// <summary>
        /// Order reference number (Channel defined) 
        /// </summary>
		public String ReferenceNum { get; set; }

        /// <summary>
        /// An additional reference number for the orderr (Used by some channels) 
        /// </summary>
		public String SecondaryReference { get; set; }

        /// <summary>
        /// This is an additional reference number from the sales channel, typically used by eBay 
        /// </summary>
		public String ExternalReferenceNum { get; set; }

        /// <summary>
        /// The date and time at which the order was placed on the sales channel 
        /// </summary>
		public DateTime ReceivedDate { get; set; }

        /// <summary>
        /// Order ChannelName/Source (e.g. EBAY) 
        /// </summary>
		public String Source { get; set; }

        /// <summary>
        /// Order Subsource (e.g. EBAY1) 
        /// </summary>
		public String SubSource { get; set; }

        /// <summary>
        /// SiteCode used to differentiate between different sites from a single channel (eg. Amazon UK, Amazon US, Amazon FR...) 
        /// </summary>
		public String SiteCode { get; set; }

        /// <summary>
        /// This shows whether the order has been marked as on hold, for processed orders if the order has been cancelled OnHold = 1 
        /// </summary>
		public Boolean HoldOrCancel { get; set; }

        /// <summary>
        /// Despatch by Date 
        /// </summary>
		public DateTime DespatchByDate { get; set; }

        /// <summary>
        /// Scheduled delivery dates. Take priority over despatch by date 
        /// </summary>
		public ScheduledDelivery ScheduledDelivery { get; set; }

		public Boolean HasScheduledDelivery { get; set; }

        /// <summary>
        /// Order location ID 
        /// </summary>
		public Guid Location { get; set; }

        /// <summary>
        /// Quantity of order items 
        /// </summary>
		public Int32 NumItems { get; set; }

        /// <summary>
        /// All related Pickwave Ids 
        /// </summary>
		public List<Int32> PickwaveIds { get; set; }

		public StockAllocationType? StockAllocationType { get; set; }
	} 
}