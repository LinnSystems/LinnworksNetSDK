using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CancellationOptions : LinnObject
	{
		public Boolean CanCancelInternally { get; set; }

		public Boolean AutomaticRefundOnCancel { get; set; }

		public Boolean CanCancel { get; set; }

		public Boolean CanCancelOrderLines { get; set; }

		public Boolean CanCancelPartially { get; set; }

		public Boolean CanCancelFreeText { get; set; }

		public Int32 CancelFreeTextOrNoteMaxLength { get; set; }

		public ISet<ChannelReason> CancellationReasons { get; set; }

		public OrderDetails Order { get; set; }

		public OrderRefundHeader CancellationHeader { get; set; }

		public Boolean AllowRefundOnCancel { get; set; }

		public List<String> Errors { get; set; }

		public Boolean OrderIsLockedOnUnhandledError { get; set; }
	} 
}