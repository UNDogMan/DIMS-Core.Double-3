CREATE VIEW [dbo].[vTask]
	AS 
SELECT 
		Tasks.TaskId,
		Tasks.Name,
		Tasks.Description,
		Tasks.StartDate,
		Tasks.DeadlineDate
FROM [dbo].[Tasks]
