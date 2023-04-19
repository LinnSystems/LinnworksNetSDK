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

        /// <summary>
        /// DST migration flag.
        /// 
        ///  0 - not migrated;
        ///  1 - migrated;
        ///  2 - migration failed; 
        /// </summary>
		public Byte Migrated { get; set; }

		public String ScheduleXML { get; set; }

		public ScheduleConfiguration Configuration { get; set; }
	} 
}