using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GenerateAdhocEmailResponse
	{
        /// <summary>
        /// Send custom emails completed 
        /// </summary>
		public Boolean isComplete { get; set; }

        /// <summary>
        /// List of failed recipients 
        /// </summary>
		public List<String> FailedRecipients { get; set; }
	} 
}