using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PickWaveAllocateCheckResultError
	{
        /// <summary>
        /// Error message 
        /// </summary>
		public String Error;

        /// <summary>
        /// Error type enum. 
        /// </summary>
		public PickWaveAllocateCheckErrorType ErrorType;

        /// <summary>
        /// Order item row id, if null or guid empty then top level order error. 
        /// </summary>
		public Guid? OrderItemRowId;
	} 
}