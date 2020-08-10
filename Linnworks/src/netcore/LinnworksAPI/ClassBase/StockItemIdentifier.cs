using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Stock item identifiers. 
    /// </summary>
    public class StockItemIdentifier
	{
        /// <summary>
        /// Stock item id 
        /// </summary>
		public Guid StockItemId;

        /// <summary>
        /// Product identifier type 
        /// </summary>
		public ProductIdentifierType Type;

        /// <summary>
        /// Product identifier 
        /// </summary>
		public String Value;
	} 
}