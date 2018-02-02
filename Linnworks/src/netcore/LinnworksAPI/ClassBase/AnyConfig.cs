using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AnyConfig
	{
		public ConfigItem<String> SourceVersion;

		public ConfigItem<Boolean> Enabled;

		public ConfigItem<String> ChannelTag;

		public ConfigChannelLocationBinding ChannelLocationBinding;

		public ConfigItem<Boolean> IsMultiLocation;

		public ConfigItem<Boolean> DespatchNotes;

		public ConfigItem<Boolean> CancellationNotes;

		public ConfigItem<Boolean> RefundNotes;

		public ConfigItem<Boolean> ReturnNotes;

		public ConfigItem<DateTime> OrderSyncDate;

		public ConfigPropertySelectionList<SelectStringValueOption,Guid> OrderSaveLocation;

		public ConfigPropertySelectionList<SelectStringValueOption,String> ConfigDiscount;

		public ConfigProperty<Boolean> HidesHeaderAttributes;

		public ConfigItem<Boolean> InventorySync;

		public ConfigStockLocationBinding StockLocationBinding;

		public ConfigItem<Int32> MaxListed;

		public ConfigItem<Double> StockPercentage;

		public ConfigItem<Int32> EndWhen;

		public ConfigItem<Boolean> PriceChange;

		public ConfigItem<Boolean> IsListingScanRunning;

		public ConfigItem<DateTime> ListingScanStartUpdateDate;

		public ConfigItem<DateTime> LastListingUpdateDate;

		public ConfigItem<DateTime> EstimatedInventoryScanComplete;

		public Boolean IsHeaderOnly;

		public Boolean IsHidden;

		public ConfigItemExternal[] DynamicProperties;

		public DiscountType ConfigDiscountTyped;

		public ConfigPostalServiceMapping PostalServiceMapping;

		public ConfigPaymentMethodMapping PaymentMethodMapping;

		public Int32 PkChannelId;

		public String Source;

		public String SourceType;

		public ConfigRuleCollection Rules;

		public List<ConfigButton> Buttons;

		public String SubSource;

		public List<System_Channel_Setting_Property> HeaderAuditValues;
	} 
}