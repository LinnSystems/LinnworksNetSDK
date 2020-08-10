using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class WarehouseTransferItemNote
	{
        /// <summary>
        /// Stock item ID (unique identifier) 
        /// </summary>
		public Guid PkTransferItemNoteId { get; set; }

        /// <summary>
        /// User who added note 
        /// </summary>
		public String NoteUser { get; set; }

        /// <summary>
        /// Note text 
        /// </summary>
		public String Note { get; set; }

        /// <summary>
        /// When note was added 
        /// </summary>
		public DateTime NoteDateTime { get; set; }

        /// <summary>
        /// If note is readable 
        /// </summary>
		public Boolean NoteRead { get; set; }

        /// <summary>
        /// Bin ID 
        /// </summary>
		public Guid FkBinId { get; set; }

        /// <summary>
        /// Transfer ID 
        /// </summary>
		public Guid PkTransferItemId { get; set; }
	} 
}