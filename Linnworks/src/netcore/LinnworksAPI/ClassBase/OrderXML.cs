using System.Collections.Generic;
using System.Text;
using System;
using System.Xml;

namespace LinnworksAPI
{ 
    public class OrderXML
	{
		public String LineTag { get; set; }

		public String Type { get; set; }

		public String XML { get; set; }

		public XmlDocument XMLDoc { get; set; }
	} 
}