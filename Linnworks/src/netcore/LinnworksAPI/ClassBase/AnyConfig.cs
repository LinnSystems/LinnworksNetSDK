using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AnyConfig
	{
		public ConfigItem<String> SourceVersion { get; set; }

		public ConfigItem<Boolean> Enabled { get; set; }

		public ConfigItem<String> ChannelTag { get; set; }

		public ConfigChannelLocationBinding ChannelLocationBinding { get; set; }

		public ConfigItem<Boolean> IsMultiLocation { get; set; }

		public ConfigItem<Boolean> AutoPopulatedLocations { get; set; }

		public ConfigItem<Boolean> DespatchNotes { get; set; }

		public ConfigItem<Boolean> CancellationNotes { get; set; }

		public ConfigItem<Boolean> RefundNotes { get; set; }

		public ConfigItem<Boolean> ReturnNotes { get; set; }

		public ConfigItem<DateTime> OrderSyncDate { get; set; }

		public ConfigPropertySelectionList<SelectStringValueOption,Guid> OrderSaveLocation { get; set; }

		public ConfigPropertySelectionList<SelectStringValueOption,String> ConfigDiscount { get; set; }

		public ConfigProperty<Boolean> HidesHeaderAttributes { get; set; }

		public ConfigItem<Boolean> InventorySync { get; set; }

		public ConfigStockLocationBinding StockLocationBinding { get; set; }

		public ConfigItem<Int32> MaxListed { get; set; }

		public ConfigItem<Double> StockPercentage { get; set; }

		public ConfigItem<Int32> EndWhen { get; set; }

		public ConfigItem<Boolean> PriceChange { get; set; }

		public ConfigProperty<Boolean> IsInventorySyncTriggerEnabled { get; set; }

		public ConfigItem<Boolean> IsListingScanRunning { get; set; }

		public ConfigItem<DateTime> ListingScanStartUpdateDate { get; set; }

		public ConfigItem<DateTime> LastListingUpdateDate { get; set; }

		public ConfigItem<DateTime> EstimatedInventoryScanComplete { get; set; }

		public Boolean IsHeaderOnly { get; set; }

		public Boolean IsHidden { get; set; }

		public ConfigItemExternal[] DynamicProperties { get; set; }

		public DiscountType ConfigDiscountTyped { get; set; }

		public ConfigPostalServiceMapping PostalServiceMapping { get; set; }

		public ConfigPaymentMethodMapping PaymentMethodMapping { get; set; }

		public Int32 PkChannelId { get; set; }

		public String Source { get; set; }

		public String SourceType { get; set; }

		public ConfigRuleCollection Rules { get; set; }

		public List<ConfigButton> Buttons { get; set; }

		public String SubSource { get; set; }

		public List<Channel_Setting_Audit> HeaderAuditValues { get; set; }
	} 
}