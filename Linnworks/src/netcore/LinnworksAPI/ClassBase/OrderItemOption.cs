using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderItemOption
	{
        /// <summary>
        /// Option ID 
        /// </summary>
		public Guid pkOptionId { get; set; }

        /// <summary>
        /// Option property 
        /// </summary>
		public String Property { get; set; }

        /// <summary>
        /// Value of the option 
        /// </summary>
		public String Value { get; set; }
	} 
}