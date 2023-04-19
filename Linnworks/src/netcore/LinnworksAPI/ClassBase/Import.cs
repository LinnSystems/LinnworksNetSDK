using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Import : LinnObject
	{
		public Specification<ImportGenericFeed,ImportColumn> Specification { get; set; }

		public ImportRegister Register { get; set; }

		public List<Schedule> Schedules { get; set; }
	} 
}