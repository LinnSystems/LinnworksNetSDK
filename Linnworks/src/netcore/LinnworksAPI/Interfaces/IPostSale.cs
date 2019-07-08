using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{ 
    public interface IPostSaleController
	{
		ValidatedCancellation CreateCancellation(CancellationRequest request);
	} 
}