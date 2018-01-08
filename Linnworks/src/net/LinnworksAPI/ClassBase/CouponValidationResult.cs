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
	public class CouponValidationResult
	{ 
		public String ValidationText;
		public Boolean DeductVisible;
		public String DeductText;
		public Boolean BalanceVisible;
		public String BalanceText;
		public String ValueText;
		public String DiscountType;
	} 
}