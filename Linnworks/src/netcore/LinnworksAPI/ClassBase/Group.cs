using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Group
	{
		public Int32 GroupId { get; set; }

		public Guid LocationId { get; set; }

		public String Name { get; set; }

		public String Prefix { get; set; }

		public Int32 Seed { get; set; }

		public Int32 MaxOrderCount { get; set; }

		public Int32 Prevalence { get; set; }

		public Int32 JobCount { get; set; }

		public Int32 OrderCount { get; set; }

		public Int32 AttachmentCount { get; set; }

		public GroupCondition Condition { get; set; }

		public GroupAction Action { get; set; }

		public Boolean HasAction { get; set; }
	} 
}