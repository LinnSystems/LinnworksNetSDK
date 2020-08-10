using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UserOrderView
	{
		public DateTime ModifiedDateTime { get; set; }

        /// <summary>
        /// View ID 
        /// </summary>
		public Int32 pkViewId { get; set; }

        /// <summary>
        /// View name 
        /// </summary>
		public String ViewName { get; set; }

        /// <summary>
        /// View owner name 
        /// </summary>
		public String OwnerName { get; set; }

        /// <summary>
        /// Can be modified 
        /// </summary>
		public Boolean? AllowModify { get; set; }

		public String JSONDetail { get; set; }
	} 
}