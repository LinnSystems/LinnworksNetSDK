using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class PermissionHierarchy
    {
        public String PermissionName;
        public String FriendlyName;
        public String Description;
        public Boolean HasLists;
        public Boolean IsLeafNode;
        public List<PermissionHierarchy> ChildPermissions;
    }
}