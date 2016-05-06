using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class FulfilmentCenterImportExportSettings
{ public Guid fkStockLocationId;
public Int32 fkOrdersExportId;
public Int32 fkOrdersImportId;
public Int32 fkInventoryImportId;
public Boolean OrdersExportEnabled;
public Boolean OrdersImportEnabled;
public Boolean InventoryImportEnabled;
 
} 
}