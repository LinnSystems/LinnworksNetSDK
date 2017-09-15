using System;

namespace LinnworksAPI
{
    public class UpdateGroupRequest
    {
        public Int32 GroupId;
        public String Name;
        public Int32? MaxOrderCount;
        public GroupCondition Condition;
        public GroupAction Action;
    }
}