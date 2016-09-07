using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class HeaderConfig
    {
        public ConfigItem<Boolean> Enabled;
        public ConfigItem<String> ChannelTag;
        public ConfigItem<Boolean> DespatchNotes;
        public ConfigItem<DateTime> OrderSyncDate;
        public ConfigPropertySelectionList<SelectStringValueOption, Guid> OrderSaveLocation;
        public ConfigItem<Boolean> InventorySync;
        public ConfigStockLocationBinding StockLocationBinding;
        public ConfigItem<Boolean> PriceChange;
        public ConfigItem<Int32> MaxListed;
        public ConfigItem<Double> StockPercentage;
        public ConfigItem<Int32> EndWhen;
        public ConfigItem<Boolean> IsListingScanRunning;
        public ConfigItem<DateTime> ListingScanStartUpdateDate;
        public ConfigItem<DateTime> LastListingUpdateDate;
        public ConfigItem<DateTime> EstimatedInventoryScanComplete;
        public Boolean IsHeaderOnly;
        public Boolean IsHidden;
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