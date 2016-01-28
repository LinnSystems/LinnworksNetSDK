using System;

namespace LinnworksAPI
{
    public class PermissionsUser
    {
        public Int32 UserId;
        public Boolean SuperAdmin;
        public Guid fkUserId;
        public Boolean IsRequestingUser;
        public String EmailAddress;
    }
}