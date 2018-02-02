using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Import
	{
		public Specification<ImportGenericFeed,ImportColumn> Specification;

		public ImportRegister Register;

		public List<Schedule> Schedules;
	} 
}