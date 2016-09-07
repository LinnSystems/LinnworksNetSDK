using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LinnAppFramework.Controllers
{
    public class MainController : Classes.AppController
    {
        /// <summary>
        /// Your main page.This page is protected, so requires for people to log in. Notice the attributes.
        /// </summary>
        /// <returns></returns>
        [Classes.Auth]
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Shows a few simple stats in order to provide a usage concept for the LinnworksNetSDK
        /// </summary>
        /// <returns></returns>
        [Classes.Auth]
        public ActionResult Data()
        {
            var session = GetLinnworksSesion();

            Dictionary<string, Dictionary<string, string>> stats = new Dictionary<string, Dictionary<string, string>>();

            // Get stock locations information
            var locations = LinnworksAPI.InventoryMethods.GetStockLocations(session.Token, session.Server);

            Dictionary<string, string> locationsStats = new Dictionary<string, string>();

            locationsStats.Add("You have a total of {0} locations on your Linnworks.net Account.", locations.Count.ToString());

            stats.Add("Your Stock Locations..", locationsStats);

            // Get open orders information
            Dictionary<string, string> ordersStats = new Dictionary<string, string>();

            var openOrders = LinnworksAPI.OrdersMethods.GetOpenOrders(2000, 1, new LinnworksAPI.FieldsFilter(), new List<LinnworksAPI.FieldSorting>(), Guid.Empty, "", session.Token, session.Server);

            ordersStats.Add("You have a total of {0} orders currently open in your Default location.", openOrders.Data.Count.ToString());

            stats.Add("Your Orders..", ordersStats);

            ViewBag.Stats = stats;
            return View();
        }
    }
}