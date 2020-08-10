using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class VirtualPrinter
	{
        /// <summary>
        /// Name used to identify the printer in linnworks 
        /// </summary>
		public String PrinterName { get; set; }

        /// <summary>
        /// Name used to identify the instance of the virtual printer client 
        /// </summary>
		public String PrinterLocationName { get; set; }

        /// <summary>
        /// Printer name as seen in windows OS (e.g. Microsoft Print to PDF) 
        /// </summary>
		public String PrinterLocalName { get; set; }

        /// <summary>
        /// Whether the printer is online or offline 
        /// </summary>
		public PrinterStatus Status { get; set; }
	} 
}