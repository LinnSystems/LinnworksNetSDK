using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class TemplateHeader
	{
		public Int32 pkTemplateRowId { get; set; }

		public Guid TemplateId { get; set; }

		public String TemplateType { get; set; }

		public String TemplateName { get; set; }

		public Boolean Enabled { get; set; }

		public Boolean IsDefault { get; set; }

		public Boolean IsEmailAttachment { get; set; }

		public String VisibilityCondition { get; set; }

		public Boolean bLogicalDelete { get; set; }

		public Boolean IsConditional { get; set; }

		public Int32 ConditionRating { get; set; }
	} 
}