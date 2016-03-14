<?php
class TaskListsMethods 
{ public static function GetTaskList($ListId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("TaskLists/GetTaskList", "ListId=" . $ListId . "", $ApiToken, $ApiServer)); 
}

public static function CreateTaskList($List,$ApiToken, $ApiServer)
{
 Factory::GetResponse("TaskLists/CreateTaskList", "List=" . json_encode($List) . "", $ApiToken, $ApiServer); 
}

public static function AddTaskToList($ListId,$task,$ApiToken, $ApiServer)
{
 Factory::GetResponse("TaskLists/AddTaskToList", "ListId=" . $ListId . "&task=" . json_encode($task) . "", $ApiToken, $ApiServer); 
}

public static function ChangeListStatus($ListId,$NewStatus,$completeAllTasks,$ApiToken, $ApiServer)
{
 Factory::GetResponse("TaskLists/ChangeListStatus", "ListId=" . $ListId . "&NewStatus=" . $NewStatus . "&completeAllTasks=" . $completeAllTasks . "", $ApiToken, $ApiServer); 
}

public static function ChangeTaskStatus($ListId,$taskId,$NewStatus,$completeDependentTasks,$ApiToken, $ApiServer)
{
 Factory::GetResponse("TaskLists/ChangeTaskStatus", "ListId=" . $ListId . "&taskId=" . $taskId . "&NewStatus=" . $NewStatus . "&completeDependentTasks=" . $completeDependentTasks . "", $ApiToken, $ApiServer); 
}

public static function AddDependency($ListId,$taskId,$requiredTaskId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("TaskLists/AddDependency", "ListId=" . $ListId . "&taskId=" . $taskId . "&requiredTaskId=" . $requiredTaskId . "", $ApiToken, $ApiServer); 
}

public static function RemoveDependency($ListId,$taskId,$dependencyToRemove,$ApiToken, $ApiServer)
{
 Factory::GetResponse("TaskLists/RemoveDependency", "ListId=" . $ListId . "&taskId=" . $taskId . "&dependencyToRemove=" . $dependencyToRemove . "", $ApiToken, $ApiServer); 
} 
}
?>