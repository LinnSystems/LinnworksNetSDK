var TaskLists =
{
	// http://apidoc.linnworks.net/#/TaskLists-GetTaskList
	GetTaskList: function(ListId,token, server)
	{
		return Factory.GetResponse("TaskLists/GetTaskList", token, server, "ListId=" + ListId +"");
	},
	// http://apidoc.linnworks.net/#/TaskLists-CreateTaskList
	CreateTaskList: function(List,token, server)
	{
		return Factory.GetResponse("TaskLists/CreateTaskList", token, server, "List=" + JSON.stringify(List) +"");
	},
	// http://apidoc.linnworks.net/#/TaskLists-AddTaskToList
	AddTaskToList: function(ListId,task,token, server)
	{
		return Factory.GetResponse("TaskLists/AddTaskToList", token, server, "ListId=" + ListId + "&task=" + JSON.stringify(task) +"");
	},
	// http://apidoc.linnworks.net/#/TaskLists-ChangeListStatus
	ChangeListStatus: function(ListId,NewStatus,completeAllTasks,token, server)
	{
		return Factory.GetResponse("TaskLists/ChangeListStatus", token, server, "ListId=" + ListId + "&NewStatus=" + NewStatus + "&completeAllTasks=" + completeAllTasks +"");
	},
	// http://apidoc.linnworks.net/#/TaskLists-ChangeTaskStatus
	ChangeTaskStatus: function(ListId,taskId,NewStatus,completeDependentTasks,token, server)
	{
		return Factory.GetResponse("TaskLists/ChangeTaskStatus", token, server, "ListId=" + ListId + "&taskId=" + taskId + "&NewStatus=" + NewStatus + "&completeDependentTasks=" + completeDependentTasks +"");
	},
	// http://apidoc.linnworks.net/#/TaskLists-AddDependency
	AddDependency: function(ListId,taskId,requiredTaskId,token, server)
	{
		return Factory.GetResponse("TaskLists/AddDependency", token, server, "ListId=" + ListId + "&taskId=" + taskId + "&requiredTaskId=" + requiredTaskId +"");
	},
	// http://apidoc.linnworks.net/#/TaskLists-RemoveDependency
	RemoveDependency: function(ListId,taskId,dependencyToRemove,token, server)
	{
		return Factory.GetResponse("TaskLists/RemoveDependency", token, server, "ListId=" + ListId + "&taskId=" + taskId + "&dependencyToRemove=" + dependencyToRemove +"");
	},
};
