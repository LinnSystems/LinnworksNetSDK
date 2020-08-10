using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Response class for GetPrintAttachment 
    /// </summary>
    public class GetPrintAttachmentResponse
	{
        /// <summary>
        /// If the print is pdf attachment this field will be True. If print went to virtual printer the field is false and PDFURL is null 
        /// </summary>
		public Boolean IsPDFAvailable { get; set; }

        /// <summary>
        /// URL of the PDF 
        /// </summary>
		public String PDFURL { get; set; }
	} 
}