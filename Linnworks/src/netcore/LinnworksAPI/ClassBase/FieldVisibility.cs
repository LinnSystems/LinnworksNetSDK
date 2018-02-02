using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class FieldVisibility
	{
		public String Name;

		public Boolean Visible;

		public Boolean CanFilter;

		public Boolean CanSort;

		public FieldTypes FieldType;

		public FieldCode Code;

		public List<FieldVisibility> SubFields;

        /// <summary>
        /// Defines if the field can only be used as a filter 
        /// </summary>
		public Boolean IsFilterOnly;

		public String HotButtonIcon;

		public String HotButtonKey;
	} 
}