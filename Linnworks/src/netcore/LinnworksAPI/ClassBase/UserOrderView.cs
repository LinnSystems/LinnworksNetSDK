using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UserOrderView
	{
		public DateTime ModifiedDateTime;

        /// <summary>
        /// View ID 
        /// </summary>
		public Int32 pkViewId;

        /// <summary>
        /// View name 
        /// </summary>
		public String ViewName;

        /// <summary>
        /// View owner name 
        /// </summary>
		public String OwnerName;

        /// <summary>
        /// Can be modified 
        /// </summary>
		public Boolean? AllowModify;

		public String JSONDetail;
	} 
}