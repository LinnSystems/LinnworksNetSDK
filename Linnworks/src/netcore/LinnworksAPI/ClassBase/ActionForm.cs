using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ActionForm : LinnObject
	{
		public String Caption { get; set; }

		public List<ActionFormControl> Controls { get; set; }
	} 
}