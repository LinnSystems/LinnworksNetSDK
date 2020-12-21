using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
using System.Threading.Tasks;

namespace LinnworksAPI
{ 
    public interface IOpenOrdersController
	{
		AssignResult AssignOrderIdentifier(ChangeOrderIdentifierRequest request);
		AssignResult UnassignOrderIdentifier(ChangeOrderIdentifierRequest request);
	} 
}