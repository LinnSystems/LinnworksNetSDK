using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Export
	{
        /// <summary>
        /// Export Base Settings (Delimeters, Columns mapping etc) 
        /// </summary>
		public ExportSpecification Specification;

		public ExportRegister Register;

		public List<Schedule> Schedules;
	} 
}