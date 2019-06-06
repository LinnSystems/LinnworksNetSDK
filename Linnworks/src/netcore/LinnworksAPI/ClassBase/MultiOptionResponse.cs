using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class MultiOptionResponse
	{
        /// <summary>
        /// Evaluation field 
        /// </summary>
		public String Field;

        /// <summary>
        /// Evaluation key 
        /// </summary>
		public String Key;

        /// <summary>
        /// Evaluation options 
        /// </summary>
		public List<String> Options;

		public List<OptionBase> KeyedOptions;
	} 
}