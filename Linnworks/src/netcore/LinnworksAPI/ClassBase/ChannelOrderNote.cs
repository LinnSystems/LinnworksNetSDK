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
		public String Note;

        /// <summary>
        /// Creation Date of the note 
        /// </summary>
		public DateTime NoteEntryDate;

        /// <summary>
        /// User who added the note 
        /// </summary>
		public String NoteUserName;

        /// <summary>
        /// Declares if the note is an internal note 
        /// </summary>
		public Boolean Internal;
	} 
}