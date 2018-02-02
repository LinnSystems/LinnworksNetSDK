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
		public String Name;

        /// <summary>
        /// If it can be deleted 
        /// </summary>
		public Boolean CanDelete;

        /// <summary>
        /// Payment method ID 
        /// </summary>
		public Guid PaymentMethodId;
	} 
}