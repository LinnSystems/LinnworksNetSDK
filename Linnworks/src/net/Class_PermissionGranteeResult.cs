using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class PermissionGranteeResult
    {
        public String PermissionType;
        public List<PermissionGranteeGroup> Groups;
        public List<PermissionGranteeUser> Users;
    }
}