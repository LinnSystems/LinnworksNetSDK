using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BaseSettingsRequest
	{
        /// <summary>
        /// The installation ID for the user who installed this application. For public settings, this can be left null, and will be auto-populated 
        /// </summary>
		public Guid? Key { get; set; }

        /// <summary>
        /// Defines whether to work with the public storage for a user, or for the private storage for your specific application 
        /// </summary>
		public Boolean IsPublic { get; set; }
	} 
}