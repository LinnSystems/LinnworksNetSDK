using System;
using System.Collections.Generic;
using System.Text;

namespace LinnworksMacroHelpers.Classes
{
    public sealed class ProxiedWebRequest
    {
        /// <summary>
        /// Url to be requested from.
        /// </summary>
        public string Url { get; set; } = string.Empty;

        /// <summary>
        /// List of headers to be past to url.
        /// </summary>
        public Dictionary<string, string> Headers { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// Gets or sets the method for the request.
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// Timeout of the webrequest in miliseconds, maximum value of 60 seconds.
        /// </summary>
        public int Timeout { get; set; } = 30000;

        /// <summary>
        /// Body of the request.
        /// </summary>
        public byte[] RawBody { get; set; }

        /// <summary>
        /// Content type of request.
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the valid of the Referrer header.
        /// </summary>
        public string Referrer { get; set; }

        /// <summary>
        /// Validates that the webrequest meets minimum requirements. This will be called when WebRequest method is called.
        /// </summary>
        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(Url))
                throw new Exception("Url is empty");

            if (!Uri.IsWellFormedUriString(Url, UriKind.RelativeOrAbsolute))
                throw new Exception("Url is not well formed");

            if (RawBody?.Length > 1048576)
                throw new Exception("RawBody cannot be larger than 10mb");

            if (Headers?.ContainsKey("Content-Type") == true)
                throw new Exception($"Please use {nameof(ContentType)} property rather than adding Content-Type as a seperate.");
        }

        /// <summary>
        /// Sets RawBody from string value, if encoding is not supplied default is UTF8
        /// </summary>
        /// <param name="value"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public void WithStringBody(string value, Encoding encoding = null)
        {
            if (encoding == null)
                encoding = Encoding.UTF8;

            RawBody = encoding.GetBytes(value);
        }
    }
}
