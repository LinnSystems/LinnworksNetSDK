<?php
class PermissionsMethods 
{ public static function GetAuditTypes($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/GetAuditTypes", "", $ApiToken, $ApiServer)); 
}

public static function CreateNewUser($emailAddress,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/CreateNewUser", "emailAddress=" . $emailAddress . "", $ApiToken, $ApiServer)); 
}

public static function DeleteUser($userId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Permissions/DeleteUser", "userId=" . $userId . "", $ApiToken, $ApiServer); 
}

public static function GetAuditEntriesBetweenDates($startDate,$endDate,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/GetAuditEntriesBetweenDates", "startDate=" . json_encode($startDate) . "&endDate=" . json_encode($endDate) . "", $ApiToken, $ApiServer)); 
}

public static function GetAuditEntriesBetweenDatesByGroup($startDate,$endDate,$groupId,$groupName,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/GetAuditEntriesBetweenDatesByGroup", "startDate=" . json_encode($startDate) . "&endDate=" . json_encode($endDate) . "&groupId=" . $groupId . "&groupName=" . $groupName . "", $ApiToken, $ApiServer)); 
}

public static function GetAuditEntriesBetweenDatesByUser($startDate,$endDate,$userId,$emailAddress,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/GetAuditEntriesBetweenDatesByUser", "startDate=" . json_encode($startDate) . "&endDate=" . json_encode($endDate) . "&userId=" . $userId . "&emailAddress=" . $emailAddress . "", $ApiToken, $ApiServer)); 
}

public static function GetAuditRowsByLogId($logId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/GetAuditRowsByLogId", "logId=" . $logId . "", $ApiToken, $ApiServer)); 
}

public static function GetDefinedPermissions()
{
 return json_decode(Factory::GetResponse("Permissions/GetDefinedPermissions", "", "", "")); 
}

public static function GetDefinedPermissionLists($permissionName)
{
 return json_decode(Factory::GetResponse("Permissions/GetDefinedPermissionLists", "permissionName=" . $permissionName . "", "", "")); 
}

public static function GetUsers($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/GetUsers", "", $ApiToken, $ApiServer)); 
}

public static function SetUserSuperAdmin($userId,$superAdmin,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Permissions/SetUserSuperAdmin", "userId=" . $userId . "&superAdmin=" . $superAdmin . "", $ApiToken, $ApiServer); 
}

public static function GetGroups($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/GetGroups", "", $ApiToken, $ApiServer)); 
}

public static function SetGroupEnabled($groupId,$enabled,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Permissions/SetGroupEnabled", "groupId=" . $groupId . "&enabled=" . $enabled . "", $ApiToken, $ApiServer); 
}

public static function SetGroupName($groupId,$groupName,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Permissions/SetGroupName", "groupId=" . $groupId . "&groupName=" . $groupName . "", $ApiToken, $ApiServer); 
}

public static function DeleteGroup($groupId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Permissions/DeleteGroup", "groupId=" . $groupId . "", $ApiToken, $ApiServer); 
}

public static function CreateGroup($groupName,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/CreateGroup", "groupName=" . $groupName . "", $ApiToken, $ApiServer)); 
}

public static function AddGroupUser($userId,$groupId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/AddGroupUser", "userId=" . $userId . "&groupId=" . $groupId . "", $ApiToken, $ApiServer)); 
}

public static function DeleteGroupUser($linkId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Permissions/DeleteGroupUser", "linkId=" . $linkId . "", $ApiToken, $ApiServer); 
}

public static function GetGroupUsers($groupId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/GetGroupUsers", "groupId=" . $groupId . "", $ApiToken, $ApiServer)); 
}

public static function GetUserGroups($userId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/GetUserGroups", "userId=" . $userId . "", $ApiToken, $ApiServer)); 
}

public static function AddPermissionListItems($listId,$itemValues,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/AddPermissionListItems", "listId=" . $listId . "&itemValues=" . json_encode($itemValues) . "", $ApiToken, $ApiServer)); 
}

public static function UpdatePermissionListItems($listId,$listItems,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Permissions/UpdatePermissionListItems", "listId=" . $listId . "&listItems=" . json_encode($listItems) . "", $ApiToken, $ApiServer); 
}

public static function DeletePermissionListItems($listId,$itemIds,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Permissions/DeletePermissionListItems", "listId=" . $listId . "&itemIds=" . json_encode($itemIds) . "", $ApiToken, $ApiServer); 
}

public static function OverwritePermissionListItems($listId,$listItems,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/OverwritePermissionListItems", "listId=" . $listId . "&listItems=" . json_encode($listItems) . "", $ApiToken, $ApiServer)); 
}

public static function GetUserPermissionListSources($userId,$listNames,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/GetUserPermissionListSources", "userId=" . $userId . "&listNames=" . json_encode($listNames) . "", $ApiToken, $ApiServer)); 
}

public static function GetEffectiveUserPermissionsLists($userId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/GetEffectiveUserPermissionsLists", "userId=" . $userId . "", $ApiToken, $ApiServer)); 
}

public static function GetEffectiveUserPermissions($userId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/GetEffectiveUserPermissions", "userId=" . $userId . "", $ApiToken, $ApiServer)); 
}

public static function GetEffectiveUserPermissionsSource($userId,$permissionNames,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/GetEffectiveUserPermissionsSource", "userId=" . $userId . "&permissionNames=" . json_encode($permissionNames) . "", $ApiToken, $ApiServer)); 
}

public static function AddDeletePermissionListItems($listId,$newValues,$deletedValues,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/AddDeletePermissionListItems", "listId=" . $listId . "&newValues=" . json_encode($newValues) . "&deletedValues=" . json_encode($deletedValues) . "", $ApiToken, $ApiServer)); 
}

public static function GetPermissionListItems($listId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/GetPermissionListItems", "listId=" . $listId . "", $ApiToken, $ApiServer)); 
}

public static function DeleteUserPermissionList($linkId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Permissions/DeleteUserPermissionList", "linkId=" . $linkId . "", $ApiToken, $ApiServer); 
}

public static function CreateUserPermissionList($userId,$listType,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/CreateUserPermissionList", "userId=" . $userId . "&listType=" . $listType . "", $ApiToken, $ApiServer)); 
}

public static function GetUserPermissionLists($userId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/GetUserPermissionLists", "userId=" . $userId . "", $ApiToken, $ApiServer)); 
}

public static function DeleteGroupPermissionList($linkId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Permissions/DeleteGroupPermissionList", "linkId=" . $linkId . "", $ApiToken, $ApiServer); 
}

public static function CreateGroupPermissionList($groupId,$listType,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/CreateGroupPermissionList", "groupId=" . $groupId . "&listType=" . $listType . "", $ApiToken, $ApiServer)); 
}

public static function GetGroupPermissionLists($groupId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/GetGroupPermissionLists", "groupId=" . $groupId . "", $ApiToken, $ApiServer)); 
}

public static function GetGroupPermissionListSources($groupId,$listNames,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/GetGroupPermissionListSources", "groupId=" . $groupId . "&listNames=" . json_encode($listNames) . "", $ApiToken, $ApiServer)); 
}

public static function AddGroupPermissions($groupId,$permissionTypes,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/AddGroupPermissions", "groupId=" . $groupId . "&permissionTypes=" . json_encode($permissionTypes) . "", $ApiToken, $ApiServer)); 
}

public static function DeleteGroupPermissions($groupId,$permissionIds,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Permissions/DeleteGroupPermissions", "groupId=" . $groupId . "&permissionIds=" . json_encode($permissionIds) . "", $ApiToken, $ApiServer); 
}

public static function DeleteGroupPermissionsByType($groupId,$permissionTypes,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Permissions/DeleteGroupPermissionsByType", "groupId=" . $groupId . "&permissionTypes=" . json_encode($permissionTypes) . "", $ApiToken, $ApiServer); 
}

public static function GetGroupPermissions($groupId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/GetGroupPermissions", "groupId=" . $groupId . "", $ApiToken, $ApiServer)); 
}

public static function AddUserPermissions($userId,$permissionTypes,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/AddUserPermissions", "userId=" . $userId . "&permissionTypes=" . json_encode($permissionTypes) . "", $ApiToken, $ApiServer)); 
}

public static function DeleteUserPermissions($userId,$permissionIds,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Permissions/DeleteUserPermissions", "userId=" . $userId . "&permissionIds=" . json_encode($permissionIds) . "", $ApiToken, $ApiServer); 
}

public static function DeleteUserPermissionsByType($userId,$permissionTypes,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Permissions/DeleteUserPermissionsByType", "userId=" . $userId . "&permissionTypes=" . json_encode($permissionTypes) . "", $ApiToken, $ApiServer); 
}

public static function GetUserPermissions($userId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/GetUserPermissions", "userId=" . $userId . "", $ApiToken, $ApiServer)); 
}

public static function GetGranteesByPermissionTypes($permissionTypes,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/GetGranteesByPermissionTypes", "permissionTypes=" . json_encode($permissionTypes) . "", $ApiToken, $ApiServer)); 
}

public static function GetGrantedPermissions($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/GetGrantedPermissions", "", $ApiToken, $ApiServer)); 
}

public static function GetListTypes($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Permissions/GetListTypes", "", $ApiToken, $ApiServer)); 
} 
}
?>