using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class HeaderConfig
	{
		public ConfigItem<String> SourceVersion;

		public ConfigItem<Boolean> Enabled;

		public ConfigItem<String> ChannelTag;

		public ConfigChannelLocationBinding ChannelLocationBinding;

		public ConfigItem<Boolean> IsMultiLocation;

		public ConfigItem<Boolean> AutoPopulatedLocations;

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

        /// <summary>
        /// Controls whether a channel's configs are displayed in the UI
        /// Set to true in the derived class if we want to hide it (See PlaytradeConfig.cs) 
        /// </summary>
		public Boolean IsHidden;

		public ConfigItemExternal[] DynamicProperties;

		public DiscountType ConfigDiscountTyped;

		public ConfigPostalServiceMapping PostalServiceMapping;

		public ConfigPaymentMethodMapping PaymentMethodMapping;

        /// <summary>
        /// Channel ID 
        /// </summary>
		public Int32 PkChannelId;

		public String Source;

		public String SourceType;

		public ConfigRuleCollection Rules;

		public List<ConfigButton> Buttons;

		public String SubSource;

		public List<Channel_Setting_Audit> HeaderAuditValues;
	} 
}