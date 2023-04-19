using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Get_EmailsSentResponse : LinnObject
	{
		public List<EmailSent> Items { get; set; }
	} 
}