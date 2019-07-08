using System;
using System.IO;
using System.Net;

namespace LinnworksAPI
{
    public class Factory
    {
        public static string GetResponse(string extension, string body, ApiContext context, string httpMethod)
        {
            string url = context.ApiServer + extension;
            var req = HttpWebRequest.Create(url);
            req.Method = httpMethod;
            req.ContentType = "application/x-www-form-urlencoded";
            req.Headers.Add("RecursionCount", context.RecursionCount.ToString());

            if (context.SessionId != Guid.Empty)
                req.Headers.Add(HttpRequestHeader.Authorization, context.SessionId.ToString());

            if (!string.IsNullOrWhiteSpace(body))
            {
                req.ContentLength = body.Length;
                using (Stream post = req.GetRequestStream())
                {
                    using (StreamWriter writer = new StreamWriter(post))
                    {
                        writer.Write(body);
                    }
                }
            }

            var response = (HttpWebResponse)req.GetResponse();
            string responseBody = "";

            using (StreamReader sr = new StreamReader(response.GetResponseStream()))
            {
                responseBody = sr.ReadToEnd();
            }

            if ((int)response.StatusCode < 200 || (int)response.StatusCode > 299)
            {
                var error = JsonFormatter.ConvertFromJson<ApiError>(responseBody);
                throw new Exception(error.Message);
            }

            return responseBody;
        }

        public class ApiError
        {
            public string Message { get; set; }
        }
    }
}
