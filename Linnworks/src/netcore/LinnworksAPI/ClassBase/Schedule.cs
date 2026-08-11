using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Schedule : LinnObject
	{
		public Int32 Id { get; set; }

		public Int32 Order { get; set; }

		public String Name { get; set; }

		public Int32 OwnerId { get; set; }

		public Byte Migrated { get; set; }

		public String ScheduleXML { get; set; }

		public ScheduleConfiguration Configuration { get; set; }
	} 
}