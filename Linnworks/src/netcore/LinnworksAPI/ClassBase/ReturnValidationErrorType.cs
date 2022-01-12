using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LinnworksAPI
{ 
    [JsonConverter(typeof(StringEnumConverter))]
	public enum ReturnValidationErrorType
	{
		None,
		MissingOrderOnChannel,
		WrongStateOnChannel,
		NegativeOrZeroReturnQuantity,
		OverReturning,
		NeedsConfirmation,
		AlreadyReturnedOnChannel,
		AlreadyReturnedInLinnworks,
		FreeTextReasonNotSupported,
		OnlyFreeTextReasonSupported,
		ReasonTagIncorrect,
		SubReasonTagIncorrect,
		ItemNotFoundInLinnworks,
		ItemNotFoundOnChannel,
		IncorrectOwnership,
		InvalidRefundAmount,
		UnsupportedPaymentMethod,
		ChannelAuthenticationIssue,
		Other,
	}
}