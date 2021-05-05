CREATE PROCEDURE [dbo].[SetUserTaskAsSuccess]
	@UserId int,
	@TaskId int
AS
	UPDATE [UserTasks] SET StateId = 2 WHERE UserId = @UserId and TaskId = @TaskId;
RETURN 0
