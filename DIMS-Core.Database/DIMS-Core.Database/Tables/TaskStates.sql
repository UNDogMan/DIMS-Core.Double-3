CREATE TABLE [dbo].[TaskStates]
(
	[StateId] INT NOT NULL,
	[StateName] NVARCHAR(50) NOT NULL,

	CONSTRAINT PK_TaskState_StateId PRIMARY KEY(StateId)
)
