using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderNoteType : LinnObject
	{
		public Byte NoteTypeId { get; set; }

		public String NoteType { get; set; }
	} 
}