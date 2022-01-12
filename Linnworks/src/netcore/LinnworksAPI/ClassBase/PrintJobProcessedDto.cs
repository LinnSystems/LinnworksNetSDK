using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PrintJobProcessedDto
	{
        /// <summary>
        /// List of order ids that have been processed 
        /// </summary>
		public List<Guid> Ids { get; set; }

        /// <summary>
        /// Template type of the orders 
        /// </summary>
		public String TemplateType { get; set; }

        /// <summary>
        /// An Error message, if applicable 
        /// </summary>
		public String Error { get; set; }

        /// <summary>
        /// Whether this request has errored 
        /// </summary>
		public Boolean IsError { get; set; }
	} 
}