using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class ChannelDetails
    {
        public List<InventoryListingLink> Links;
        public List<InventoryListingTemplate> Templates;
        public List<FieldTypes> Changes;
        public Boolean ContainsChanges;
    }
}