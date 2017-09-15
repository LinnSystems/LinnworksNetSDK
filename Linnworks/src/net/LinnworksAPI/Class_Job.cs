using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class Job
    {
        public Int32 JobId;
        public Int32 GroupId;
        public String Name;
        public JobStatus Status;
        public Int32 OrderCount;
        public Int32 AttachmentCount;
        public Boolean IsError;
        public Boolean IsAllPrinted;
        public DateTime CreatedDate;
        public String ExecutedByUser;
        public DateTime ExecutionDate;
        public List<JobAttachment> JobAttachmentList;
        public List<JobOrder> OrderList;
    }
}