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
		public Guid PkTransferItemNoteId;

        /// <summary>
        /// User who added note 
        /// </summary>
		public String NoteUser;

        /// <summary>
        /// Note text 
        /// </summary>
		public String Note;

        /// <summary>
        /// When note was added 
        /// </summary>
		public DateTime NoteDateTime;

        /// <summary>
        /// If note is readable 
        /// </summary>
		public Boolean NoteRead;

        /// <summary>
        /// Bin ID 
        /// </summary>
		public Guid FkBinId;

        /// <summary>
        /// Transfer ID 
        /// </summary>
		public Guid PkTransferItemId;
	} 
}