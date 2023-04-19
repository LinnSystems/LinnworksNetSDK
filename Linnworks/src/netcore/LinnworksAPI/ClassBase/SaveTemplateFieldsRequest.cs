using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class SaveTemplateFieldsRequest : LinnObject
	{
		public ChannelType ChannelType { get; set; }

		public String ChannelName { get; set; }

		public Int32 TemplateId { get; set; }

        /// <summary>
        /// info key : value 
        /// </summary>
		public Dictionary<String,Object> FieldsToSave { get; set; }
	} 
}