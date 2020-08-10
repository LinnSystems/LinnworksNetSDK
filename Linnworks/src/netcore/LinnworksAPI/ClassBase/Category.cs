using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Category
	{
        /// <summary>
        /// Category ID 
        /// </summary>
		public Guid CategoryId { get; set; }

        /// <summary>
        /// Category name 
        /// </summary>
		public String CategoryName { get; set; }

        /// <summary>
        /// Structure Category Id to which this product category is assigned to, nullable if not available 
        /// </summary>
		public Int32? StructureCategoryId { get; set; }

		public Int32? ProductCategoryId { get; set; }
	} 
}