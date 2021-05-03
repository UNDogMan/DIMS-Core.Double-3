CREATE VIEW [dbo].[vUserTasks]
	AS 
SELECT
	UserTasks.UserId,
	UserTasks.TaskId,
	Tasks.Name AS TaskName,
	Tasks.Description,
	Tasks.StartDate,
	Tasks.DeadlineDate,
	TaskStates.StateName AS State
FROM [UserTasks]
	INNER JOIN [UserProfiles] ON UserTasks.UserId = UserProfiles.UserId
	INNER JOIN [Tasks] ON UserTasks.TaskId = Tasks.TaskId
	INNER JOIN [TaskStates] ON UserTasks.StateId = TaskStates.StateId;
