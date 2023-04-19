using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class MagentoConfig : LinnObject
	{
		public Boolean ManageImages { get; set; }

		public String Store { get; set; }

		public String AttributeSetName { get; set; }

		public String AttributeSetId { get; set; }

		public String UpSellsExtendedProperty { get; set; }

		public Boolean CreateUpSellBacklink { get; set; }

		public String RelatedExtendedProperty { get; set; }

		public Boolean CreateRelatedBacklink { get; set; }

		public String CrossSellsExtendedProperty { get; set; }

		public Boolean CreateCrossSellBacklink { get; set; }

		public String GroupedExtendedProperty { get; set; }

		public Boolean CreateGroupedBacklink { get; set; }

		public List<MagentoConfigAttributes> Attributes { get; set; }

		public List<MagentoConfigAttributes> VarAttributes { get; set; }

		public Boolean IsChildrenImages { get; set; }

		public Guid pkConfigid { get; set; }

		public List<ConfigCategory> Categories { get; set; }

		public String Site { get; set; }

		public String ConfigName { get; set; }

		public String CategoryExtendedProperty { get; set; }

		public Boolean ManageStock { get; set; }

		public Boolean ShowInInventory { get; set; }

		public Boolean IsChanged { get; set; }

		public Int64 LastUpdateTime { get; set; }

		public String LastUpdateSessionId { get; set; }

		public Int32 AssociatedSingle { get; set; }

		public Int32 AssociatedVariation { get; set; }

		public Int32 TotalAttributes { get; set; }

		public Int32 TotalVarAttributes { get; set; }

		public String VarTitleExtProperty { get; set; }

		public Boolean UseMainItemImages { get; set; }

		public Int32 GltConfiguratorId { get; set; }
	} 
}