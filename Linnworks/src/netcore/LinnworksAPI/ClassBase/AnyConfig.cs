using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AnyConfig : LinnObject
	{
		public ConfigItem<String> SourceVersion { get; set; }

		public ConfigItem<Boolean> Enabled { get; set; }

		public ConfigItem<String> ChannelTag { get; set; }

		public ConfigChannelLocationBinding ChannelLocationBinding { get; set; }

		public ConfigItem<Boolean> IsMultiLocation { get; set; }

		public ConfigItem<Boolean> AutoPopulatedLocations { get; set; }

		public ConfigItem<Boolean> CanModifyLocationsOnChannel { get; set; }

		public ConfigItem<Boolean> BopisSupported { get; set; }

		public ConfigProperty<Boolean> ProcessPosOrders { get; set; }

		public ConfigItem<Boolean> DespatchNotes { get; set; }

		public ConfigItem<Boolean> CancellationNotes { get; set; }

		public ConfigItem<Boolean> AutoRespondCancellationRequests { get; set; }

		public ConfigPropertySelectionList<SelectStringValueOption,String> CancellationResponseType { get; set; }

		public ConfigItem<Boolean> RefundNotes { get; set; }

		public ConfigItem<Boolean> DownloadRefunds { get; set; }

		public ConfigItem<Boolean> ReturnNotes { get; set; }

		public ConfigItem<Boolean> DownloadReturns { get; set; }

		public ConfigPropertySelectionList<SelectStringValueOption,Guid> OrderSaveLocation { get; set; }

		public ConfigItem<DateTime> OrderSyncDate { get; set; }

		public ConfigItem<DateTime> OrderCancellationCheckDate { get; set; }

		public ConfigPropertySelectionList<SelectStringValueOption,String> ConfigDiscount { get; set; }

		public ConfigItem<Int32> OrderDownloadErrorCount { get; set; }

		public ConfigItem<Int32> OrderDownloadGlobalErrorCount { get; set; }

		public ConfigItem<Int32> OrderDespatchErrorCount { get; set; }

		public ConfigItem<Int32> OrderDespatchGlobalErrorCount { get; set; }

		public ConfigItem<Int32> OrderCancellationCheckErrorCount { get; set; }

		public ConfigItem<Int32> OrderCancellationCheckGlobalErrorCount { get; set; }

		public ConfigItem<Int32> RmaDownloadErrorCount { get; set; }

		public ConfigItem<Int32> RmaDownloadGlobalErrorCount { get; set; }

		public ConfigProperty<Boolean> HidesHeaderAttributes { get; set; }

		public ConfigItem<Boolean> InventorySync { get; set; }

		public ConfigStockLocationBinding StockLocationBinding { get; set; }

		public ConfigItem<Int32> MaxListed { get; set; }

		public ConfigItem<Double> StockPercentage { get; set; }

		public ConfigItem<Int32> EndWhen { get; set; }

		public ConfigItem<Int32> InvSyncErrorCount { get; set; }

		public ConfigProperty<Boolean> ExtractInventory { get; set; }

		public ConfigProperty<String> ExtractInventoryVariationMappingPropertyName { get; set; }

		public ConfigItem<Boolean> PriceChange { get; set; }

		public ConfigItem<Int32> PriceChangeErrorCount { get; set; }

		public ConfigProperty<Boolean> IsInventorySyncTriggerEnabled { get; set; }

		public ConfigItem<Boolean> IsListingScanRunning { get; set; }

		public ConfigItem<DateTime> ListingScanStartUpdateDate { get; set; }

		public ConfigItem<DateTime> LastListingUpdateDate { get; set; }

		public ConfigItem<DateTime> EstimatedInventoryScanComplete { get; set; }

		public Boolean IsHeaderOnly { get; set; }

		public Boolean IsHidden { get; set; }

		public String DisplayName { get; set; }

		public ConfigItemExternal[] DynamicProperties { get; set; }

		public DiscountType ConfigDiscountTyped { get; set; }

		public ConfigPostalServiceMapping PostalServiceMapping { get; set; }

		public ConfigPaymentMethodMapping PaymentMethodMapping { get; set; }

		public Int32 PkChannelId { get; set; }

		public String Source { get; set; }

		public String SourceType { get; set; }

		public Boolean FulfillmentServiceEnabled { get; set; }

		public Guid FulfillmentLocation { get; set; }

		public String ConcurrencyKey { get; set; }

		public ConfigRuleCollection Rules { get; set; }

		public List<ConfigButton> Buttons { get; set; }

		public String SubSource { get; set; }

		public List<Channel_Setting_Audit> HeaderAuditValues { get; set; }
	} 
}