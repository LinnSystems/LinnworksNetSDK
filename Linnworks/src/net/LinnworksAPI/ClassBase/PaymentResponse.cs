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
	public class PaymentResponse
	{ 
		public PaymentStatus CurrentStatus;
		public String Message;
		public String TransactionId;
		public String ProfileId;
		public CheckoutRequest CheckoutRequest;
		public CheckoutData CheckoutData;
	} 
}