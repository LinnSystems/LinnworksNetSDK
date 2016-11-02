using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class PartialUpdateParameter
    {
        public Guid pkId;
        public List<KeyValuePair<String, String>> fieldList;
    }
}