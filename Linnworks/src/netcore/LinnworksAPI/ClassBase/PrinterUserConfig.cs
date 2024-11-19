using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PrinterUserConfig : LinnObject
	{
		public Guid UserId { get; set; }

		public String PrinterName { get; set; }

		public Double MarginLeft { get; set; }

		public Double MarginTop { get; set; }

		public Guid TemplateId { get; set; }

		public String LabelFormat { get; set; }

		public Boolean Duplex { get; set; }
	} 
}