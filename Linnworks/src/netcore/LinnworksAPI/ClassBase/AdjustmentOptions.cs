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
		public Boolean Title;

        /// <summary>
        /// Product price 
        /// </summary>
		public Boolean Price;

        /// <summary>
        /// Product description 
        /// </summary>
		public Boolean Description;

        /// <summary>
        /// If product extended properties needs to be added 
        /// </summary>
		public Boolean AddExtendedProperties;

        /// <summary>
        /// Revise product extended properties 
        /// </summary>
		public Boolean ReviseExtendedProperties;

        /// <summary>
        /// Update product images 
        /// </summary>
		public Boolean UpdateImages;

        /// <summary>
        /// Product variation attributes 
        /// </summary>
		public Boolean VariationAttributes;

        /// <summary>
        /// Reload all images for the template 
        /// </summary>
		public Boolean ReloadAllImages;
	} 
}