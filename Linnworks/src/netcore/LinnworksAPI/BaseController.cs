using System;

namespace LinnworksAPI
{
    public abstract class BaseController : IBaseController
    {
        private ApiContext ApiContext { get; set; }

        public BaseController(ApiContext apiContext)
        {
            this.ApiContext = apiContext;
        }

        public string GetResponse(string extension, string body)
        {
            var response = Factory.GetResponseAsync(extension, body, ApiContext);
            return response.Result;
        }
    }

    public interface IBaseController
    {
        string GetResponse(string extension, string body);
    }
}
