using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class SaveConfiguratorDescriptionResponse : LinnObject
	{
		public Boolean IsSaved { get; set; }

		public String ErrorMessage { get; set; }
	} 
}