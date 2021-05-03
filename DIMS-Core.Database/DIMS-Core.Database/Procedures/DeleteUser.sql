CREATE PROCEDURE [dbo].[DeleteUser]
	@UserId int
AS
	DELETE [UserProfiles] WHERE UserId = @UserId;
RETURN 0
