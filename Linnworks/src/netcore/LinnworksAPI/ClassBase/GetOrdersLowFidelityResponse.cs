using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetOrdersLowFidelityResponse : LinnObject
	{
        /// <summary>
        /// List of low fidelity order headers with order items, composites and product identifiers 
        /// </summary>
		public List<OpenOrderLowFidelity> Orders { get; set; }
	} 
}