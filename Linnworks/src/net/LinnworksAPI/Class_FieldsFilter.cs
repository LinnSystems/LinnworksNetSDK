using System.Collections.Generic;

namespace LinnworksAPI
{
    public class FieldsFilter
    {
        public List<TextFieldFilter> TextFields;
        public List<BooleanFieldFilter> BooleanFields;
        public List<NumericFieldFilter> NumericFields;
        public List<DateFieldFilter> DateFields;
        public List<ListFieldFilter> ListFields;
    }
}