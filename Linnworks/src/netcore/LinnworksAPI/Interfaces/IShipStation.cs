using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{ 
    public interface IShipStationController
	{
		ShipStationConfig CreateShipStationIntegration(ShipStationConfig integration);
		void DeleteShipStationIntegration(String integrationId);
		Boolean EditShipStationIntegration(ShipStationConfig integration);
		ShipStationConfig GetShipStationIntegration(String integrationId);
		List<ShipStationConfig> GetShipStationIntegrations();
	} 
}