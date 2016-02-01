var Permissions =
{
	// http://apidoc.linnworks.net/#/Permissions-GetAuditTypes
	GetAuditTypes: function(token, server)
	{
		return Factory.GetResponse("Permissions/GetAuditTypes", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Permissions-CreateNewUser
	CreateNewUser: function(emailAddress,token, server)
	{
		return Factory.GetResponse("Permissions/CreateNewUser", token, server, "emailAddress=" + emailAddress +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-DeleteUser
	DeleteUser: function(userId,token, server)
	{
		return Factory.GetResponse("Permissions/DeleteUser", token, server, "userId=" + userId +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-GetAuditEntriesBetweenDates
	GetAuditEntriesBetweenDates: function(startDate,endDate,token, server)
	{
		return Factory.GetResponse("Permissions/GetAuditEntriesBetweenDates", token, server, "startDate=" + JSON.stringify(startDate) + "&endDate=" + JSON.stringify(endDate) +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-GetAuditEntriesBetweenDatesByGroup
	GetAuditEntriesBetweenDatesByGroup: function(startDate,endDate,groupId,groupName,token, server)
	{
		return Factory.GetResponse("Permissions/GetAuditEntriesBetweenDatesByGroup", token, server, "startDate=" + JSON.stringify(startDate) + "&endDate=" + JSON.stringify(endDate) + "&groupId=" + groupId + "&groupName=" + groupName +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-GetAuditEntriesBetweenDatesByUser
	GetAuditEntriesBetweenDatesByUser: function(startDate,endDate,userId,emailAddress,token, server)
	{
		return Factory.GetResponse("Permissions/GetAuditEntriesBetweenDatesByUser", token, server, "startDate=" + JSON.stringify(startDate) + "&endDate=" + JSON.stringify(endDate) + "&userId=" + userId + "&emailAddress=" + emailAddress +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-GetAuditRowsByLogId
	GetAuditRowsByLogId: function(logId,token, server)
	{
		return Factory.GetResponse("Permissions/GetAuditRowsByLogId", token, server, "logId=" + logId +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-GetDefinedPermissions
	GetDefinedPermissions: function()
	{
		return Factory.GetResponse("Permissions/GetDefinedPermissions", "", "", "");
	},
	// http://apidoc.linnworks.net/#/Permissions-GetDefinedPermissionLists
	GetDefinedPermissionLists: function(permissionName)
	{
		return Factory.GetResponse("Permissions/GetDefinedPermissionLists", "", "", "permissionName=" + permissionName +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-GetUsers
	GetUsers: function(token, server)
	{
		return Factory.GetResponse("Permissions/GetUsers", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Permissions-SetUserSuperAdmin
	SetUserSuperAdmin: function(userId,superAdmin,token, server)
	{
		return Factory.GetResponse("Permissions/SetUserSuperAdmin", token, server, "userId=" + userId + "&superAdmin=" + superAdmin +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-GetGroups
	GetGroups: function(token, server)
	{
		return Factory.GetResponse("Permissions/GetGroups", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Permissions-SetGroupEnabled
	SetGroupEnabled: function(groupId,enabled,token, server)
	{
		return Factory.GetResponse("Permissions/SetGroupEnabled", token, server, "groupId=" + groupId + "&enabled=" + enabled +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-SetGroupName
	SetGroupName: function(groupId,groupName,token, server)
	{
		return Factory.GetResponse("Permissions/SetGroupName", token, server, "groupId=" + groupId + "&groupName=" + groupName +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-DeleteGroup
	DeleteGroup: function(groupId,token, server)
	{
		return Factory.GetResponse("Permissions/DeleteGroup", token, server, "groupId=" + groupId +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-CreateGroup
	CreateGroup: function(groupName,token, server)
	{
		return Factory.GetResponse("Permissions/CreateGroup", token, server, "groupName=" + groupName +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-AddGroupUser
	AddGroupUser: function(userId,groupId,token, server)
	{
		return Factory.GetResponse("Permissions/AddGroupUser", token, server, "userId=" + userId + "&groupId=" + groupId +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-DeleteGroupUser
	DeleteGroupUser: function(linkId,token, server)
	{
		return Factory.GetResponse("Permissions/DeleteGroupUser", token, server, "linkId=" + linkId +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-GetGroupUsers
	GetGroupUsers: function(groupId,token, server)
	{
		return Factory.GetResponse("Permissions/GetGroupUsers", token, server, "groupId=" + groupId +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-GetUserGroups
	GetUserGroups: function(userId,token, server)
	{
		return Factory.GetResponse("Permissions/GetUserGroups", token, server, "userId=" + userId +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-AddPermissionListItems
	AddPermissionListItems: function(listId,itemValues,token, server)
	{
		return Factory.GetResponse("Permissions/AddPermissionListItems", token, server, "listId=" + listId + "&itemValues=" + JSON.stringify(itemValues) +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-UpdatePermissionListItems
	UpdatePermissionListItems: function(listId,listItems,token, server)
	{
		return Factory.GetResponse("Permissions/UpdatePermissionListItems", token, server, "listId=" + listId + "&listItems=" + JSON.stringify(listItems) +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-DeletePermissionListItems
	DeletePermissionListItems: function(listId,itemIds,token, server)
	{
		return Factory.GetResponse("Permissions/DeletePermissionListItems", token, server, "listId=" + listId + "&itemIds=" + JSON.stringify(itemIds) +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-OverwritePermissionListItems
	OverwritePermissionListItems: function(listId,listItems,token, server)
	{
		return Factory.GetResponse("Permissions/OverwritePermissionListItems", token, server, "listId=" + listId + "&listItems=" + JSON.stringify(listItems) +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-GetUserPermissionListSources
	GetUserPermissionListSources: function(userId,listNames,token, server)
	{
		return Factory.GetResponse("Permissions/GetUserPermissionListSources", token, server, "userId=" + userId + "&listNames=" + JSON.stringify(listNames) +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-GetEffectiveUserPermissionsLists
	GetEffectiveUserPermissionsLists: function(userId,token, server)
	{
		return Factory.GetResponse("Permissions/GetEffectiveUserPermissionsLists", token, server, "userId=" + userId +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-GetEffectiveUserPermissions
	GetEffectiveUserPermissions: function(userId,token, server)
	{
		return Factory.GetResponse("Permissions/GetEffectiveUserPermissions", token, server, "userId=" + userId +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-GetEffectiveUserPermissionsSource
	GetEffectiveUserPermissionsSource: function(userId,permissionNames,token, server)
	{
		return Factory.GetResponse("Permissions/GetEffectiveUserPermissionsSource", token, server, "userId=" + userId + "&permissionNames=" + JSON.stringify(permissionNames) +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-AddDeletePermissionListItems
	AddDeletePermissionListItems: function(listId,newValues,deletedValues,token, server)
	{
		return Factory.GetResponse("Permissions/AddDeletePermissionListItems", token, server, "listId=" + listId + "&newValues=" + JSON.stringify(newValues) + "&deletedValues=" + JSON.stringify(deletedValues) +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-GetPermissionListItems
	GetPermissionListItems: function(listId,token, server)
	{
		return Factory.GetResponse("Permissions/GetPermissionListItems", token, server, "listId=" + listId +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-DeleteUserPermissionList
	DeleteUserPermissionList: function(linkId,token, server)
	{
		return Factory.GetResponse("Permissions/DeleteUserPermissionList", token, server, "linkId=" + linkId +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-CreateUserPermissionList
	CreateUserPermissionList: function(userId,listType,token, server)
	{
		return Factory.GetResponse("Permissions/CreateUserPermissionList", token, server, "userId=" + userId + "&listType=" + listType +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-GetUserPermissionLists
	GetUserPermissionLists: function(userId,token, server)
	{
		return Factory.GetResponse("Permissions/GetUserPermissionLists", token, server, "userId=" + userId +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-DeleteGroupPermissionList
	DeleteGroupPermissionList: function(linkId,token, server)
	{
		return Factory.GetResponse("Permissions/DeleteGroupPermissionList", token, server, "linkId=" + linkId +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-CreateGroupPermissionList
	CreateGroupPermissionList: function(groupId,listType,token, server)
	{
		return Factory.GetResponse("Permissions/CreateGroupPermissionList", token, server, "groupId=" + groupId + "&listType=" + listType +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-GetGroupPermissionLists
	GetGroupPermissionLists: function(groupId,token, server)
	{
		return Factory.GetResponse("Permissions/GetGroupPermissionLists", token, server, "groupId=" + groupId +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-GetGroupPermissionListSources
	GetGroupPermissionListSources: function(groupId,listNames,token, server)
	{
		return Factory.GetResponse("Permissions/GetGroupPermissionListSources", token, server, "groupId=" + groupId + "&listNames=" + JSON.stringify(listNames) +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-AddGroupPermissions
	AddGroupPermissions: function(groupId,permissionTypes,token, server)
	{
		return Factory.GetResponse("Permissions/AddGroupPermissions", token, server, "groupId=" + groupId + "&permissionTypes=" + JSON.stringify(permissionTypes) +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-DeleteGroupPermissions
	DeleteGroupPermissions: function(groupId,permissionIds,token, server)
	{
		return Factory.GetResponse("Permissions/DeleteGroupPermissions", token, server, "groupId=" + groupId + "&permissionIds=" + JSON.stringify(permissionIds) +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-DeleteGroupPermissionsByType
	DeleteGroupPermissionsByType: function(groupId,permissionTypes,token, server)
	{
		return Factory.GetResponse("Permissions/DeleteGroupPermissionsByType", token, server, "groupId=" + groupId + "&permissionTypes=" + JSON.stringify(permissionTypes) +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-GetGroupPermissions
	GetGroupPermissions: function(groupId,token, server)
	{
		return Factory.GetResponse("Permissions/GetGroupPermissions", token, server, "groupId=" + groupId +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-AddUserPermissions
	AddUserPermissions: function(userId,permissionTypes,token, server)
	{
		return Factory.GetResponse("Permissions/AddUserPermissions", token, server, "userId=" + userId + "&permissionTypes=" + JSON.stringify(permissionTypes) +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-DeleteUserPermissions
	DeleteUserPermissions: function(userId,permissionIds,token, server)
	{
		return Factory.GetResponse("Permissions/DeleteUserPermissions", token, server, "userId=" + userId + "&permissionIds=" + JSON.stringify(permissionIds) +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-DeleteUserPermissionsByType
	DeleteUserPermissionsByType: function(userId,permissionTypes,token, server)
	{
		return Factory.GetResponse("Permissions/DeleteUserPermissionsByType", token, server, "userId=" + userId + "&permissionTypes=" + JSON.stringify(permissionTypes) +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-GetUserPermissions
	GetUserPermissions: function(userId,token, server)
	{
		return Factory.GetResponse("Permissions/GetUserPermissions", token, server, "userId=" + userId +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-GetGranteesByPermissionTypes
	GetGranteesByPermissionTypes: function(permissionTypes,token, server)
	{
		return Factory.GetResponse("Permissions/GetGranteesByPermissionTypes", token, server, "permissionTypes=" + JSON.stringify(permissionTypes) +"");
	},
	// http://apidoc.linnworks.net/#/Permissions-GetGrantedPermissions
	GetGrantedPermissions: function(token, server)
	{
		return Factory.GetResponse("Permissions/GetGrantedPermissions", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Permissions-GetListTypes
	GetListTypes: function(token, server)
	{
		return Factory.GetResponse("Permissions/GetListTypes", token, server, "");
	},
};
