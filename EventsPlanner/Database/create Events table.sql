CREATE TABLE [dbo].[Events]
(
	ID [int] IDENTITY(1,1) NOT NULL,
	Name nvarchar(200),
	StartDate datetime,
	EndDate datetime,
	NotifyBeforeInMinutes int,
	AdditionalInfo nvarchar(max),
  NotifyBeforeInMinutes nvarcnar(max),
	CONSTRAINT [PK_Events] PRIMARY KEY CLUSTERED 
	(
	  ID ASC
	)
)