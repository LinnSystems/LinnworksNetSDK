using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Channel_Setting_Audit
	{
		public Int32 pkAuditId { get; set; }

		public Int32 fkChannelId { get; set; }

		public String PropertyName { get; set; }

		public String PropertyValueIs { get; set; }

		public DateTime AuditDateTime { get; set; }

		public String UserName { get; set; }
	} 
}