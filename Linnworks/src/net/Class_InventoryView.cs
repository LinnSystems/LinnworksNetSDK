using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class InventoryView
    {
        public Guid Id;
        public String Name;
        public ModeType Mode;
        public String Source;
        public String SubSource;
        public String CountryCode;
        public ListingType Listing;
        public Boolean ShowOnlyChanged;
        public List<Filter> Filters;
        public List<Column> Columns;
        public List<Channel> Channels;
    }
}