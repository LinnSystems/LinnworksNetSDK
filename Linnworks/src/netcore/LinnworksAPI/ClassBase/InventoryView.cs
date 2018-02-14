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
		public Guid Id;

        /// <summary>
        /// View name 
        /// </summary>
		public String Name;

        /// <summary>
        /// Show listed or not listed 
        /// </summary>
		public ModeType Mode;

        /// <summary>
        /// ChannelName/Source (e.g. EBAY) 
        /// </summary>
		public String Source;

        /// <summary>
        /// SubSource (e.g. EBAY1) 
        /// </summary>
		public String SubSource;

        /// <summary>
        /// Country code 
        /// </summary>
		public String CountryCode;

        /// <summary>
        /// Country code 
        /// </summary>
		public String CountryName;

        /// <summary>
        /// What listing types to show 
        /// </summary>
		public ListingType Listing;

        /// <summary>
        /// Show only changed items 
        /// </summary>
		public Boolean ShowOnlyChanged;

        /// <summary>
        /// Include archived products 
        /// </summary>
		public IncludeArchived IncludeProducts;

        /// <summary>
        /// View filters 
        /// </summary>
		public List<Filter> Filters;

        /// <summary>
        /// View columns 
        /// </summary>
		public List<Column> Columns;

        /// <summary>
        /// View channels 
        /// </summary>
		public List<InventoryChannel> Channels;
	} 
}