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
		public String Tag;

        /// <summary>
        /// Human readable name of the tag 
        /// </summary>
		public String Name;

        /// <summary>
        /// Defines how the tag will be rendered in the menu 
        /// </summary>
		public String SelectionPath;

        /// <summary>
        /// Identifies whether the item is a list (FOREACH loop) 
        /// </summary>
		public Boolean IsList;
	} 
}