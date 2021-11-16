using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateProxyExample.Config;

namespace TemplateProxyExample.Controllers
{
    public class ProcessedOrdersController : BaseController
    {
        public ProcessedOrdersController(IOptions<AppSettings> config) : base(config)
        {
        }

        /// <summary>
        /// This call is made when creating an RMA or refund request for orders from this channel.
        /// It allows you to determine what kinds of refunds and returns are supported on the channel,
        /// so that the UI is presented accordingly.
        /// </summary>
        /// <param name="request"><see cref="Models.BaseRequest"/></param>
        /// <returns><see cref="Models.PostSale.PostSaleOptionsResponse"/></returns>
        [HttpPost]
        public Models.PostSale.PostSaleOptionsResponse PostSaleOptions([FromBody] Models.BaseRequest request)
        {
            try
            {
                var user = new Models.User.UserConfig(this.FileRepository, request.AuthorizationToken);

                var response = new Models.PostSale.PostSaleOptionsResponse();

                // Add the correct values to the response here.

                return response;
            }
            catch (Exception ex)
            {
                return new Models.PostSale.PostSaleOptionsResponse { Error = ex.Message };
            }
        }
    }
}
