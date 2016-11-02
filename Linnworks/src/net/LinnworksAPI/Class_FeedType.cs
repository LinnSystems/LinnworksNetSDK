using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FeedType
    {
        FTP,
        SFTP,
        HTTP,
        BUCKET,
        AMAZON_S3,
        DROPBOX,
    }
}