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
		public Int32 Status;

        /// <summary>
        /// Is label printed 
        /// </summary>
		public Boolean LabelPrinted;

        /// <summary>
        /// Is there a label error 
        /// </summary>
		public String LabelError;

        /// <summary>
        /// Is invoice printed 
        /// </summary>
		public Boolean InvoicePrinted;

        /// <summary>
        /// Is pick list printed 
        /// </summary>
		public Boolean PickListPrinted;

        /// <summary>
        /// If rules engine rule ran on an order 
        /// </summary>
		public Boolean IsRuleRun;

        /// <summary>
        /// Quantity of order notes 
        /// </summary>
		public Int32 Notes;

        /// <summary>
        /// If order partly shipped 
        /// </summary>
		public Boolean PartShipped;

        /// <summary>
        /// Order marker (0 = NOT TAG,1 = Tag 1,2 = Tag 2,3 = Tag 3,4 = Tag 4,5 = Tag 5,6 = Tag 6,7 = Parked) 
        /// </summary>
		public Byte? Marker;

		public Boolean IsParked;

		public List<OrderIdentifier> Identifiers;

        /// <summary>
        /// Order reference number (Channel defined) 
        /// </summary>
		public String ReferenceNum;

        /// <summary>
        /// An additional reference number for the orderr (Used by some channels) 
        /// </summary>
		public String SecondaryReference;

        /// <summary>
        /// This is an additional reference number from the sales channel, typically used by eBay 
        /// </summary>
		public String ExternalReferenceNum;

        /// <summary>
        /// The date and time at which the order was placed on the sales channel 
        /// </summary>
		public DateTime ReceivedDate;

        /// <summary>
        /// Order ChannelName/Source (e.g. EBAY) 
        /// </summary>
		public String Source;

        /// <summary>
        /// Order Subsource (e.g. EBAY1) 
        /// </summary>
		public String SubSource;

        /// <summary>
        /// SiteCode used to differentiate between different sites from a single channel (eg. Amazon UK, Amazon US, Amazon FR...) 
        /// </summary>
		public String SiteCode;

        /// <summary>
        /// This shows whether the order has been marked as on hold, for processed orders if the order has been cancelled OnHold = 1 
        /// </summary>
		public Boolean HoldOrCancel;

        /// <summary>
        /// Despatch by Date 
        /// </summary>
		public DateTime DespatchByDate;

		public ScheduledDelivery ScheduledDelivery;

		public Boolean HasScheduledDelivery;

        /// <summary>
        /// Order location ID 
        /// </summary>
		public Guid Location;

        /// <summary>
        /// Quantity of order items 
        /// </summary>
		public Int32 NumItems;

		public IRulesEngineHelper RulesEngine;
	} 
}