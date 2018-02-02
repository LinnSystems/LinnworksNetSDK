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
		public Guid OrderNoteId;

        /// <summary>
        /// Order Id 
        /// </summary>
		public Guid OrderId;

        /// <summary>
        /// Date and time when note was added 
        /// </summary>
		public DateTime NoteDate;

        /// <summary>
        /// order note type (Internal or External) 
        /// </summary>
		public Boolean Internal;

        /// <summary>
        /// Note's text 
        /// </summary>
		public String Note;

        /// <summary>
        /// User that created note 
        /// </summary>
		public String CreatedBy;

		public Byte? NoteTypeId;
	} 
}