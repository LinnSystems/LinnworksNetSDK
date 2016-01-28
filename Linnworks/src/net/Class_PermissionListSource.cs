using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class PermissionListSource
    {
        public String ListName;
        public String SourceListName;
        public Int32 UserListId;
        public Int32 UserListLinkId;
        public List<PermissionListGroupSource> GroupLists;
        public String SourceListFriendlyName;
        public String SourceListDescription;
    }
}