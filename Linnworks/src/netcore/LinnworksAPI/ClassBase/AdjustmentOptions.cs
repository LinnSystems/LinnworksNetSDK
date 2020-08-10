using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AdjustmentOptions
	{
        /// <summary>
        /// Product title 
        /// </summary>
		public Boolean Title { get; set; }

        /// <summary>
        /// Product price 
        /// </summary>
		public Boolean Price { get; set; }

        /// <summary>
        /// Product description 
        /// </summary>
		public Boolean Description { get; set; }

        /// <summary>
        /// If product extended properties needs to be added 
        /// </summary>
		public Boolean AddExtendedProperties { get; set; }

        /// <summary>
        /// Revise product extended properties 
        /// </summary>
		public Boolean ReviseExtendedProperties { get; set; }

        /// <summary>
        /// Update product images 
        /// </summary>
		public Boolean UpdateImages { get; set; }

        /// <summary>
        /// Product variation attributes 
        /// </summary>
		public Boolean VariationAttributes { get; set; }

        /// <summary>
        /// Reload all images for the template 
        /// </summary>
		public Boolean ReloadAllImages { get; set; }
	} 
}