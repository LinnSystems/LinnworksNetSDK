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
                bool docatch = true;
                
                try
                {
                    WebException wex = (WebException)ex;
                    string response;

                    using (StreamReader reader = new StreamReader(wex.Response.GetResponseStream()))
                    {
                        response=reader.ReadToEnd();
                    }

                    LinnworksAPI.Error err = null;
                    try
                    {
                        err = Newtonsoft.Json.JsonConvert.DeserializeObject<LinnworksAPI.Error>(response);
                    }
                    catch
                    {
                        docatch = false;
                        throw new Exception("Error in response from Linnworks API: " + response, ex);
                    }
                    docatch = false;
                    if (err!=null)
                        throw new LinnworksAPI.LinnworksAPIException(err.Message, err.Code, ex);
                    else
                        throw new Exception("Error in response from Linnworks API: " + response, ex);
                }
                catch when (docatch)
                {

                }
                throw;
            }
            return "";
        }
    }
}