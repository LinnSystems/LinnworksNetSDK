using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StatusDetails
	{
		public StateType State;

		public String Reason;

		public Dictionary<String,String> Parameters;
	} 
}