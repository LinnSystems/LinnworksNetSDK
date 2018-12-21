using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GenerateFreeTextEmailRequest
	{
        /// <summary>
        /// List of ids to send template for 
        /// </summary>
		public List<Guid> ids;

        /// <summary>
        /// Subject of email 
        /// </summary>
		public String subject;

        /// <summary>
        /// Body of email 
        /// </summary>
		public String body;

		public String templateType;
	} 
}