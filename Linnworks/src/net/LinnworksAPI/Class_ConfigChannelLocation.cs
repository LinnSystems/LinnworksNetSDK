using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class ConfigChannelLocation
    {
        public Int32 pkChannelLocationId;
        public Boolean Deleted;
        public String Identifier;
        public String Name;
        public Guid OrderDownloadLocation;
        public List<Guid> InventorySyncLocations;
    }
}