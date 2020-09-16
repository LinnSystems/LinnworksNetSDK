using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.User
{
    public class AddNewUserRequest
    {
        public Guid LinnworksUniqueIdentifier { get; set; }
        public string Email { get; set; }
        public string AccountName { get; set; }
    }
}