using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Job error item 
    /// </summary>
    public class JobError
	{
        /// <summary>
        /// Unique job error id 
        /// </summary>
		public Int32 JobErrorId;

        /// <summary>
        /// Action for which the error is thrown 
        /// </summary>
		public String Action;

        /// <summary>
        /// related order id, if null the error is for the whole action 
        /// </summary>
		public Guid? OrderId;

        /// <summary>
        /// error type, default 0 
        /// </summary>
		public Int32 ErrorType;

        /// <summary>
        /// Error string, max 255 characters 
        /// </summary>
		public String ErrorText;
	} 
}