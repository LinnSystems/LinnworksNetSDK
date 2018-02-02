using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Purchase Order extended property item 
    /// </summary>
    public class PurchaseOrderExtendedProperty
	{
        /// <summary>
        /// Extended Property item id 
        /// </summary>
		public Int32 RowId;

        /// <summary>
        /// Purchase order id (unique identifier) 
        /// </summary>
		public Guid PurchaseID;

        /// <summary>
        /// UTC date when the extended property was added 
        /// </summary>
		public DateTime AddedDateTime;

        /// <summary>
        /// User name which added the extended property, if the property is updated it will not be changed from original 
        /// </summary>
		public String UserName;

        /// <summary>
        /// Property name (max 255) 
        /// </summary>
		public String PropertyName;

        /// <summary>
        /// Property value (max 600) 
        /// </summary>
		public String PropertyValue;
	} 
}