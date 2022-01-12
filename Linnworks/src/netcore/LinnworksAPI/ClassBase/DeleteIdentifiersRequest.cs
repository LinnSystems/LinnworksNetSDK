using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DeleteIdentifiersRequest
	{
        /// <summary>
        /// Tag of the order identifier to delete. E.g. CUSTOM_PRINT. It is not possible to delete a system tag such as AMAZON_PRIME 
        /// </summary>
		public String Tag { get; set; }
	} 
}