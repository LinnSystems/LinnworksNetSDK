using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderViewStats
	{
		public Int32 ViewId { get; set; }

		public String ViewName { get; set; }

		public Boolean IsSystem { get; set; }

		public Int64 TotalOrders { get; set; }

		public Guid LocationId { get; set; }

		public DateTime ExpiryDate { get; set; }

		public Boolean IsCalculating { get; set; }

		public Boolean ViewExists { get; set; }

		public DateTime? LastRequested { get; set; }

		public ViewUserManagement UserManagement { get; set; }

		public OrderViewUserPreference OrderViewUserPreference { get; set; }

		public ViewUser Owner { get; set; }

		public Boolean IsCacheable { get; set; }
	} 
}