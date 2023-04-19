using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AmazonConfig : LinnObject
	{
		public Fulfillment FulfillmentType { get; set; }

		public String Fulfillment_ExtendedPropertyName { get; set; }

		public Guid pkConfigId { get; set; }

		public String ConfigName { get; set; }

		public Int32 Version { get; set; }

		public String Site { get; set; }

		public String Category { get; set; }

		public String SubType { get; set; }

		public Int32 AssociatedTemplates { get; set; }

		public Int32 AssociatedVariations { get; set; }

		public List<AmazonAttribute> PictureAttributes { get; set; }

		public List<AmazonAttribute> Attributes { get; set; }

		public AmazonAttribute VariationThemeAttribute { get; set; }

		public AmazonAttribute ParentageAttribute { get; set; }

		public String VariationTheme { get; set; }

		public List<AmazonAttribute> Variations { get; set; }

		public List<AmazonBNode> BrowseNodes { get; set; }

		public Boolean ContainsBrowseNodes { get; set; }

		public String FirstBrowseNode_ExtendedProperty { get; set; }

		public String SecondBrowseNode_ExtendedProperty { get; set; }

		public String VariationTitle_ExtendedProperty { get; set; }

		public Boolean IsConfiguratorEdited { get; set; }

		public Boolean ShowInInventory { get; set; }

		public Int64 LastUpdateTime { get; set; }

		public String LastUpdateSessionId { get; set; }

		public OverrideMethod ShippingOverrideMethod { get; set; }

		public SimpleShipping ShippingOption { get; set; }

		public List<AmazonShipping> Shippings { get; set; }

		public Boolean UseMainItemImages { get; set; }

		public Boolean IgnoreIncorrectVariationChildren { get; set; }
	} 
}