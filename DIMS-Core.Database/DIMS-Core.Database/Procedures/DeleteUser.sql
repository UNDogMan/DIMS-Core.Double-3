CREATE PROCEDURE [dbo].[DeleteUser]
	@UserId int
AS
	DELETE FROM [UserProfiles] WHERE UserId = @UserId;
RETURN 0
