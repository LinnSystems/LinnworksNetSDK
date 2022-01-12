using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LinnworksAPI
{ 
    [JsonConverter(typeof(StringEnumConverter))]
	public enum RefundValidationErrorType
	{
		None,
		MissingOrderOnChannel,
		WrongStateOnChannel,
		AdditionalRefundNotAllowed,
		ShippingRefundNotAllowed,
		ShippingRefundOnItsOwnNotAllowed,
		ItemRefundNotAllowed,
		ServiceRefundNotAllowed,
		NegativeOrZeroRefund,
		OverRefunding,
		NeedsConfirmation,
		AlreadyRefundedOnChannel,
		AlreadyRefundedInLinnworks,
		FreeTextReasonNotSupported,
		OnlyFreeTextReasonSupported,
		ReasonTagIncorrect,
		SubReasonTagIncorrect,
		ItemNotFoundInLinnworks,
		ItemNotFoundOnChannel,
		NegativeServiceItem,
		IncorrectOwnership,
		UnsupportedPaymentMethod,
		ChannelAuthenticationIssue,
		Other,
	}
}