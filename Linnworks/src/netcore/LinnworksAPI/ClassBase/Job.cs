using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Job
	{
		public Int32 JobId { get; set; }

		public Int32 GroupId { get; set; }

		public String Name { get; set; }

		public JobStatus Status { get; set; }

		public Int32 OrderCount { get; set; }

		public Int32 AttachmentCount { get; set; }

		public Boolean IsError { get; set; }

		public Boolean IsAllPrinted { get; set; }

		public DateTime CreatedDate { get; set; }

		public String ExecutedByUser { get; set; }

		public DateTime ExecutionDate { get; set; }

		public List<JobAttachment> JobAttachmentList { get; set; }

		public List<JobOrder> OrderList { get; set; }
	} 
}