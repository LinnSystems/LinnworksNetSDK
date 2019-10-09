using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Channel_Setting_Audit
	{
		public Int32 pkAuditId;

		public Int32 fkChannelId;

		public String PropertyName;

		public String PropertyValueIs;

		public DateTime AuditDateTime;

		public String UserName;
	} 
}