CREATE DATABASE r62db_cr
GO
USE r62db_cr
GO
CREATE TABLE players
(
	playerId INT IDENTITY PRIMARY KEY,
	playerName NVARCHAR(40) NOT NULL,
	dateOfBirth DATE NOT NULL,
	insideDhaka BIT,
	picture NVARCHAR(50)
)
GO
CREATE TABLE sports
(
	sportsId INT PRIMARY KEY IDENTITY,
	sportsName NVARCHAR(50) NOT NULL,
	startDate DATE NOT NULL,
	endDate DATE NOT NULL,
	courseFee MONEY NOT NULL,
	playerId INT NOT NULL REFERENCES players(playerId)
)
GO
GO
CREATE TABLE subjects
(
	id INT PRIMARY KEY IDENTITY,
	[name] VARCHAR(30) NOT NULL
)
Go
create table coaches
(
	coachId INT PRIMARY KEY,
	coachName NVARCHAR(50) NOT NULL,
	coachContact NVARCHAR(50) NOT NULL,
	coachEmail NVARCHAR(30) NOT NULL,
	picture VARBINARY(MAX) NULL,
	subjectId INT REFERENCES subjects(id)
)
Go
INSERT INTO subjects(name) VALUES
('Badmintion'),
('Cricket'),
('Chess'),
('Football'),
('Hockey Sticks'),
('Racing'),
('Werstling')
GO
GO
CREATE TABLE staffs 
(
	id INT IDENTITY PRIMARY KEY,
	[name] VARCHAR(50) NOT NULL,
	city VARCHAR(30) NOT NULL,
	department VARCHAR(30) NOT NULL,
	gender VARCHAR(20) NOT NULL
)
GO
--sp
CREATE PROC spStaffs 
(
	@stafId INT=NULL,
	@name VARCHAR(50)=NULL,
	@city  VARCHAR(30)=NULL,
	@department VARCHAR(30)=NULL,
	@gender VARCHAR(20)=NULL,
	@actionType VARCHAR(25)
)
AS
BEGIN
	IF @actionType='SaveData'
	BEGIN
		IF NOT EXISTS (SELECT * FROM staffs WHERE id=@stafId)
			BEGIN
				INSERT INTO staffs(name,city,department,gender)
				VALUES(@name,@city,@department,@gender)
			END
		ELSE
			BEGIN
				UPDATE staffs SET name=@name,city=@city,department=@department,gender=@gender WHERE id=@stafId
			END
	END
	IF @actionType='DeleteData'
		BEGIN
			DELETE staffs WHERE id=@stafId
		END
	IF @actionType='ShowAllData'
		BEGIN
			SELECT * FROM staffs
		END
	IF @actionType='ShowAllDataById'
		BEGIN
			SELECT * FROM staffs WHERE id=@stafId
		END
END
GO

SELECT * FROM staffs
GO
SELECT * FROM subjects
Go
Select * FROM players
GO
SELECT * FROM sports
GO
SELECT * FROM coaches
GO
INSERT INTO players(playerName,dateOfBirth,insideDhaka,picture) 
VALUES('Tofayel','11-11-1997',1,'abc.png')
GO 
INSERT INTO sports(sportsName,startDate,endDate,courseFee,playerId) VALUES('C#','10-10-2024','12-12-2024',12000,1)
GO
Select t.coachId,t.coachName,t.coachEmail,t.coachContact,t.picture,s.name FROM coaches t INNER JOIN subjects s ON t.subjectId=s.id
GO
SELECT * FROM coaches WHERE coachId=1
GO