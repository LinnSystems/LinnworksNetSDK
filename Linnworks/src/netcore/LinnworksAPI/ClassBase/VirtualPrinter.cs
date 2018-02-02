using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class VirtualPrinter
	{
        /// <summary>
        /// Printer location (name of PC) 
        /// </summary>
		public String PrinterLocationName;

        /// <summary>
        /// printer name 
        /// </summary>
		public String PrinterName;

        /// <summary>
        /// Infromation about printer status 
        /// </summary>
		public PrinterStatus Status;
	} 
}