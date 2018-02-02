using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CustomScriptResult
	{
		public Boolean IsError;

		public String ErrorMessage;

		public Int64 TotalResults;

		public List<CustomScriptColumn> Columns;

		public List<Dictionary<String,Object>> Results;
	} 
}