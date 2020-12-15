using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LinnworksAPI
{ 
    [JsonConverter(typeof(StringEnumConverter))]
	public enum PickWaveAllocateCheckErrorType
	{
		Unknown,
		NeedsStockAllocation,
		IsLocked,
		IsParked,
		IsInFulfilmentCentre,
		IsCancelled,
		IsProcessed,
		NoVaidItems,
		UnlinkedItem,
		AlreadyExistsInWave,
		OrderDoesntExist,
		AllCombinationOfItemsDontExist,
		DuplicateCombinationsOfItemsExist,
		DifferentLocation,
	}
}