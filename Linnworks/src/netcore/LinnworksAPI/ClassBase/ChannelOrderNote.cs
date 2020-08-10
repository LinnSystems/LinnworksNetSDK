using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ChannelOrderNote
	{
        /// <summary>
        /// Order Note 
        /// </summary>
		public String Note { get; set; }

        /// <summary>
        /// Creation Date of the note 
        /// </summary>
		public DateTime NoteEntryDate { get; set; }

        /// <summary>
        /// User who added the note 
        /// </summary>
		public String NoteUserName { get; set; }

        /// <summary>
        /// Declares if the note is an internal note 
        /// </summary>
		public Boolean Internal { get; set; }
	} 
}