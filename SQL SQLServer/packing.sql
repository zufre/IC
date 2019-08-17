CREATE TABLE [Volunteers] (
	[Id] INT IDENTITY,
	[LastName] VARCHAR(100),
	[FirstName] VARCHAR(100),
	[StreetAddress] VARCHAR(100),
	[City] VARCHAR(100),
	[PostalCode] VARCHAR(100),
	[PhoneAreaCode] VARCHAR(100),
	[PhoneNumber] VARCHAR(100),
	CONSTRAINT [PK_Volunteers] PRIMARY KEY ([Id])
)

CREATE TABLE [Tasks] (
	[Id] INT IDENTITY,
	[TaskDescription] VARCHAR(MAX),
	[TaskType] VARCHAR(100),
	[TaskStatus] VARCHAR(100),
	CONSTRAINT [PK_Tasks] PRIMARY KEY ([Id]),
)

CREATE TABLE [Assignments] (
	[Id] INT IDENTITY,
	[VolunteerId] INT NOT NULL,
	[TaskCode] INT NOT NULL,
	[StartTime] DATETIME2,
	[EndTime] DATETIME2,
	CONSTRAINT [PK_Assignments] PRIMARY KEY ([Id]),
	CONSTRAINT [FK_Assignments_Volunteers] 
		FOREIGN KEY ([VolunteerId]) REFERENCES [Volunteers] ([Id]),
	CONSTRAINT [FK_Assignments_Tasks] 
		FOREIGN KEY ([TaskCode]) REFERENCES [Tasks] ([Id])
)



CREATE TABLE [Items] (
	[Id] INT IDENTITY,
	[ItemDescription] VARCHAR(MAX),
	[ItemValue] INT,
	[ItemQuantity] INT,
	[VolunteerID] INT,
	[TaskCode] INT ,
	CONSTRAINT [PK_Items] PRIMARY KEY ([Id])
  )
  
  CREATE TABLE [PackingLists] (
	[Id] INT IDENTITY,
	[PackingListName] VARCHAR(100),
	[PackingListDescription] VARCHAR(MAX),
	CONSTRAINT [PK_PackingLists] PRIMARY KEY ([Id]),
)

CREATE TABLE [PackingTasks] (
	[Id] INT IDENTITY,
	[AssignmentId] INT NOT NULL,
	[ItemId] INT,
	[PackingListID] INT,
	CONSTRAINT [PK_PackingTasks] PRIMARY KEY ([Id]),
	CONSTRAINT [FK_PackingTasks_Assignments] 
		FOREIGN KEY ([AssignmentId]) REFERENCES [Assignments] ([Id]),
	CONSTRAINT [FK_PackingTasks_Items] 
		FOREIGN KEY ([ItemId]) REFERENCES [Items] ([Id]),
	CONSTRAINT [FK_PackingTasks_PackingLists] 
		FOREIGN KEY ([PackingListID]) REFERENCES [PackingLists] ([Id])
)

INSERT INTO [Volunteers] VALUES ('Jane', 'Ding', 'Gladstone Road 3', 'Highgate', '4223', '33', '423343223')
INSERT INTO [Volunteers] VALUES ('John', 'Doe', 'Sydnet Road 53', 'Tere', '4223', '33', '452342223')
INSERT INTO [Volunteers] VALUES ('Bete', 'Pert', 'Hert Road 33', 'Sydney', '5223', '553', '444343223')
INSERT INTO [Volunteers] VALUES ('Tie', 'Kertd', 'Sydnet Road 3', 'Sydney', '7223', '33', '8763343223')
INSERT INTO [Volunteers] VALUES ('Charles', 'Dert', 'Berr Road 9', 'Sydney', '4223', '33', '423343223')
INSERT INTO [Volunteers] VALUES ('Weber', 'Ding', 'Free Road 4', 'Meler', '4223', '33', '4242234233223')


INSERT INTO [Tasks] VALUES ('Task1', 'Type1', 'done')
INSERT INTO [Tasks] VALUES ('Task2', 'Type2', 'instructed')
INSERT INTO [Tasks] VALUES ('Task3', 'Type1', 'done')
INSERT INTO [Tasks] VALUES ('Task4', 'Type4', 'done')
INSERT INTO [Tasks] VALUES ('Task5', 'Type1', 'done')


INSERT INTO [PackingLists] VALUES ('List one', 'descritpion 1')
INSERT INTO [PackingLists] VALUES ('List two', 'description 2')

INSERT INTO [Items] VALUES ('Item1', '3424', '41',1,1)
INSERT INTO [Items] VALUES ('Item2', '344', '1414',2,2)
INSERT INTO [Items] VALUES ('Item3', '343', '545',3,1)
INSERT INTO [Items] VALUES ('Item4', '54', '54',2,1)
INSERT INTO [Items] VALUES ('Item5', '12', '125',5,2)


INSERT INTO [Assignments] VALUES (1, 2, '2007-05-08 12:35:29','2007-05-09 12:35:29')
INSERT INTO [Assignments] VALUES (2, 1, '2007-05-08 12:35:29','2007-05-09 12:35:29')
INSERT INTO [Assignments] VALUES (4, 4, '2007-05-08 12:35:29','2007-05-09 12:35:29')
INSERT INTO [Assignments] VALUES (2, 5, '2007-05-08 12:35:29','2007-05-09 12:35:29')
INSERT INTO [Assignments] VALUES (3, 3, '2007-05-08 12:35:29','2007-05-09 12:35:29')

INSERT INTO [PackingTasks] VALUES (1, 1, 2)
INSERT INTO [PackingTasks] VALUES (3, 2, 1)
