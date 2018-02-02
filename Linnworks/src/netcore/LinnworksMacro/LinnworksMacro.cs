using LinnworksAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinnworksMacro
{
    public class LinnworksMacro : LinnworksMacroHelpers.LinnworksMacroBase
    {
        public StockItemInv Execute(Guid pkStockItemId)
        {
            return Api.Inventory.GetInventoryItemById(pkStockItemId);
        }
    }
}



