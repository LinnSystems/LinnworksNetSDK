using System.Collections.Generic;
using System.Text;

namespace LinnworksMacroHelpers.Classes
{
    public sealed class ProxiedWebResponse
    {
        public string ErrorMessage { get; set; }
        public byte[] RawResponse { get; set; }
        public Dictionary<string, string> Headers { get; set; } = new Dictionary<string, string>();
        public int StatusCode { get; set; }
        public string CharacterSet { get; set; }
        public string ContentType { get; set; }
        public string ContentEncoding { get; set; }

        public string GetStringResponse(Encoding encoding = null)
        {
            return (encoding ?? Encoding.UTF8).GetString(RawResponse);
        }
    }
}
