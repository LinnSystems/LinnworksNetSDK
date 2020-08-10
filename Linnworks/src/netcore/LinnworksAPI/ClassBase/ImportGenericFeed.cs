using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ImportGenericFeed
	{
		public ImportFeedType FeedType { get; set; }

		public String Encoding { get; set; }

		public Char Delimiter { get; set; }

		public Char Comment { get; set; }

		public Boolean HasHeaders { get; set; }

		public Char Escape { get; set; }

		public Char Quote { get; set; }
	} 
}