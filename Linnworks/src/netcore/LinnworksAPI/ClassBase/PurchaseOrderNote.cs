using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Purchase order note class 
    /// </summary>
    public class PurchaseOrderNote
	{
        /// <summary>
        /// Unique identifier for the purchase order note. Use this ID in Delete/Modify calls 
        /// </summary>
		public Guid pkPurchaseOrderNoteId { get; set; }

        /// <summary>
        /// Note text 
        /// </summary>
		public String Note { get; set; }

        /// <summary>
        /// Note added datetime UTC 
        /// </summary>
		public DateTime NoteDateTime { get; set; }

        /// <summary>
        /// Username of Note author 
        /// </summary>
		public String UserName { get; set; }

        /// <summary>
        /// Format the Note Date 
        /// </summary>
		public String NoteDate { get; set; }

        /// <summary>
        /// Format the Note Time 
        /// </summary>
		public String NoteTime { get; set; }
	} 
}