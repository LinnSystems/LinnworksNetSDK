using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Bulk image response. 
    /// </summary>
    public class GetImagesInBulkResponse : LinnObject
	{
		public List<GetImagesInBulkResponseImage> Images { get; set; }
	} 
}