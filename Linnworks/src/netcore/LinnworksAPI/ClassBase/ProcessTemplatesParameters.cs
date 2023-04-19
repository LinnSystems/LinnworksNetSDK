using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ProcessTemplatesParameters : LinnObject
	{
		public String Source { get; set; }

		public String SubSource { get; set; }

		public Guid? ConfigId { get; set; }

		public List<Guid> InventoryItemIds { get; set; }

		public List<Tuple<Int32,Int32>> SelectedRegions { get; set; }

		public Guid Token { get; set; }

		public TemplateTypes TemplatesType { get; set; }
	} 
}