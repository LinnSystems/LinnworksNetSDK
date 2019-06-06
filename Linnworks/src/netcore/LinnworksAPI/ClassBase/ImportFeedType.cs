using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LinnworksAPI
{ 
    [JsonConverter(typeof(StringEnumConverter))]
	public enum ImportFeedType
	{
		FTP,
		SFTP,
		HTTP,
		BUCKET,
		AMAZON_S3,
		DROPBOX,
		FTPS,
	}
}