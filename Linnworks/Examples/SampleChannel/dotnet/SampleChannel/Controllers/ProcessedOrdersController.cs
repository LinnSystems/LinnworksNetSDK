using Microsoft.AspNetCore.Mvc;
using System;
using SampleChannel.Adapters;

namespace SampleChannel.Controllers
{
    public class ProcessedOrdersController : ControllerBase
    {
        private readonly IUserConfigAdapter _userConfigAdapter;

        public ProcessedOrdersController(IUserConfigAdapter userConfigAdapter)
        {
            this._userConfigAdapter = userConfigAdapter;
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
                var user = this._userConfigAdapter.Load(request.AuthorizationToken);

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
