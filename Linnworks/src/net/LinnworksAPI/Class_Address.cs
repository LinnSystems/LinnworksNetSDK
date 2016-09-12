using System;

namespace LinnworksAPI
{
    [Serializable]
    public class Address
    {
        public String Address1;
        public String Address2;
        public String Address3;
        public String Town;
        public String Region;
        public String PostCode;
        public String Country;
        public String FullName;
        public String Company;
        public String PhoneNumber;
        public Guid CountryId;
    }
}