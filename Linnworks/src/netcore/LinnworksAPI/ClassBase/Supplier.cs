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
		public Guid pkSupplierID { get; set; }

        /// <summary>
        /// Supplier Name 
        /// </summary>
		public String SupplierName { get; set; }

        /// <summary>
        /// Name of main contact 
        /// </summary>
		public String ContactName { get; set; }

        /// <summary>
        /// Supplier's address 
        /// </summary>
		public String Address { get; set; }

        /// <summary>
        /// Second line of address 
        /// </summary>
		public String AlternativeAddress { get; set; }

        /// <summary>
        /// City 
        /// </summary>
		public String City { get; set; }

        /// <summary>
        /// Region 
        /// </summary>
		public String Region { get; set; }

        /// <summary>
        /// Country 
        /// </summary>
		public String Country { get; set; }

        /// <summary>
        /// Postcode 
        /// </summary>
		public String PostCode { get; set; }

        /// <summary>
        /// Telephone number 
        /// </summary>
		public String TelephoneNumber { get; set; }

        /// <summary>
        /// Secondary telephone number 
        /// </summary>
		public String SecondaryTelNumber { get; set; }

        /// <summary>
        /// Fax number 
        /// </summary>
		public String FaxNumber { get; set; }

        /// <summary>
        /// E-mail 
        /// </summary>
		public String Email { get; set; }

        /// <summary>
        /// Web page 
        /// </summary>
		public String WebPage { get; set; }

        /// <summary>
        /// Currency used 
        /// </summary>
		public String Currency { get; set; }
	} 
}