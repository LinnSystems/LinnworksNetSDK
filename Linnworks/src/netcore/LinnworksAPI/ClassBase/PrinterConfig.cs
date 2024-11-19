using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PrinterConfig : LinnObject
	{
		public String PrinterName { get; set; }

		public Guid TemplateId { get; set; }

		public String LabelFormat { get; set; }

		public Double MarginLeft { get; set; }

		public Double MarginTop { get; set; }

		public Boolean Duplex { get; set; }

		public List<PrinterUserConfig> UserConfig { get; set; }

		public List<PrintZoneConfig> PrintZoneConfig { get; set; }
	} 
}