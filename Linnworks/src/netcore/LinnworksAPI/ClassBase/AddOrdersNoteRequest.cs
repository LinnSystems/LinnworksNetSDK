using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AddOrdersNoteRequest : LinnObject
	{
        /// <summary>
        /// List of order Ids 
        /// </summary>
		public IEnumerable<Guid> OrderIds { get; set; }

        /// <summary>
        /// Note text 
        /// </summary>
		public String NoteText { get; set; }

        /// <summary>
        /// Specifies if the note should be internal to the system, or should be displayed on the invoice 
        /// </summary>
		public Boolean IsInternal { get; set; }

        /// <summary>
        /// Specifies if the note should pop up during order processing or not 
        /// </summary>
		public Boolean IsProcessingNote { get; set; }
	} 
}