using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ProcessedOrderNote
	{
		public Guid pkOrderNoteId { get; set; }

		public Guid fkOrderId { get; set; }

		public String Note { get; set; }

		public DateTime NoteEntryDate { get; set; }

		public String NoteUserName { get; set; }

		public Boolean? Internal { get; set; }

		public Byte? NoteTypeId { get; set; }
	} 
}