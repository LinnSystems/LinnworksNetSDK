using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetExportListResponse : LinnObject
	{
		public List<ExportRegisterPublicSchedules> register { get; set; }
	} 
}