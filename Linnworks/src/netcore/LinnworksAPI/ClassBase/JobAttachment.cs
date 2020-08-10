using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class JobAttachment
	{
		public Int32 AttachmentId { get; set; }

		public Int32 JobId { get; set; }

		public AttachmentType Type { get; set; }

		public String URL { get; set; }

		public DateTime? PrintedDate { get; set; }

		public String User { get; set; }
	} 
}