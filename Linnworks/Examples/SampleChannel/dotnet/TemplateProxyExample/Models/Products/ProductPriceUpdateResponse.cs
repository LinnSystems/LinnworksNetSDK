﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.Products
{
    public class ProductPriceUpdateResponse : BaseResponse
    {
        public ProductPriceUpdateResponse()
        {
            this.Products = new List<ProductPriceResponse>();
        }

        /// <summary>
        /// List of responses <see cref="ProductPriceResponse"/>
        /// </summary>
        public List<ProductPriceResponse> Products { get; set; }
    }
}