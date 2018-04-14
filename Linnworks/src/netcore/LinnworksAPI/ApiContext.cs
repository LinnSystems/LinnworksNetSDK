using System;

namespace LinnworksAPI
{
    public class ApiContext
    {
        public string ApiServer { get; private set; }
        public Guid SessionId { get; private set; }
        public int RecursionCount { get; set; }

        public ApiContext(Guid sessionId, string apiServer, int recursionCount) 
            : this(sessionId, apiServer)
        {
            this.RecursionCount = recursionCount;
        }

        public ApiContext(Guid sessionId, string apiServer)
        {
            if (sessionId == Guid.Empty)
                throw new ArgumentNullException(nameof(sessionId), "SessionId is missing");

            if (string.IsNullOrWhiteSpace(apiServer))
                throw new ArgumentNullException(nameof(apiServer), "ApiServer is missing");

            this.SessionId = sessionId;
            this.ApiServer = apiServer + (apiServer.EndsWith("/api/") ? "" : "/api/");
        }

        public ApiContext(string apiServer)
        {
            if (string.IsNullOrWhiteSpace(apiServer))
                throw new ArgumentNullException(nameof(apiServer), "ApiServer is missing");

            this.SessionId = Guid.Empty;
            this.ApiServer = apiServer + (apiServer.EndsWith("/api/") ? "" : "/api/");
        }
    }
}
