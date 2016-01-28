using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class ValidationResult
    {
        public ValidationResultTypes Type;
        public List<RefundItem> InvalidItems;
        public String AdditionalInformation;
    }
}