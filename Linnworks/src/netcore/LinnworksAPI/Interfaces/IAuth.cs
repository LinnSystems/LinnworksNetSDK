using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{ 
    public interface IAuthController
	{
		BaseSession AuthorizeByApplication(AuthorizeByApplicationRequest request);
		ApplicationProfileResponse GetApplicationProfileBySecretKey(Guid applicationId,Guid applicationSecret,Guid userId);
		DateTime GetServerUTCTime();
	} 
}