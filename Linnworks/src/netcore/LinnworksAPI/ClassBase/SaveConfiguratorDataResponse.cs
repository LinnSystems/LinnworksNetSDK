using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class SaveConfiguratorDataResponse : LinnObject
	{
		public Boolean IsSaved { get; set; }

        /// <summary>
        /// Whether this particular configurator data is valid to send to channel. 
        /// </summary>
		public IValidationResults ValidationResults { get; set; }
	} 
}