using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class PermissionsMethods
    {
        public static List<GenericEnumDescriptor> GetAuditTypes(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<GenericEnumDescriptor>>(Factory.GetResponse("Permissions/GetAuditTypes", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static PermissionsUser CreateNewUser(String emailAddress, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PermissionsUser>(Factory.GetResponse("Permissions/CreateNewUser", "emailAddress=" + emailAddress + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void DeleteUser(Int32 userId, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Permissions/DeleteUser", "userId=" + userId + "", ApiToken, ApiServer);
        }

        public static List<PermissionAudit> GetAuditEntriesBetweenDates(DateTime startDate, DateTime endDate, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PermissionAudit>>(Factory.GetResponse("Permissions/GetAuditEntriesBetweenDates", "startDate=" + Newtonsoft.Json.JsonConvert.SerializeObject(startDate) + "&endDate=" + Newtonsoft.Json.JsonConvert.SerializeObject(endDate) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<PermissionAudit> GetAuditEntriesBetweenDatesByGroup(DateTime startDate, DateTime endDate, Int32 groupId, String groupName, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PermissionAudit>>(Factory.GetResponse("Permissions/GetAuditEntriesBetweenDatesByGroup", "startDate=" + Newtonsoft.Json.JsonConvert.SerializeObject(startDate) + "&endDate=" + Newtonsoft.Json.JsonConvert.SerializeObject(endDate) + "&groupId=" + groupId + "&groupName=" + groupName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<PermissionAudit> GetAuditEntriesBetweenDatesByUser(DateTime startDate, DateTime endDate, Int32 userId, String emailAddress, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PermissionAudit>>(Factory.GetResponse("Permissions/GetAuditEntriesBetweenDatesByUser", "startDate=" + Newtonsoft.Json.JsonConvert.SerializeObject(startDate) + "&endDate=" + Newtonsoft.Json.JsonConvert.SerializeObject(endDate) + "&userId=" + userId + "&emailAddress=" + emailAddress + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static PermissionAuditRows GetAuditRowsByLogId(Int32 logId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PermissionAuditRows>(Factory.GetResponse("Permissions/GetAuditRowsByLogId", "logId=" + logId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<PermissionHierarchy> GetDefinedPermissions()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PermissionHierarchy>>(Factory.GetResponse("Permissions/GetDefinedPermissions", "", "", ""), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<IDataList> GetDefinedPermissionLists(String permissionName)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<IDataList>>(Factory.GetResponse("Permissions/GetDefinedPermissionLists", "permissionName=" + permissionName + "", "", ""), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<PermissionsUser> GetUsers(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PermissionsUser>>(Factory.GetResponse("Permissions/GetUsers", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void SetUserSuperAdmin(Int32 userId, Boolean superAdmin, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Permissions/SetUserSuperAdmin", "userId=" + userId + "&superAdmin=" + superAdmin + "", ApiToken, ApiServer);
        }

        public static List<Group> GetGroups(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Group>>(Factory.GetResponse("Permissions/GetGroups", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void SetGroupEnabled(Int32 groupId, Boolean enabled, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Permissions/SetGroupEnabled", "groupId=" + groupId + "&enabled=" + enabled + "", ApiToken, ApiServer);
        }

        public static void SetGroupName(Int32 groupId, String groupName, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Permissions/SetGroupName", "groupId=" + groupId + "&groupName=" + groupName + "", ApiToken, ApiServer);
        }

        public static void DeleteGroup(Int32 groupId, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Permissions/DeleteGroup", "groupId=" + groupId + "", ApiToken, ApiServer);
        }

        public static Group CreateGroup(String groupName, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Group>(Factory.GetResponse("Permissions/CreateGroup", "groupName=" + groupName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static GroupUser AddGroupUser(Int32 userId, Int32 groupId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GroupUser>(Factory.GetResponse("Permissions/AddGroupUser", "userId=" + userId + "&groupId=" + groupId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void DeleteGroupUser(Int32 linkId, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Permissions/DeleteGroupUser", "linkId=" + linkId + "", ApiToken, ApiServer);
        }

        public static List<GroupUser> GetGroupUsers(Int32 groupId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<GroupUser>>(Factory.GetResponse("Permissions/GetGroupUsers", "groupId=" + groupId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<GroupUser> GetUserGroups(Int32 userId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<GroupUser>>(Factory.GetResponse("Permissions/GetUserGroups", "userId=" + userId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<PermissionListItem> AddPermissionListItems(Int32 listId, List<String> itemValues, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PermissionListItem>>(Factory.GetResponse("Permissions/AddPermissionListItems", "listId=" + listId + "&itemValues=" + Newtonsoft.Json.JsonConvert.SerializeObject(itemValues) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void UpdatePermissionListItems(Int32 listId, List<PermissionListItem> listItems, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Permissions/UpdatePermissionListItems", "listId=" + listId + "&listItems=" + Newtonsoft.Json.JsonConvert.SerializeObject(listItems) + "", ApiToken, ApiServer);
        }

        public static void DeletePermissionListItems(Int32 listId, List<Int32> itemIds, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Permissions/DeletePermissionListItems", "listId=" + listId + "&itemIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(itemIds) + "", ApiToken, ApiServer);
        }

        public static List<PermissionListItem> OverwritePermissionListItems(Int32 listId, List<PermissionListItem> listItems, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PermissionListItem>>(Factory.GetResponse("Permissions/OverwritePermissionListItems", "listId=" + listId + "&listItems=" + Newtonsoft.Json.JsonConvert.SerializeObject(listItems) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<PermissionListSource> GetUserPermissionListSources(Int32 userId, List<String> listNames, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PermissionListSource>>(Factory.GetResponse("Permissions/GetUserPermissionListSources", "userId=" + userId + "&listNames=" + Newtonsoft.Json.JsonConvert.SerializeObject(listNames) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<String> GetEffectiveUserPermissionsLists(Int32 userId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<String>>(Factory.GetResponse("Permissions/GetEffectiveUserPermissionsLists", "userId=" + userId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<String> GetEffectiveUserPermissions(Int32 userId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<String>>(Factory.GetResponse("Permissions/GetEffectiveUserPermissions", "userId=" + userId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<PermissionSourceContainer> GetEffectiveUserPermissionsSource(Int32 userId, List<String> permissionNames, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PermissionSourceContainer>>(Factory.GetResponse("Permissions/GetEffectiveUserPermissionsSource", "userId=" + userId + "&permissionNames=" + Newtonsoft.Json.JsonConvert.SerializeObject(permissionNames) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<PermissionListItem> AddDeletePermissionListItems(Int32 listId, List<String> newValues, List<Int32> deletedValues, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PermissionListItem>>(Factory.GetResponse("Permissions/AddDeletePermissionListItems", "listId=" + listId + "&newValues=" + Newtonsoft.Json.JsonConvert.SerializeObject(newValues) + "&deletedValues=" + Newtonsoft.Json.JsonConvert.SerializeObject(deletedValues) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<PermissionListItem> GetPermissionListItems(Int32 listId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PermissionListItem>>(Factory.GetResponse("Permissions/GetPermissionListItems", "listId=" + listId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void DeleteUserPermissionList(Int32 linkId, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Permissions/DeleteUserPermissionList", "linkId=" + linkId + "", ApiToken, ApiServer);
        }

        public static PermissionListHeader CreateUserPermissionList(Int32 userId, String listType, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PermissionListHeader>(Factory.GetResponse("Permissions/CreateUserPermissionList", "userId=" + userId + "&listType=" + listType + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<PermissionListHeader> GetUserPermissionLists(Int32 userId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PermissionListHeader>>(Factory.GetResponse("Permissions/GetUserPermissionLists", "userId=" + userId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void DeleteGroupPermissionList(Int32 linkId, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Permissions/DeleteGroupPermissionList", "linkId=" + linkId + "", ApiToken, ApiServer);
        }

        public static PermissionListHeader CreateGroupPermissionList(Int32 groupId, String listType, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PermissionListHeader>(Factory.GetResponse("Permissions/CreateGroupPermissionList", "groupId=" + groupId + "&listType=" + listType + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<PermissionListHeader> GetGroupPermissionLists(Int32 groupId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PermissionListHeader>>(Factory.GetResponse("Permissions/GetGroupPermissionLists", "groupId=" + groupId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<PermissionGroupListSource> GetGroupPermissionListSources(Int32 groupId, List<String> listNames, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PermissionGroupListSource>>(Factory.GetResponse("Permissions/GetGroupPermissionListSources", "groupId=" + groupId + "&listNames=" + Newtonsoft.Json.JsonConvert.SerializeObject(listNames) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<PermissionItem> AddGroupPermissions(Int32 groupId, List<String> permissionTypes, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PermissionItem>>(Factory.GetResponse("Permissions/AddGroupPermissions", "groupId=" + groupId + "&permissionTypes=" + Newtonsoft.Json.JsonConvert.SerializeObject(permissionTypes) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void DeleteGroupPermissions(Int32 groupId, List<Int32> permissionIds, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Permissions/DeleteGroupPermissions", "groupId=" + groupId + "&permissionIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(permissionIds) + "", ApiToken, ApiServer);
        }

        public static void DeleteGroupPermissionsByType(Int32 groupId, List<String> permissionTypes, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Permissions/DeleteGroupPermissionsByType", "groupId=" + groupId + "&permissionTypes=" + Newtonsoft.Json.JsonConvert.SerializeObject(permissionTypes) + "", ApiToken, ApiServer);
        }

        public static List<PermissionItem> GetGroupPermissions(Int32 groupId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PermissionItem>>(Factory.GetResponse("Permissions/GetGroupPermissions", "groupId=" + groupId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<PermissionItem> AddUserPermissions(Int32 userId, List<String> permissionTypes, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PermissionItem>>(Factory.GetResponse("Permissions/AddUserPermissions", "userId=" + userId + "&permissionTypes=" + Newtonsoft.Json.JsonConvert.SerializeObject(permissionTypes) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void DeleteUserPermissions(Int32 userId, List<Int32> permissionIds, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Permissions/DeleteUserPermissions", "userId=" + userId + "&permissionIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(permissionIds) + "", ApiToken, ApiServer);
        }

        public static void DeleteUserPermissionsByType(Int32 userId, List<String> permissionTypes, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Permissions/DeleteUserPermissionsByType", "userId=" + userId + "&permissionTypes=" + Newtonsoft.Json.JsonConvert.SerializeObject(permissionTypes) + "", ApiToken, ApiServer);
        }

        public static List<PermissionItem> GetUserPermissions(Int32 userId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PermissionItem>>(Factory.GetResponse("Permissions/GetUserPermissions", "userId=" + userId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<PermissionGranteeResult> GetGranteesByPermissionTypes(List<String> permissionTypes, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PermissionGranteeResult>>(Factory.GetResponse("Permissions/GetGranteesByPermissionTypes", "permissionTypes=" + Newtonsoft.Json.JsonConvert.SerializeObject(permissionTypes) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<String> GetGrantedPermissions(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<String>>(Factory.GetResponse("Permissions/GetGrantedPermissions", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<GenericEnumDescriptor> GetListTypes(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<GenericEnumDescriptor>>(Factory.GetResponse("Permissions/GetListTypes", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}