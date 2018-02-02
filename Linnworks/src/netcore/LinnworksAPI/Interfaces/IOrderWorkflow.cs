using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{ 
    public interface IOrderWorkflowController
	{
		CheckinUserResponse CheckinUser(CheckinUserRequest request);
		DeallocateOrderFromJobResponse DeallocateOrderFromJob(DeallocateOrderFromJobRequest request);
		GetGroupResponse GetGroup(GetGroupRequest request);
		GetGroupListResponse GetGroupList(GetGroupListRequest request);
		GetJobResponse GetJob(GetJobRequest request);
		GetJobAuditResponse GetJobAudit(GetJobAuditRequest request);
		GetJobResponse GetJobByName(GetJobByNameRequest request);
		GetJobErrorsResponse GetJobErrors(GetJobErrorsRequest request);
		GetPrintAttachmentResponse GetPrintAttachment(GetPrintAttachmentRequest request);
		GetWorkflowResponse GetWorkflow(GetWorkflowRequest request);
		RunResponse Run(RunJobsRequest request);
		UpdateGroupResponse UpdateGroup(UpdateGroupRequest request);
	} 
}