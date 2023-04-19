using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DeleteVariationGroupsRequest : LinnObject
	{
        /// <summary>
        /// /// A list of VariationsGroups Guids 
        /// </summary>
		public IEnumerable<Guid> VariationGroupsIdList { get; set; }
	} 
}