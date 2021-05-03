CREATE PROCEDURE [dbo].[DeleteTask]
	@TaskId int
AS
	DELETE [Tasks] WHERE TaskId = @TaskId;
RETURN 0
