using System;
using System.Collections.Generic;
using System.Text;

namespace LinnworksAPI2.WarehouseTransferV1
{
    public partial class WarehouseTransferV1
    {
        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, string url)
        {
            string[] oldString = url.Split(new[] { "/api/" }, StringSplitOptions.None);
            url = url.Replace(oldString[0], client.BaseAddress.ToString() + "/warehousetransfer");
            request.RequestUri = new Uri(url);
        }
    }
}
