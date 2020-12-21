using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AssignResult
	{
		public Guid[] Changed { get; set; }

		public Guid[] NotChanged { get; set; }
	} 
}