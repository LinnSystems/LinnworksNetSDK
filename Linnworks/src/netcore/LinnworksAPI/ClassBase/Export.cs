using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Export : LinnObject
	{
		public ExportSpecification Specification { get; set; }

		public ExportRegister Register { get; set; }

		public List<Schedule> Schedules { get; set; }
	} 
}