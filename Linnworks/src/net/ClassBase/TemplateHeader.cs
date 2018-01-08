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
	public class TemplateHeader
	{ 
		public Int32 pkTemplateRowId;
		public Guid TemplateId;
		public String TemplateType;
		public String TemplateName;
		public Boolean Enabled;
		public Boolean IsDefault;
		public Boolean IsEmailAttachment;
		public String VisibilityCondition;
		public Boolean bLogicalDelete;
		public Boolean IsConditional;
		public Int32 ConditionRating;
	} 
}