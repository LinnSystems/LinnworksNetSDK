using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CreatePDFResult
	{
		public List<PrintError> KeyedError { get; set; }

        /// <summary>
        /// URL to PDF file 
        /// </summary>
		public String URL { get; set; }

        /// <summary>
        /// List of processed order or item IDs 
        /// </summary>
		public List<Guid> IdsProcessed { get; set; }

		public Dictionary<String,List<Guid>> ProcessedIds { get; set; }

		public Int32 PageCount { get; set; }

        /// <summary>
        /// List of OrderId / Error message 
        /// </summary>
		public List<String> PrintErrors { get; set; }
	} 
}