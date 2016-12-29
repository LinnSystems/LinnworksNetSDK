using System;
using System.IO;
using System.Net;

public static class Factory
{

    public static string SerializeAndUrlEscape(object o)
    {
        //doesn't work! return System.Web.HttpUtility.UrlEncode(Newtonsoft.Json.JsonConvert.SerializeObject(o));
        return Newtonsoft.Json.JsonConvert.SerializeObject(o).Trim('\"');
    }

    public static string GetResponse(string Extension, string Body, string Token, string Server)
    {
        if (string.IsNullOrEmpty(Server))
        {
            Server = "https://api.linnworks.net/api/";
        }
        else
        {
            Server += "/api/";
        }

        HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(Server + Extension);

        Request.ContentType = "application/x-www-form-urlencoded";
        Request.Method = "POST";

        if (!string.IsNullOrEmpty(Token))
        {
            Request.Headers.Add("Authorization", Token);
        }

        using (StreamWriter writer = new StreamWriter(Request.GetRequestStream()))
        {
            writer.Write(Body);
        }

        try
        {
            using (StreamReader reader = new StreamReader(Request.GetResponse().GetResponseStream()))
            {
                return reader.ReadToEnd();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            if (LinnworksAPI.ClientConfig.ThrowExceptions)
            {
                throw;
            }
            return "";
        }
    }
}