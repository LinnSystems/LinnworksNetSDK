using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CreatePDFResult
	{
		public List<PrintError> KeyedError;

        /// <summary>
        /// URL to PDF file 
        /// </summary>
		public String URL;

        /// <summary>
        /// List of processed order or item IDs 
        /// </summary>
		public List<Guid> IdsProcessed;

		public Dictionary<String,List<Guid>> ProcessedIds;

        /// <summary>
        /// List of OrderId / Error message 
        /// </summary>
		public List<String> PrintErrors;
	} 
}