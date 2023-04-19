using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class MacroRegister : LinnObject
	{
		public Int32 MacroId { get; set; }

		public String ApplicationName { get; set; }

		public String MacroName { get; set; }

		public String FriendlyName { get; set; }

		public Boolean Enabled { get; set; }

		public DateTime Started { get; set; }

		public DateTime Completed { get; set; }

		public Boolean Executing { get; set; }

		public String CurrentState { get; set; }

		public List<MacroParameter> Parameters { get; set; }

		public List<NamedScheduleConfiguration> Specification { get; set; }

		public Double TimeZoneOffset { get; set; }

		public String MacroType { get; set; }

        /// <summary>
        /// DST migration flag.
        /// 
        ///  0 - not migrated;
        ///  1 - migrated;
        ///  2 - migration failed; 
        /// </summary>
		public Byte Migrated { get; set; }
	} 
}