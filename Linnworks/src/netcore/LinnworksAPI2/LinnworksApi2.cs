using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinnworksAPI2
{
    public class LinnworksApi2
    {
        private WarehouseTransferV1.WarehouseTransferV1 warehouseTransferV1;
        private WarehouseTransferV2.WarehouseTransferV2 warehouseTransferV2;

        private readonly HttpClient _client;

        /// <summary>
        /// Construct an instance of LinnworksApi2 using the Authorization token (generated from AuthorizeByApplication)
        /// Pass in the url for the api, which depends on the region
        /// </summary>
        /// <param name="token"></param>
        /// <param name="url"></param>
        public LinnworksApi2(Guid token, string url)
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(url);
            _client.DefaultRequestHeaders.Add("Authorization", token.ToString());
        }

        public WarehouseTransferV1.WarehouseTransferV1 WarehouseTransferV1API => warehouseTransferV1 ??= new WarehouseTransferV1.WarehouseTransferV1(_client);
        public WarehouseTransferV2.WarehouseTransferV2 WarehouseTransferV2API => warehouseTransferV2 ??= new WarehouseTransferV2.WarehouseTransferV2(_client);

    }
}