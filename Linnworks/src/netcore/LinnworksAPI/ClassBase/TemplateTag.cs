using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Objects that define an entity field or property mapping 
    /// </summary>
    public class TemplateTag
	{
        /// <summary>
        /// Tag which is inserted into the template as [{Tag}] 
        /// </summary>
		public String Tag { get; set; }

        /// <summary>
        /// Human readable name of the tag 
        /// </summary>
		public String Name { get; set; }

        /// <summary>
        /// Defines how the tag will be rendered in the menu 
        /// </summary>
		public String SelectionPath { get; set; }

        /// <summary>
        /// Identifies whether the item is a list (FOREACH loop) 
        /// </summary>
		public Boolean IsList { get; set; }
	} 
}