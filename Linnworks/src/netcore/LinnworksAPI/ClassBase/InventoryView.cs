using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class InventoryView
	{
        /// <summary>
        /// View ID 
        /// </summary>
		public Guid Id { get; set; }

        /// <summary>
        /// View name 
        /// </summary>
		public String Name { get; set; }

        /// <summary>
        /// Show listed or not listed 
        /// </summary>
		public ModeType Mode { get; set; }

        /// <summary>
        /// ChannelName/Source (e.g. EBAY) 
        /// </summary>
		public String Source { get; set; }

        /// <summary>
        /// SubSource (e.g. EBAY1) 
        /// </summary>
		public String SubSource { get; set; }

        /// <summary>
        /// Country code 
        /// </summary>
		public String CountryCode { get; set; }

        /// <summary>
        /// Country code 
        /// </summary>
		public String CountryName { get; set; }

        /// <summary>
        /// What listing types to show 
        /// </summary>
		public ListingType Listing { get; set; }

        /// <summary>
        /// Show only changed items 
        /// </summary>
		public Boolean ShowOnlyChanged { get; set; }

        /// <summary>
        /// Include archived products 
        /// </summary>
		public IncludeArchived IncludeProducts { get; set; }

        /// <summary>
        /// View filters 
        /// </summary>
		public List<Filter> Filters { get; set; }

        /// <summary>
        /// View columns 
        /// </summary>
		public List<Column> Columns { get; set; }

        /// <summary>
        /// View channels 
        /// </summary>
		public List<InventoryChannel> Channels { get; set; }
	} 
}