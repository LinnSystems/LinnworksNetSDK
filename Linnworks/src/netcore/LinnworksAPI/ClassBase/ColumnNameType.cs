using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LinnworksAPI
{ 
    [JsonConverter(typeof(StringEnumConverter))]
	public enum ColumnNameType
	{
		SKU,
		Title,
		VariationGroupName,
		RetailPrice,
		PurchasePrice,
		Tracked,
		Barcode,
		Available,
		MinimumLevel,
		InOrder,
		StockLevel,
		StockValue,
		Due,
		BinRack,
		Category,
		Image,
		Weight,
		DimHeight,
		DimWidth,
		DimDepth,
		CreatedDate,
		ModifiedDate,
		SerialNumberScanRequired,
		BatchNumberScanRequired,
		BatchType,
		JIT,
		ReorderAmount,
		ReorderDate,
		AverageConsumption,
		DefaultSupplier,
	}
}