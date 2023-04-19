using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Delete_AdditionalCostTypesRequest : LinnObject
	{
        /// <summary>
        /// Additional cost type Ids to delete 
        /// </summary>
		public Int32 AdditionalCostTypeId { get; set; }
	} 
}