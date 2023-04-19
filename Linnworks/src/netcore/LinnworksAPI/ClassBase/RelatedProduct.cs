using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class RelatedProduct : LinnObject
	{
		public Guid TemplateId { get; set; }

		public Int32 ProductId { get; set; }

		public String Name { get; set; }

		public Boolean LinkAssigned { get; set; }

		public RelatedTypes Type { get; set; }
	} 
}