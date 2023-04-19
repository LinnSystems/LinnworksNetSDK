using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CheckinUserResponse : LinnObject
	{
		public DateTime? LastRun { get; set; }

		public Boolean AllocationStarted { get; set; }

		public Boolean AllocationRunning { get; set; }
	} 
}