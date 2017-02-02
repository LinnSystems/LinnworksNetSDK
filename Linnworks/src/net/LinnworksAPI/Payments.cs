using Newtonsoft.Json;
using System;

namespace LinnworksAPI
{
    public static class PaymentsMethods
    {
        private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ" };

        public static CheckoutData GetCheckoutInformation(CheckoutRequest Request, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CheckoutData>(Factory.GetResponse("Payments/GetCheckoutInformation", "Request=" + Newtonsoft.Json.JsonConvert.SerializeObject(Request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static PaymentResponse CompleteCheckoutPayment(PaymentRequest Request, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PaymentResponse>(Factory.GetResponse("Payments/CompleteCheckoutPayment", "Request=" + Newtonsoft.Json.JsonConvert.SerializeObject(Request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}