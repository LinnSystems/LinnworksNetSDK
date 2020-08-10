using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PostSaleSubStatus
	{
        /// <summary>
        /// For an individual refund line, this identifies the line's state on the channel. For the header, if all its lines have the same StatusTag, it will also have the same StatusTag. If not,
        /// it will determine an appropriate StatusTag based on those of its lines 
        /// </summary>
		public String StatusTag { get; set; }

        /// <summary>
        /// A user-friendly descriptor of the StatusTag 
        /// </summary>
		public String StatusDescription { get; set; }

        /// <summary>
        /// Determines whether the refund is in a state where it requires action from the user 
        /// </summary>
		public Boolean Actionable { get; set; }

        /// <summary>
        /// A user-friendly descriptor of what "actioning" the refund will do on the channel 
        /// </summary>
		public String ActionDescription { get; set; }

        /// <summary>
        /// Where certain fields need to be modified for the refund to be successfully actioned, this list is populated with a list of the field names, allowing them to be edited as necessary 
        /// </summary>
		public List<String> EditableFields { get; set; }
	} 
}