using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.User
{
    public class AddNewUserRequest
    {
        /// <summary>
        /// Uniqueidentifer of the linnworks customer's account. Will never change.
        /// </summary>
        public Guid LinnworksUniqueIdentifier { get; set; }

        /// <summary>
        /// Email of the customer, subject to change.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Account name being integrated into the system. Will never change and on integration it
        /// is suggest that duplicates are checked for. Nb. Customers may expect to have multiple
        /// integrations of the same channel in Linnworks.
        /// </summary>
        public string AccountName { get; set; }
    }
}