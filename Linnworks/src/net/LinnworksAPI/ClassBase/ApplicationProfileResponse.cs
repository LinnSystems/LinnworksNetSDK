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
	public class ApplicationProfileResponse
	{ 
		public String PlanTag;
		public String PlanName;
		public DateTime ActivationDate;
		public DateTime LastPaymentDate;
		public DateTime NextPaymentDate;
		public DateTime ProfileExpires;
		public Boolean IsProfileActive;
	} 
}