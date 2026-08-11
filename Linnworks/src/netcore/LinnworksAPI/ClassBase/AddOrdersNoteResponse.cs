using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AddOrdersNoteResponse : LinnObject
	{
		public List<OrderNoteDto> OrderNotes { get; set; }
	} 
}