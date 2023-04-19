using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetTemplatesParameters : LinnObject
	{
		public List<Guid> TemplateIds { get; set; }

		public Boolean OnlyWithErrors { get; set; }

		public String Source { get; set; }

		public String SubSource { get; set; }

		public Guid? ConfigId { get; set; }

		public List<Guid> InventoryItemIds { get; set; }

		public List<Tuple<Int32,Int32>> SelectedRegions { get; set; }

		public Guid Token { get; set; }

		public TemplateTypes TemplatesType { get; set; }

		public Int32 PageNumber { get; set; }

		public Int32 EntriesPerPage { get; set; }

		public SiteFilter SiteFilter { get; set; }
	} 
}