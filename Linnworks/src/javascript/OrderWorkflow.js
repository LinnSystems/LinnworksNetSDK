var OrderWorkflow =
{
	// http://apidoc.linnworks.net/#/OrderWorkflow-CheckinUser
	CheckinUser: function(request,token, server)
	{
		return Factory.GetResponse("OrderWorkflow/CheckinUser", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/OrderWorkflow-DeallocateOrderFromJob
	DeallocateOrderFromJob: function(request,token, server)
	{
		return Factory.GetResponse("OrderWorkflow/DeallocateOrderFromJob", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/OrderWorkflow-GetGroup
	GetGroup: function(request,token, server)
	{
		return Factory.GetResponse("OrderWorkflow/GetGroup", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/OrderWorkflow-GetGroupList
	GetGroupList: function(request,token, server)
	{
		return Factory.GetResponse("OrderWorkflow/GetGroupList", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/OrderWorkflow-GetJob
	GetJob: function(request,token, server)
	{
		return Factory.GetResponse("OrderWorkflow/GetJob", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/OrderWorkflow-GetJobAudit
	GetJobAudit: function(request,token, server)
	{
		return Factory.GetResponse("OrderWorkflow/GetJobAudit", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/OrderWorkflow-GetJobByName
	GetJobByName: function(request,token, server)
	{
		return Factory.GetResponse("OrderWorkflow/GetJobByName", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/OrderWorkflow-GetJobErrors
	GetJobErrors: function(request,token, server)
	{
		return Factory.GetResponse("OrderWorkflow/GetJobErrors", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/OrderWorkflow-GetPrintAttachment
	GetPrintAttachment: function(request,token, server)
	{
		return Factory.GetResponse("OrderWorkflow/GetPrintAttachment", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/OrderWorkflow-GetWorkflow
	GetWorkflow: function(request,token, server)
	{
		return Factory.GetResponse("OrderWorkflow/GetWorkflow", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/OrderWorkflow-Run
	Run: function(request,token, server)
	{
		return Factory.GetResponse("OrderWorkflow/Run", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/OrderWorkflow-UpdateGroup
	UpdateGroup: function(request,token, server)
	{
		return Factory.GetResponse("OrderWorkflow/UpdateGroup", token, server, "request=" + JSON.stringify(request) +"");
	},
};
