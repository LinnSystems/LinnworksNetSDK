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
		public Int32 OrderId;

        /// <summary>
        /// Order Id uniqueidentifier 
        /// </summary>
		public Guid OrderId_Guid;

        /// <summary>
        /// Errors 
        /// </summary>
		public List<PickWaveAllocateCheckResultError> Errors;

        /// <summary>
        /// Has Errors 
        /// </summary>
		public Boolean HasErrors;
	} 
}