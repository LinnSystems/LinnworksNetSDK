using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class JobAttachment
	{
		public Int32 AttachmentId;

		public Int32 JobId;

		public AttachmentType Type;

		public String URL;

		public DateTime? PrintedDate;

		public String User;
	} 
}