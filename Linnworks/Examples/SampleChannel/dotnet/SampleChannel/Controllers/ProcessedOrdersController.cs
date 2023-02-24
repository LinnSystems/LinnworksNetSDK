using Microsoft.AspNetCore.Mvc;
using System;
using SampleChannel.Adapters;
using SampleChannel.Models.PostSale;
using SampleChannel.Models;

namespace SampleChannel.Controllers
{
    [Route("api/processedorders")]
    [ApiController]
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
        [HttpPost("postsaleoptions")]
        public Models.PostSale.PostSaleOptionsResponse PostSaleOptions([FromBody] Models.BaseRequest request)
        {
            try
            {
                var user = this._userConfigAdapter.Load(request.AuthorizationToken);

                // Add the correct values to the response here. this is a sample response
                var response =  new Models.PostSale.PostSaleOptionsResponse()
                {
                    AutomaticRefundOnCancel = true,
                    CanAttachRefundToItem = true,
                    PostSaleReasons = new System.Collections.Generic.List<PostSaleReasons>()
                    { { new PostSaleReasons(){ DisplayName = "Unknown Reason", Types = new System.Collections.Generic.List<ChannelReasonType>()
                    { ChannelReasonType.ItemRefund, ChannelReasonType.ServiceRefund, ChannelReasonType.Cancellation, ChannelReasonType.ItemReturn, ChannelReasonType.ShippingRefund } , Tag = "UnknownReason" } },
                    { new PostSaleReasons(){ DisplayName = "Item Return Reason", Types = new System.Collections.Generic.List<ChannelReasonType>()
                    {  ChannelReasonType.ItemReturn } , Tag = "ItemReturnReason" } },
                    { new PostSaleReasons(){ DisplayName = "Incorrect shipping", Types = new System.Collections.Generic.List<ChannelReasonType>()
                    { ChannelReasonType.ShippingRefund }, Tag = "IncorrectShipping" } }},
                    CanCancel = true,
                    CanCancelOrderLines = true,
                    CanAttachRefundToService = true,
                    CanRefund = true,
                    CanRefundAdditionally = false,
                    CanCancelOrderLinesPartially = true,
                    RefundShippingTypes = ShippingRefundType.Independent,
                    CanReturn = true
                };

                return response;
            }
            catch (Exception ex)
            {
                return new Models.PostSale.PostSaleOptionsResponse { Error = ex.Message };
            }
        }

        [HttpPost("cancel")]
        public BaseResponse Cancel(OrderCancelRequest request)
        {
            //convert the request here to a form the channel understands, and sent it to channel

            //the return the response or error
            return new BaseResponse();
        }

        [HttpPost("refund")]
        public OrderRefundResponse Refund(OrderRefundRequest request)
        {
            //convert the request here to a form the channel understands, and sent it to channel

            //the return the response or error
            return new OrderRefundResponse()
            {
                RefundReference = "test123"
            };
        } 
    }
}
