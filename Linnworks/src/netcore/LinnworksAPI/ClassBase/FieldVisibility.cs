using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class FieldVisibility
	{
		public String Name { get; set; }

		public Boolean Visible { get; set; }

		public Boolean CanFilter { get; set; }

		public Boolean CanSort { get; set; }

		public FieldTypes FieldType { get; set; }

		public FieldCode Code { get; set; }

		public List<FieldVisibility> SubFields { get; set; }

        /// <summary>
        /// Defines if the field can only be used as a filter 
        /// </summary>
		public Boolean IsFilterOnly { get; set; }

		public String HotButtonIcon { get; set; }

		public String HotButtonKey { get; set; }
	} 
}