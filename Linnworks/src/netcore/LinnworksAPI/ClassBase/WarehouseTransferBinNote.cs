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
		public Guid PkTransferBinNoteId;

        /// <summary>
        /// User who created note 
        /// </summary>
		public String NoteUser;

        /// <summary>
        /// Note text 
        /// </summary>
		public String Note;

        /// <summary>
        /// When bin note was added 
        /// </summary>
		public DateTime NoteDateTime;

        /// <summary>
        /// If bin note is readable 
        /// </summary>
		public Boolean NoteRead;

        /// <summary>
        /// Bin ID 
        /// </summary>
		public Guid PkBinId;
	} 
}