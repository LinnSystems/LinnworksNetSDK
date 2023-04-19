using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BigCommerceConfigurator : LinnObject
	{
		public List<BigCommerceConfigAttributes> Attributes { get; set; }

		public String OptionSetName { get; set; }

		public List<VarAttribute> VarAttributes { get; set; }

		public List<ConfigUserAttributes> UserAttributes { get; set; }

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