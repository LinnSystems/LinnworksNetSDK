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
	public class JobAudit
	{ 
		public Int32 JobAuditId;
		public Int32 JobId;
		public JobAuditType Type;
		public DateTime Date;
		public String Note;
		public String User;
	} 
}