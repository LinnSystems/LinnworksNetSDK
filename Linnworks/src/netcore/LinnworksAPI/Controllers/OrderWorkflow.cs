using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{
    public class OrderWorkflowController : BaseController, IOrderWorkflowController
    {
        public OrderWorkflowController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Checkin and start order allocation 
        /// </summary>
        /// <param name="request"></param>
        public CheckinUserResponse CheckinUser(CheckinUserRequest request)
		{
			var response = GetResponse("OrderWorkflow/CheckinUser", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<CheckinUserResponse>(response);
		}

		/// <summary>
        /// Remove order from a job 
        /// </summary>
        /// <param name="request"></param>
        public DeallocateOrderFromJobResponse DeallocateOrderFromJob(DeallocateOrderFromJobRequest request)
		{
			var response = GetResponse("OrderWorkflow/DeallocateOrderFromJob", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<DeallocateOrderFromJobResponse>(response);
		}

		/// <summary>
        /// Get specific group by id. Detailed information about a group is returned 
        /// </summary>
        /// <param name="request"></param>
        public GetGroupResponse GetGroup(GetGroupRequest request)
		{
			var response = GetResponse("OrderWorkflow/GetGroup", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetGroupResponse>(response);
		}

		/// <summary>
        /// Returns a list of all groups in all workflows for all locations. The returned value does not contain group action and group conditions 
        /// </summary>
        /// <param name="request"></param>
        public GetGroupListResponse GetGroupList(GetGroupListRequest request)
		{
			var response = GetResponse("OrderWorkflow/GetGroupList", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetGroupListResponse>(response);
		}

		/// <summary>
        /// Get specific job details. This method will return list of order ids in a job. 
        /// </summary>
        /// <param name="request">Request class</param>
        /// <returns>Detailed Job class with order ids and all attachments</returns>
        public GetJobResponse GetJob(GetJobRequest request)
		{
			var response = GetResponse("OrderWorkflow/GetJob", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetJobResponse>(response);
		}

		/// <summary>
        /// Get job audit trail 
        /// </summary>
        /// <param name="request">Request class</param>
        /// <returns>List of audit trail rows</returns>
        public GetJobAuditResponse GetJobAudit(GetJobAuditRequest request)
		{
			var response = GetResponse("OrderWorkflow/GetJobAudit", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetJobAuditResponse>(response);
		}

		/// <summary>
        /// Get specific job details. This method will return list of order ids in a job. 
        /// </summary>
        /// <param name="request">Request class</param>
        /// <returns>Detailed Job class with order ids and all attachments</returns>
        public GetJobResponse GetJobByName(GetJobByNameRequest request)
		{
			var response = GetResponse("OrderWorkflow/GetJobByName", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetJobResponse>(response);
		}

		/// <summary>
        /// Get job errors 
        /// </summary>
        /// <param name="request"></param>
        public GetJobErrorsResponse GetJobErrors(GetJobErrorsRequest request)
		{
			var response = GetResponse("OrderWorkflow/GetJobErrors", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetJobErrorsResponse>(response);
		}

		/// <summary>
        /// Marks the attachment as printed, reprints document if its not available anymore and returns the URL of the document to be downloaded 
        /// </summary>
        /// <param name="request"></param>
        public GetPrintAttachmentResponse GetPrintAttachment(GetPrintAttachmentRequest request)
		{
			var response = GetResponse("OrderWorkflow/GetPrintAttachment", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetPrintAttachmentResponse>(response);
		}

		/// <summary>
        /// Get workflow groups and jobs per location. This call will return all groups available to the user. 
        /// Group header only contains essential information for displaying the number of jobs to do, total number of orders in the group. Things like Conditions and Action lists are not returned as part of this call.
        /// Jobs - only header of a job is returned, actual list of order ids will be empty in this call. You will need to use GetJob to get actual list of orders allocated to the job 
        /// </summary>
        /// <param name="request">Get workflow request</param>
        /// <returns>List of workflow groups with jobs</returns>
        public GetWorkflowResponse GetWorkflow(GetWorkflowRequest request)
		{
			var response = GetResponse("OrderWorkflow/GetWorkflow", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetWorkflowResponse>(response);
		}

		/// <summary>
        /// Run the specified jobs 
        /// </summary>
        /// <param name="request">Job id to run</param>
        public RunResponse Run(RunJobsRequest request)
		{
			var response = GetResponse("OrderWorkflow/Run", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<RunResponse>(response);
		}

		/// <summary>
        /// Update group name, condition, list of actions 
        /// </summary>
        /// <param name="request">Definition of updated fields of a specific group</param>
        /// <returns>Updated group object</returns>
        public UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
		{
			var response = GetResponse("OrderWorkflow/UpdateGroup", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<UpdateGroupResponse>(response);
		} 
    }
}