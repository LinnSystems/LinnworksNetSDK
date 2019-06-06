using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CancellationRequest
	{
		public Boolean IsChannelCancellation;

		public Boolean IsChannelCancellationConfirmed;

		public Boolean IsFreeText;

		public String FreeTextOrNote;

		public String ReasonTag;

		public String SubReasonTag;

		public Boolean CreateFullRefund;

		public Int32 HeaderId;

		public Guid OrderId;

		public ActionForm ActionForm;
	} 
}