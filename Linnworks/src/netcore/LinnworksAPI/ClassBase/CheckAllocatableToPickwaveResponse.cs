using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Check allocatable to pickwave response. 
    /// </summary>
    public class CheckAllocatableToPickwaveResponse
	{
        /// <summary>
        /// List of results 
        /// </summary>
		public List<PickWaveAllocateCheckResult> Results { get; set; }
	} 
}