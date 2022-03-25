﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SampleChannel.Adapters;

namespace SampleChannel.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IUserConfigAdapter _userConfigAdapter;

        public OrderController(IUserConfigAdapter userConfigAdapter)
        {
            this._userConfigAdapter = userConfigAdapter;
        }

        /// <summary>
        /// This call is made by Linnworks automation to get a list of orders since the last time it
        /// requested orders. These calls are made every 10 to 15 minutes usually. The request expects
        /// a page result back, if there are a lot of orders to return it is suggested to split the
        /// result into pages of 100 maximum.
        /// </summary>
        /// <param name="request"><see cref="Models.Order.OrdersRequest#"/></param>
        /// <returns><see cref="Models.Order.OrdersResponse"/></returns>
        [HttpPost]
        public Models.Order.OrdersResponse Orders([FromBody] Models.Order.OrdersRequest request)
        {
            if (request.PageNumber <= 0)
                return new Models.Order.OrdersResponse { Error = "Invalid page number" };
            try
            {
                var user = this._userConfigAdapter.Load(request.AuthorizationToken);

                Random rand = new(DateTime.UtcNow.Millisecond);

                var orders = new List<Models.Order.Order>();

                int orderCount = 100;
                if (request.PageNumber == 11)
                {
                    orderCount = 22;
                }
                else if (request.PageNumber > 11)
                {
                    orderCount = 0;
                }

                for (int i = 1; i <= orderCount; i++)
                {
                    var order = new Models.Order.Order
                    {
                        DeliveryAddress = new Models.Order.Address
                        {
                            Address1 = "2-4 Southgate",
                            Address2 = "",
                            Address3 = "",
                            Company = "Linn Systems Ltd",
                            Country = "United Kingdom",
                            CountryCode = "GB",
                            EmailAddress = "test@test.com",
                            FullName = "Mr Testing Testington",
                            PhoneNumber = "00000000001",
                            PostCode = "PO19 8DJ",
                            Region = "West Sussex",
                            Town = "Chichester",
                        },
                        BillingAddress = new Models.Order.Address
                        {
                            Address1 = "2-4 Southgate",
                            Address2 = "",
                            Address3 = "",
                            Company = "Linn Systems Ltd",
                            Country = "United Kingdom",
                            CountryCode = "GB",
                            EmailAddress = "test@test.com",
                            FullName = "Mr Billing Billington",
                            PhoneNumber = "00000000002",
                            PostCode = "PO19 8DJ",
                            Region = "West Sussex",
                            Town = "Chichester",
                        },
                        ChannelBuyerName = "A Channel Buyer Name",
                        Currency = "GBP",
                        DispatchBy = DateTime.UtcNow.AddDays(10),
                        ExternalReference = string.Concat("MyExternalReference-", (i * request.PageNumber)),
                        ReferenceNumber = string.Concat("MyReference-", ((i * request.PageNumber) * 2)),
                        MatchPaymentMethodTag = "PayPal",
                        MatchPostalServiceTag = "Royal Mail First Class",
                        PaidOn = DateTime.UtcNow.AddMinutes(rand.Next(1, 10) * -1),
                        PaymentStatus = Models.Order.PaymentStatus.PAID,
                        PostalServiceCost = (decimal)rand.NextDouble(),
                        PostalServiceTaxRate = 20m,
                        ReceivedDate = DateTime.UtcNow.AddMinutes(rand.Next(1, 10) * -1),
                        Site = string.Empty,
                        Discount = 10,
                        DiscountType = Models.Order.DiscountType.ItemsThenPostage,
                        MarketplaceIoss = "MarketPlaceIOSS",
                        MarketplaceTaxId = "MarketPlaceTaxID"
                    };

                    int randItems = rand.Next(1, 10);
                    int randProps = rand.Next(0, 2);
                    int randNotes = rand.Next(0, 2);


                    for (int a = 0; a < randItems; a++)
                    {
                        order.OrderItems.Add(
                            new Models.Order.OrderItem
                            {
                                IsService = false,
                                ItemTitle = string.Concat("Title for ", order.ReferenceNumber, "ChannelProduct_", a * i),
                                SKU = string.Concat("ChannelProduct_", a * i),
                                LinePercentDiscount = 0,
                                PricePerUnit = (decimal)rand.NextDouble(),
                                Qty = rand.Next(),
                                OrderLineNumber = (a * i).ToString(),
                                TaxCostInclusive = true,
                                TaxRate = 20,
                                UseChannelTax = false
                            }
                        );
                    }

                    for (int a = 0; a < randProps; a++)
                    {
                        order.ExtendedProperties.Add(new Models.Order.OrderExtendedProperty { Name = string.Concat("Prop", a), Type = "Info", Value = string.Concat("Val", a) });
                    }

                    for (int a = 0; a < randNotes; a++)
                    {
                        order.Notes.Add(new Models.Order.OrderNote
                        {
                            IsInternal = false,
                            Note = string.Concat("Note - ", a),
                            NoteEntryDate = DateTime.UtcNow,
                            NoteUserName = "Channel"
                        });
                    }

                    orders.Add(order);
                }

                return new Models.Order.OrdersResponse
                {
                    Orders = orders.ToArray(),
                    HasMorePages = request.PageNumber < 11
                };
            }
            catch (Exception ex)
            {
                return new Models.Order.OrdersResponse { Error = ex.Message };
            }
        }

        /// <summary>
        /// When an order is despatched in Linnworks this call is made to update the channel with the
        /// correct despatch details. Entire orders may be submitted or partial orders depending if
        /// the order has been split.
        /// </summary>
        /// <param name="request"><see cref="Models.Order.OrderDespatchRequest"/></param>
        /// <returns><see cref="Models.Order.OrderDespatchResponse"/></returns>
        [HttpPost]
        public Models.Order.OrderDespatchResponse Despatch([FromBody] Models.Order.OrderDespatchRequest request)
        {
            if (request.Orders == null || request.Orders.Count == 0)
                return new Models.Order.OrderDespatchResponse { Error = "Invalid page number" };

            try
            {
                var user = this._userConfigAdapter.Load(request.AuthorizationToken);

                return new Models.Order.OrderDespatchResponse()
                {
                    Orders = new List<Models.Order.OrderDespatchError>()
                {
                    new Models.Order.OrderDespatchError
                    {
                        ReferenceNumber = request.Orders.First().ReferenceNumber,
                        Error = "Despatch failed for some reason"
                    }
                }
                };
            }
            catch (Exception ex)
            {
                return new Models.Order.OrderDespatchResponse { Error = ex.Message };
            }
        }
    }
}
