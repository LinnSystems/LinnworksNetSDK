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
	public class OrderNote
	{ 
		public Guid OrderNoteId;
		public Guid OrderId;
		public DateTime NoteDate;
		public Boolean Internal;
		public String Note;
		public String CreatedBy;
		public Byte? NoteTypeId;
	} 
}