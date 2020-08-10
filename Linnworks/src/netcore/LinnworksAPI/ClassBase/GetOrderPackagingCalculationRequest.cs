using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Request class for GetOrderPackagingCalculationRequest method in Orders controller 
    /// </summary>
    public class GetOrderPackagingCalculationRequest
	{
        /// <summary>
        /// List of order ids for which the packaging information should be returned, recalculated, saved 
        /// </summary>
		public Guid[] pkOrderIds { get; set; }

        /// <summary>
        /// Flag to indicate that recalculation is necessary 
        /// </summary>
		public Boolean Recalculate { get; set; }

        /// <summary>
        /// Flag to indicate that after recalculation the results should be saved back to the database 
        /// </summary>
		public Boolean SaveRecalculation { get; set; }
	} 
}