using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class WarehouseTransferBinNote
	{
        /// <summary>
        /// Transfer bin note ID 
        /// </summary>
		public Guid PkTransferBinNoteId { get; set; }

        /// <summary>
        /// User who created note 
        /// </summary>
		public String NoteUser { get; set; }

        /// <summary>
        /// Note text 
        /// </summary>
		public String Note { get; set; }

        /// <summary>
        /// When bin note was added 
        /// </summary>
		public DateTime NoteDateTime { get; set; }

        /// <summary>
        /// If bin note is readable 
        /// </summary>
		public Boolean NoteRead { get; set; }

        /// <summary>
        /// Bin ID 
        /// </summary>
		public Guid PkBinId { get; set; }
	} 
}