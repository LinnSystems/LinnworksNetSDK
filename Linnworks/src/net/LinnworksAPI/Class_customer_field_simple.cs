using System;

namespace LinnworksAPI
{
    public class customer_field_simple
    {
        public Int32 pkFieldId;
        public Int32 id;
        public String FieldName;
        public String FieldDescription;
        public String FieldType;
        public String FieldTag;
        public String FieldValue;
        public DateTime ModifiedOn;
        public Boolean IsRequired;
        public String ValidationPattern;
        public Boolean EndUserReadOnly;
        public Boolean EndUserVisible;
        public Int32 SortOrder;
        public Guid pkCustomerFieldId;
    }
}