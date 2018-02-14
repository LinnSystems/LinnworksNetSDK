using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GenerateFreeTextEmailResponse
	{
        /// <summary>
        /// Send custom emails completed 
        /// </summary>
		public Boolean isComplete;

        /// <summary>
        /// List of failed recipients 
        /// </summary>
		public List<String> FailedRecipients;
	} 
}