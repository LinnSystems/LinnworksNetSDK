using System;
using System.IO;
using System.Net;

public static class Factory
{
    public static string GetResponse(string Extension, string Body, Guid Token, string Server)
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

        if (Token != Guid.Empty)
        {
            Request.Headers.Add("Authorization", Token.ToString());
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
            return "";
        }
    }
}