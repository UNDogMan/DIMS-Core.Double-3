CREATE PROCEDURE [dbo].[DeleteTask]
	@TaskId int
AS
	DELETE FROM [Tasks] WHERE TaskId = @TaskId;
RETURN 0
