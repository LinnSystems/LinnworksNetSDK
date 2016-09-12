using System.Collections.Generic;

namespace LinnworksAPI
{
    public class FieldsFilter
    {
        public List<TextFieldFilter> TextFields = new List<TextFieldFilter>() ;
        public List<BooleanFieldFilter> BooleanFields = new List<BooleanFieldFilter>();
        public List<NumericFieldFilter> NumericFields = new List<NumericFieldFilter>();
        public List<DateFieldFilter> DateFields = new List<DateFieldFilter>();
        public List<ListFieldFilter> ListFields = new List<ListFieldFilter>();
        public List<FieldVisibility> FieldVisibility = new List<FieldVisibility>();
    }
}