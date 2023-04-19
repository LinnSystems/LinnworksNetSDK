using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetPickwaveUsersWithSummaryResponse : LinnObject
	{
		public List<PickingWave> PickingWaves { get; set; }
	} 
}