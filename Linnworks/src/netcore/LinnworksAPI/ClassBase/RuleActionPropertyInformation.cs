using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Information about an action property. 
    /// </summary>
    public class RuleActionPropertyInformation : LinnObject
	{
        /// <summary>
        /// The display name for the action property 
        /// </summary>
		public String DisplayName { get; set; }

        /// <summary>
        /// An identifier used for the property 
        /// </summary>
		public String Key { get; set; }

        /// <summary>
        /// How the frontend allows inputting for this property 
        /// </summary>
		public String DisplayType { get; set; }

        /// <summary>
        /// Can the user edit this property? 
        /// </summary>
		public Boolean Editable { get; set; }

        /// <summary>
        /// The datatype for the property; frontend for validation purposes 
        /// </summary>
		public FieldType FieldType { get; set; }

        /// <summary>
        /// A subheading used within grid header or underneath the property name if not in a grid. 
        /// </summary>
		public String SubHeading { get; set; }

        /// <summary>
        /// A tooltip to display next to the header 
        /// </summary>
		public String Tooltip { get; set; }
	} 
}