using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ViewUserManagement
	{
		public Int32 ViewId { get; set; }

		public List<ViewUser> ViewUsers { get; set; }

		public List<ViewGroup> ViewGroups { get; set; }
	} 
}