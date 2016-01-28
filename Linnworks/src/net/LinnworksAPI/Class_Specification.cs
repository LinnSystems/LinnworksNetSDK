using System.Collections.Generic;

namespace LinnworksAPI
{
    public class Specification<ImportGenericFeed, ImportColumn>
    {
        public ImportGenericFeed Feed;
        public List<ImportColumn> ColumnMappings;
    }
}