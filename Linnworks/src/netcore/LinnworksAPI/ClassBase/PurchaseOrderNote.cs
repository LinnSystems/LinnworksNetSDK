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
		public Guid pkPurchaseOrderNoteId;

        /// <summary>
        /// Note text 
        /// </summary>
		public String Note;

        /// <summary>
        /// Note added datetime UTC 
        /// </summary>
		public DateTime NoteDateTime;

        /// <summary>
        /// Username of Note author 
        /// </summary>
		public String UserName;

        /// <summary>
        /// Format the Note Date 
        /// </summary>
		public String NoteDate;

        /// <summary>
        /// Format the Note Time 
        /// </summary>
		public String NoteTime;
	} 
}