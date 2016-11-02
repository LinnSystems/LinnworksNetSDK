using Newtonsoft.Json;
using System;

namespace LinnworksAPI
{
    public static class PaymentsMethods
    {
        public static CheckoutData GetCheckoutInformation(CheckoutRequest Request, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CheckoutData>(Factory.GetResponse("Payments/GetCheckoutInformation", "Request=" + Newtonsoft.Json.JsonConvert.SerializeObject(Request) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static PaymentResponse CompleteCheckoutPayment(PaymentRequest Request, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PaymentResponse>(Factory.GetResponse("Payments/CompleteCheckoutPayment", "Request=" + Newtonsoft.Json.JsonConvert.SerializeObject(Request) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}