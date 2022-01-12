using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Identifier
	{
        /// <summary>
        /// Internal identifier id. Use to update image and name. 
        /// </summary>
		public Int32 IdentifierId { get; set; }

        /// <summary>
        /// Is the tag user or system defined? 
        /// </summary>
		public Boolean IsCustom { get; set; }

		public Guid ImageId { get; set; }

		public String ImageUrl { get; set; }

		public String Tag { get; set; }

		public String Name { get; set; }
	} 
}