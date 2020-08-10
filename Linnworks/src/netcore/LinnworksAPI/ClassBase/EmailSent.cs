using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class EmailSent
	{
		public String AttachmentUrl { get; set; }

		public Int32 pkEmailId { get; set; }

		public String Recipient { get; set; }

		public DateTime SendDate { get; set; }

		public String Subject { get; set; }

		public String UserName { get; set; }
	} 
}