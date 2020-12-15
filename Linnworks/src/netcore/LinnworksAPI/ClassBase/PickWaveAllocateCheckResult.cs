using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Pickwave allocated check result. 
    /// </summary>
    public class PickWaveAllocateCheckResult
	{
        /// <summary>
        /// Order Id interger 
        /// </summary>
		public Int32 OrderId { get; set; }

        /// <summary>
        /// Order Id uniqueidentifier 
        /// </summary>
		public Guid OrderId_Guid { get; set; }

        /// <summary>
        /// Errors 
        /// </summary>
		public List<PickWaveAllocateCheckResultError> Errors { get; set; }

        /// <summary>
        /// Has Errors 
        /// </summary>
		public Boolean HasErrors { get; set; }

		public List<PickWaveAllocateCheckResultOrderDetails> OrderDetails { get; set; }
	} 
}