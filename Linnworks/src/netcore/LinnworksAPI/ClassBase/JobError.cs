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
		public Int32 JobErrorId { get; set; }

        /// <summary>
        /// Action for which the error is thrown 
        /// </summary>
		public String Action { get; set; }

        /// <summary>
        /// related order id, if null the error is for the whole action 
        /// </summary>
		public Guid? OrderId { get; set; }

        /// <summary>
        /// error type, default 0 
        /// </summary>
		public Int32 ErrorType { get; set; }

        /// <summary>
        /// Error string, max 255 characters 
        /// </summary>
		public String ErrorText { get; set; }
	} 
}