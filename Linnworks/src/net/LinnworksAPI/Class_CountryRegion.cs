using System;

namespace LinnworksAPI
{
    public class CountryRegion
    {
        public Int32 pkRegionRowId;
        public String RegionCode;
        public String RegionName;
        public Double? TaxRate;
        public Guid fkCountryId;
        public CountryRegionReplaceWith ReplaceWith;
    }
}