using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Supplier
	{
        /// <summary>
        /// Supplier Id 
        /// </summary>
		public Guid pkSupplierID;

        /// <summary>
        /// Supplier Name 
        /// </summary>
		public String SupplierName;

        /// <summary>
        /// Name of main contact 
        /// </summary>
		public String ContactName;

        /// <summary>
        /// Supplier's address 
        /// </summary>
		public String Address;

        /// <summary>
        /// Second line of address 
        /// </summary>
		public String AlternativeAddress;

        /// <summary>
        /// City 
        /// </summary>
		public String City;

        /// <summary>
        /// Region 
        /// </summary>
		public String Region;

        /// <summary>
        /// Country 
        /// </summary>
		public String Country;

        /// <summary>
        /// Postcode 
        /// </summary>
		public String PostCode;

        /// <summary>
        /// Telephone number 
        /// </summary>
		public String TelephoneNumber;

        /// <summary>
        /// Secondary telephone number 
        /// </summary>
		public String SecondaryTelNumber;

        /// <summary>
        /// Fax number 
        /// </summary>
		public String FaxNumber;

        /// <summary>
        /// E-mail 
        /// </summary>
		public String Email;

        /// <summary>
        /// Web page 
        /// </summary>
		public String WebPage;

        /// <summary>
        /// Currency used 
        /// </summary>
		public String Currency;
	} 
}