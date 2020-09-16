// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RouteConfig.cs" company="Microsoft">
//   Copyright © 2016 Microsoft
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App.Angular
{
    using System.Web.Routing;

    using App.Angular.Routing;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.Add("Default", new DefaultRoute());
        }
    }
}
