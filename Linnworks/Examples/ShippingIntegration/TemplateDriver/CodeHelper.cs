using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Web;

namespace TemplateDriver
{
    public static class CodeHelper
    {
        public static string MaxLenght(string val, int max) {
            if (val.Length > max)
            {
                return val.Substring(0, max);
            }
            else {
                return val;
            }
        }

        public static string FormatAddress(Models.GenerateLabelRequest request) {
            System.Text.StringBuilder addressOutput = new System.Text.StringBuilder();

            addressOutput.AppendLine(request.Name);
            addressOutput.AppendLine(request.CompanyName);
            addressOutput.AppendLine(request.AddressLine1);
            addressOutput.AppendLine(request.AddressLine2);
            addressOutput.AppendLine(request.Town);
            addressOutput.AppendLine(request.Region);
            addressOutput.AppendLine(request.Postalcode.ToUpper());

            return addressOutput.ToString();
        }
        
                
    }
}