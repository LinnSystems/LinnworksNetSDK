using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class TemplateToProcess : LinnObject
	{
		public Int32 TemplateId { get; set; }

		public TemplateProcessAction Action { get; set; }
	} 
}