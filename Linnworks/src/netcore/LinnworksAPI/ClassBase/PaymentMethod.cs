using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PaymentMethod
	{
        /// <summary>
        /// Payment method name 
        /// </summary>
		public String Name { get; set; }

        /// <summary>
        /// If it can be deleted 
        /// </summary>
		public Boolean CanDelete { get; set; }

        /// <summary>
        /// Payment method ID 
        /// </summary>
		public Guid PaymentMethodId { get; set; }
	} 
}