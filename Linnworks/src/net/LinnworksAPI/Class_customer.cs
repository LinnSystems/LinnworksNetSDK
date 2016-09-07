using System;

namespace LinnworksAPI
{
    public class customer
    {
        public Guid sid_registration;
        public Guid id;
        public Guid fkPartnerSid;
        public String Email;
        public DateTime RegistrationDate;
        public Boolean IsCustomer;
        public String CustomerReferenceNumber;
        public String ContactName;
        public String BusinessName;
        public String Currency;
        public String ConnectionString;
        public Double Tax;
        public Int32 ActiveProfiles;
        public Int32 total;
        public customer_field_simple Fields;
        public customer_profile Profiles;
        public String ActiveProfileAsString;
        public DateTime LastPayment;
    }
}