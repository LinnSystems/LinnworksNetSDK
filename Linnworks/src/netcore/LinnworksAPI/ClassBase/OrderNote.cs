using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderNote
	{
        /// <summary>
        /// Order note ID 
        /// </summary>
		public Guid OrderNoteId { get; set; }

        /// <summary>
        /// Order Id 
        /// </summary>
		public Guid OrderId { get; set; }

        /// <summary>
        /// Date and time when note was added 
        /// </summary>
		public DateTime NoteDate { get; set; }

        /// <summary>
        /// order note type (Internal or External) 
        /// </summary>
		public Boolean Internal { get; set; }

        /// <summary>
        /// Note's text 
        /// </summary>
		public String Note { get; set; }

        /// <summary>
        /// User that created note 
        /// </summary>
		public String CreatedBy { get; set; }

		public Byte? NoteTypeId { get; set; }
	} 
}