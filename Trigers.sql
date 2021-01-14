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
create TRIGGER RemoveEmployee
	ON [dbo].[TaskEmployees]
	After Delete
	AS
	BEGIN
	DECLARE @message nvarchar(200);
	
(select @message= CONCAT(FirstName,' ',LastName,' left this task.') from Employees where Id=(select Employee_Id from deleted))

		insert into TaskTracks (CreateDate,Task_Id,TaskState_Id,EventDescription) values(GETDATE(),(select Task_Id from deleted),(select Id from TaskStates where Name='RemoveEmployee'),@message)
	END
	--Task--
	go

	create TRIGGER AfterDeleteTask
	ON [dbo].[Tasks]
	After Delete
	AS
	BEGIN
	DECLARE @message nvarchar(200);
	
(select @message= CONCAT('"',Details,'"',' detailed task deleted.') from deleted)

		insert into TaskTracks (CreateDate,Task_Id,TaskState_Id,EventDescription) values(GETDATE(),(select Id from deleted),(select Id from TaskStates where Name='Delete'),@message)
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
	
	create TRIGGER AfterUpdateTask
	ON [dbo].[Tasks]
	After Update
	AS
	BEGIN
		DECLARE @message nvarchar(200);
		IF UPDATE(TaskStateId)
			BEGIN
				DECLARE @taskName nvarchar(200);

				(select @taskName=Name from TaskStates where Id=(select TaskStateId from inserted))
				(select @message= CONCAT('"',Details,'"',' detailed task ',@taskName) from inserted)
			END
		ELSE
			BEGIN
				IF UPDATE(Details)
					BEGIN
						set @message= 'Details updated.'
					END

				IF UPDATE(Notes)
					BEGIN
						set @message= 'Notes updated.'
					END
			
				IF (UPDATE(Notes) and UPDATE(Details))
					BEGIN
						set @message= 'Task updated.'
					END
			END
		
		
		insert into TaskTracks (CreateDate,Task_Id,TaskState_Id,EventDescription) values(GETDATE(),(select Id from inserted),(select Id from TaskStates where Name='Update'),@message)
	END