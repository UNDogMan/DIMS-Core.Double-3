CREATE PROCEDURE [dbo].[SetUserTaskAsFail]
	@UserId int,
	@TaskId int
AS
	UPDATE [UserTasks] SET StateId = 3 WHERE UserId = @UserId and TaskId = @TaskId;
RETURN 0
