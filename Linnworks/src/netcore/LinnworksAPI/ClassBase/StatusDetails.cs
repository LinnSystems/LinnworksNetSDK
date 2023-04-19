using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StatusDetails : LinnObject
	{
		public StateType State { get; set; }

		public String Reason { get; set; }

		public Dictionary<String,String> Parameters { get; set; }
	} 
}