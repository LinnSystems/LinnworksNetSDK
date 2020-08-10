using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class WarehouseTransferNote
	{
		public Guid PkTransferNoteId { get; set; }

		public String NoteUser { get; set; }

		public String Note { get; set; }

		public DateTime NoteDateTime { get; set; }

		public Boolean NoteRead { get; set; }
	} 
}