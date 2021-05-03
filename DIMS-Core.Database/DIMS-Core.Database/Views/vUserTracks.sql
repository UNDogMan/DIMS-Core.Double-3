CREATE VIEW [dbo].[vUserTracks]
	AS 
SELECT
	UserTasks.UserId,
	UserTasks.TaskId,
	TaskTracks.TaskTrackId,
	Tasks.Name AS TaskName,
	TaskTracks.TrackNote,
	TaskTracks.TrackDate
FROM [TaskTracks]
	INNER JOIN [UserTasks] ON TaskTracks.UserTaskId = UserTasks.UserTaskId
	INNER JOIN [Tasks] ON UserTasks.TaskId = Tasks.TaskId;