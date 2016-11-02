using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class GetOrderPackagingCalculationRequest
    {
        public List<Guid> pkOrderIds;
        public Boolean Recalculate;
        public Boolean SaveRecalculation;
    }
}