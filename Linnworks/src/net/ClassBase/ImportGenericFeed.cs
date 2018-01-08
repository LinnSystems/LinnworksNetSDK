using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Net.Http;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Xml;
using System.ComponentModel;
using System.Reflection;

namespace LinnworksAPI
{ 
	public class ImportGenericFeed
	{ 
		public FeedType FeedType;
		public String Encoding;
		public Char Delimiter;
		public Char Comment;
		public Boolean HasHeaders;
		public Char Escape;
		public Char Quote;
	} 
}