using System;

namespace LinnworksAPI
{
    public abstract class BaseController : IBaseController
    {
        private ApiContext ApiContext { get; set; }

        public BaseController(ApiContext apiContext)
        {
            ApiContext = apiContext;
        }

        public string GetResponse(string extension, string body, string httpMethod = "POST", int? timeout = null)
        {
            var response = Factory.GetResponse(extension, body, ApiContext, httpMethod, timeout);
            return response;
        }
    }

    public interface IBaseController
    {
        string GetResponse(string extension, string body, string httpMethod = "POST", int? timeout = null);
    }
}
