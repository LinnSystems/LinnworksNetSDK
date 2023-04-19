using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DeleteConfiguratorsResponse : LinnObject
	{
		public List<Int32> DeletedIds { get; set; }
	} 
}