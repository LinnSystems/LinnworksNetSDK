using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetImportListResponse : LinnObject
	{
		public List<ImportRegisterPublicSchedules> register { get; set; }
	} 
}