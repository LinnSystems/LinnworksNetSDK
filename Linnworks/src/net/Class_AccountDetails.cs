using System;

namespace LinnworksAPI
{
    public class AccountDetails
    {
        public Guid ID;
        public String Email;
        public String PasswordHash;
        public DateTime RegistrationDate;
        public String ForumName;
        public ContactDetails ContactDetails;
        public NotificationSettings NotificationSettings;
    }
}