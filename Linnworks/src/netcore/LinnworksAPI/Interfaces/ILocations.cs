using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{ 
    public interface ILocationsController
	{
		void AddLocation(StockLocation location);
		void DeleteLocation(Guid pkStockLocationId);
		StockLocation GetLocation(Guid pkStockLocationId);
		void UpdateLocation(StockLocation location);
	} 
}