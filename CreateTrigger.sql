
CREATE TRIGGER ProjectDeleteTrigger
	ON [dbo].[Projects]
	INSTEAD OF DELETE
AS
BEGIN
	SET NOCOUNT ON;
		DELETE FROM Tasks WHERE  ProjectId = (select Id from deleted)

		DELETE FROM Projects WHERE  Id = (select Id from deleted)
END

go

create TRIGGER AddEmployee
	ON [dbo].[TaskEmployees]
	After INSERT
	AS
	BEGIN
	DECLARE @message nvarchar(200);
	
(select @message= CONCAT(FirstName,' ',LastName,' joined this task.') from Employees where Id=(select Employee_Id from inserted))

		insert into TaskTracks (CreateDate,Task_Id,TaskState_Id,EventDescription) values(GETDATE(),(select Task_Id from inserted),(select Id from TaskStates where Name='AddEmployee'),@message)
	END

go

CREATE TRIGGER RemoveEmployee
	ON [dbo].[TaskEmployees]
After delete as
	BEGIN
	DECLARE @message nvarchar(200);
	DECLARE @isEmp int;
	DECLARE @isTask int;
	select  @isEmp = Count(Id) from Employees e inner join deleted d on d.Employee_Id=e.Id 
	select  @isTask = Count(Id) from Tasks t inner join deleted d on d.Task_Id=t.Id 

	if @isEmp != 0 and @isTask != 0
		Begin
			(select Top 1 @message= CONCAT(FirstName,' ',LastName,' left this task.') from Employees e inner join deleted d on d.Employee_Id=e.Id )
			insert into TaskTracks (CreateDate,Task_Id,TaskState_Id,EventDescription) values(GETDATE(),(select Top 1 Task_Id from deleted),(select Id from TaskStates where Name='RemoveEmployee'),@message)
		End

	END

go

CREATE TRIGGER AfterDeleteTask
	ON [dbo].[Tasks]
	After DELETE
AS
BEGIN
	SET NOCOUNT ON;
		DELETE FROM TaskEmployees WHERE  Task_Id = (select TOP 1 Id from deleted)
END

go

	create TRIGGER AfterInsertTask
	ON [dbo].[Tasks]
	After Insert
	AS
	BEGIN
	DECLARE @message nvarchar(200);
	
(select @message= CONCAT('"',Details,'"',' detailed task created.') from inserted)

		insert into TaskTracks (CreateDate,Task_Id,TaskState_Id,EventDescription) values(GETDATE(),(select Id from inserted),(select Id from TaskStates where Name='Create'),@message)
	END

go

	CREATE TRIGGER AfterUpdateTask
	ON [dbo].[Tasks]
	After Update
	AS
	BEGIN
		DECLARE @message nvarchar(200);
		DECLARE @deletedTaskId int;
		DECLARE @insertedTaskId int;
		select @insertedTaskId = TaskStateId from inserted
		select @deletedTaskId = TaskStateId from deleted

		IF @deletedTaskId != @insertedTaskId
			BEGIN
				DECLARE @taskName nvarchar(200);

				(select @taskName=Name from TaskStates t inner join inserted d on d.TaskStateId =t.Id )
				(select TOP 1 @message= CONCAT('"',Details,'"',' detailed task ',@taskName) from inserted)
			END
		ELSE
			BEGIN
				(select TOP 1 @message=  CONCAT('"',Details,'"',' detailed task updated') from inserted)
			END
		
		
		insert into TaskTracks (CreateDate,Task_Id,TaskState_Id,EventDescription) values(GETDATE(),(select Id from inserted),(select TOP 1 Id from TaskStates where Name='Update'),@message)
	END