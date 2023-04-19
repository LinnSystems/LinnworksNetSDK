using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AssociatedTemplate : LinnObject
	{
		public Guid TemplateId { get; set; }

		public Guid UsedConfigId { get; set; }

		public String Name { get; set; }

		public String Site { get; set; }
	} 
}