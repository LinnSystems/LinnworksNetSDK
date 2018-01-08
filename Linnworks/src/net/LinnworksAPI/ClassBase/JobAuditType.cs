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
{ [JsonConverter(typeof(StringEnumConverter))]
public enum JobAuditType
{ JOB_RUN,
JOB_STATUS_UPDATED,
JOB_ERROR,
JOB_DELETED,
JOB_ORDER_ADDED,
JOB_ADDED,
JOB_ORDER_REMOVED,
JOB_ATTACHMENT_PRINTED,
JOB_PROGREES_REPORT,
 
} 
}