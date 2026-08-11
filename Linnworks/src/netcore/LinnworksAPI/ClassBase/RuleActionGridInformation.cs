using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Information required to setup a grid used to populate data for the action 
    /// </summary>
    public class RuleActionGridInformation : LinnObject
	{
        /// <summary>
        /// How are new rows added to the grid. 
        /// </summary>
		public RowAddTrigger RowAddTrigger { get; set; }

        /// <summary>
        /// Text to backup RowAddTrigger if required. 
        /// </summary>
		public String RowAddText { get; set; }

        /// <summary>
        /// Represents the columns in the grid. 
        /// </summary>
		public List<RuleActionPropertyInformation> RuleActionPropertyInformation { get; set; }
	} 
}