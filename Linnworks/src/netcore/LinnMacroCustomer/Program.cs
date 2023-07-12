using System;

namespace LinnMacroCustomer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Replace the following with your application details and installation token
            Guid applicationId = Guid.NewGuid();
            Guid secretKey = Guid.NewGuid();
            Guid token = Guid.NewGuid();

            var macro = SetupMacro(applicationId, secretKey, token);

            var result = macro.Execute(new Guid("37d8fb79-4eea-401b-911a-d5cb04db61a4"));

            if (result == null)
            {
                Console.WriteLine("Stock item not found");
            }
            else
            {
                Console.WriteLine(result.ItemNumber);
            }
            Console.Read();
        }

        private static LinnworksAPI.BaseSession Authorize(Guid applicationId, Guid secretKey, Guid token)
        {
            var controller = new LinnworksAPI.AuthController(new LinnworksAPI.ApiContext("https://api.linnworks.net"));

            return controller.AuthorizeByApplication(new LinnworksAPI.AuthorizeByApplicationRequest
            {
                ApplicationId = applicationId,
                ApplicationSecret = secretKey,
                Token = token
            });
        }

        private static LinnworksMacro.LinnworksMacro SetupMacro(Guid applicationId, Guid secretKey, Guid token)
        {
            var auth = Authorize(applicationId, secretKey, token);

            var context = new LinnworksAPI.ApiContext(auth.Token, auth.Server);

            var url = new Api2Helper().GetUrl(context.ApiServer);

            var macro = new LinnworksMacro.LinnworksMacro()
            {
                Api = new LinnworksAPI.ApiObjectManager(context),
                Api2 = new LinnworksAPI2.LinnworksApi2(auth.Token, url),
                Logger = new LoggerProxy(),
            };

            return macro;
        }
    }
}
