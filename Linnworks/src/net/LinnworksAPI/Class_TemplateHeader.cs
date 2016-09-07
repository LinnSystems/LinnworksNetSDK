using System;

namespace LinnworksAPI
{
    public class TemplateHeader
    {
        public Int32 pkTemplateRowId;
        public Guid TemplateId;
        public String TemplateType;
        public String TemplateName;
        public Boolean Enabled;
        public Boolean IsDefault;
        public Boolean IsEmailAttachment;
        public String VisibilityCondition;
        public Boolean bLogicalDelete;
        public Boolean IsConditional;
        public Int32 ConditionRating;
    }
}