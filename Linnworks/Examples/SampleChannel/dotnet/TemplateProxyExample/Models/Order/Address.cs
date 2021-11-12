using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.Order
{
    public class Address
    {
        /// <summary>
        /// Customer Full Name.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Customer Company.
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// First line of address.
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Second line of address.
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// Third line of address.
        /// </summary>
        public string Address3 { get; set; } 

        /// <summary>
        /// Town.
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// Area, County, State or a Region.
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Postal / Zip Code.
        /// </summary>
        public string PostCode { get; set; }

        /// <summary>
        /// Country.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// ISO 3166-2 Country Code.
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Customer's phone number.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Email Address.
        /// </summary>
        public string EmailAddress { get; set; }
    }
}