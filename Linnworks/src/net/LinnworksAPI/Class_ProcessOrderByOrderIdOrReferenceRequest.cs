using System;

namespace LinnworksAPI
{
    public class ProcessOrderByOrderIdOrReferenceRequest
    {
        public String OrderOrReferenceId;
        public Guid LocationId;
        public Boolean ScansPerformed;
        public Boolean OrderProcessingNotesAcknowledged;
        public Int32? WorkflowJobId;
    }
}