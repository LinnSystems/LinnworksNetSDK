using System;
using System.Collections.Generic;

namespace LinnAppFramework.Classes
{
    public static class SessionHandler
    {
        private static List<ClientSession> Sessions = new List<ClientSession>();

        /// <summary>
        /// Attempts to create a new session with a token
        /// </summary>
        /// <param name="Token"></param>
        /// <returns></returns>
        public static Classes.Core.GenericTypedResponse<ClientSession> CreateSession(Guid Token)
        {
            var session = LinnInterop.GetSession(Token);

            if (session.IsError)
            {
                return new Core.GenericTypedResponse<ClientSession>() { IsError = true, Error = "Couldn't create a session. Check token." };
            }
            else
            {
                ClientSession sess = new ClientSession() { LinnworksSessionId = Guid.NewGuid(), Session = session.Data };
                Sessions.Add(sess);

                return new Core.GenericTypedResponse<ClientSession>() { Data = sess };
            }
        }

        /// <summary>
        /// Gets a session from the sessioo
        /// </summary>
        /// <param name="LinnworksSessionId"></param>
        /// <returns></returns>
        public static LinnworksAPI.BaseSession GetSession(Guid LinnworksSessionId)
        {
            foreach (var session in Sessions)
            {
                if (session.LinnworksSessionId == LinnworksSessionId)
                {
                    return session.Session;
                }
            }

            return null;
        }
    }
}