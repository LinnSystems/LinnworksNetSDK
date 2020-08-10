using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Request class for print attachmment 
    /// </summary>
    public class GetPrintAttachmentRequest
	{
        /// <summary>
        /// Job id for which you would like to get print the attachment 
        /// </summary>
		public Int32 JobId { get; set; }

        /// <summary>
        /// Attachment/print id 
        /// </summary>
		public Int32 AttachmentId { get; set; }
	} 
}