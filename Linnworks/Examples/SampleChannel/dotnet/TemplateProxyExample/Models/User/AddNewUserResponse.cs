using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.User
{
    public class AddNewUserResponse : BaseResponse
    {
        public string AuthorizationToken { get; set; }
    }
}