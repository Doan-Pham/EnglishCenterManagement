CREATE DATABASE MANAGEMENT
USE MANAGEMENT

CREATE TABLE ROLE(
    RoleID INT NOT NULL IDENTITY(1,1),
    Name NVARCHAR(50),
    Description NVARCHAR(100),
    constraint pk_ro primary key (RoleID)
)

CREATE TABLE USERS(
    UserID INT NOT NULL IDENTITY(1,1),
    RoleID INT,
    Username NVARCHAR(50),
    Password NVARCHAR(100),
    constraint pk_usr primary key (UserID)
)

CREATE TABLE EMPLOYEE(
    EmployeeID INT NOT NULL IDENTITY(1,1),
    RoleID INT,
    FirstName NVARCHAR(20),
    LastName NVARCHAR(20),
    Address NVARCHAR(100),
    DateOfBirth DATE,
    Phone NVARCHAR(10),
    Certificate NVARCHAR(50),
    Email NVARCHAR(30),
    constraint pk_emp primary key (EmployeeID)
)
-- TODO: ADD THIS
ALTER TABLE EMPLOYEE ADD UserID INT;

ALTER TABLE EMPLOYEE
ADD CONSTRAINT fk_employee_users FOREIGN KEY (UserID) REFERENCES Users(UserID);

CREATE TABLE GRADESCHEME(
    GradeSchemeID INT NOT NULL IDENTITY(1,1),
    Name NVARCHAR(50),
    LowestGrade FLOAT,
    HighestGrade FLOAT,
    Rounding FLOAT,
    constraint pk_grs primary key (GradeSchemeID)
)

CREATE TABLE COURSE(
    CourseID INT NOT NULL IDENTITY(1,1),
    GradeSchemeID INT,
    Name NVARCHAR(50),
    Description NVARCHAR(100),
    NumberOfLessons INT,
    NumberOfWeeks INT,
    Tuition INT,
    StandardGrade FLOAT,
    constraint pk_co primary key (CourseID)
)

CREATE TABLE CLASS(
    ClassID INT NOT NULL IDENTITY(1,1),
    CourseID INT,
    Name NVARCHAR(50),
    NumberOfStudents INT,
    StartDate DATE,
    EndDate DATE,
    constraint pk_cls primary key (ClassID)
)

CREATE TABLE STUDENT(
    StudentID INT NOT NULL IDENTITY(1,1),
    ClassID INT,
    FirstName NVARCHAR(20),
    LastName NVARCHAR(20),
    Address NVARCHAR(100),
    DateOfBirth DATE,
    Phone NVARCHAR(10),
    AverageGrade FLOAT,
    constraint pk_st primary key (StudentID)
)

-- TODO: DROP THIS TABLE
CREATE TABLE STUDENTGRADE(
    StudentID INT NOT NULL,
    ClassID INT NOT NULL,
    TestName NVARCHAR(50),
    Grade FLOAT,
    constraint pk_stg primary key (StudentID,ClassID)
)
DROP TABLE STUDENTGRADE

-- TODO: ADD THESE 2 TABLES
CREATE TABLE TEST(
	TestID INT NOT NULL IDENTITY(1,1),
	ClassID INT,
    Name NVARCHAR(50),
	TestDate DATE,
	StartTime TIME,
    EndTime TIME,
	ROOM NVARCHAR(50),
    NumberOfExaminees INT,
	Type INT,
    constraint pk_t primary key (TestID)
)

CREATE TABLE TESTRESULT(
	TestID INT NOT NULL ,
	StudentID INT NOT NULL,
    Grade FLOAT,
    constraint pk_trs primary key (TestID, StudentID)
)

CREATE TABLE STUDENTATTENDANCE(
    StudentID INT NOT NULL,
    ClassID INT NOT NULL,
    Date DATE NOT NULL,
    IsPresent INT,
    constraint pk_sta primary key (StudentID,ClassID,Date)
)

CREATE TABLE SCHEDULE(
    ScheduleID INT NOT NULL IDENTITY(1,1),
    Date DATE,
    StartTime TIME,
    EndTime TIME,
    constraint pk_sch primary key (ScheduleID)
)

CREATE TABLE CLASS_TEACHER_SCHEDULE(
    EmployeeID INT NOT NULL,
    ClassID INT NOT NULL,
    ScheduleID INT NOT NULL,
    constraint pk_clts primary key (EmployeeID,ClassID,ScheduleID)
)

ALTER TABLE EMPLOYEE ADD CONSTRAINT fk_emp FOREIGN KEY (RoleID) REFERENCES ROLE(RoleID)

ALTER TABLE USERS ADD CONSTRAINT fk_usr FOREIGN KEY (RoleID) REFERENCES ROLE(RoleID)

ALTER TABLE COURSE ADD CONSTRAINT fk_co FOREIGN KEY (GradeSchemeID) REFERENCES GRADESCHEME(GradeSchemeID)

ALTER TABLE CLASS ADD CONSTRAINT fk_cls FOREIGN KEY (CourseID) REFERENCES COURSE(CourseID)

ALTER TABLE STUDENT ADD CONSTRAINT fk_st FOREIGN KEY (ClassID) REFERENCES CLASS(ClassID)

ALTER TABLE STUDENTGRADE ADD CONSTRAINT fk_stg1 FOREIGN KEY (StudentID) REFERENCES STUDENT(StudentID)
ALTER TABLE STUDENTGRADE ADD CONSTRAINT fk_stg2 FOREIGN KEY (ClassID) REFERENCES CLASS(ClassID)

-- TODO: ADD THESE 3 CONSTRAINTS
ALTER TABLE TEST ADD CONSTRAINT fk_t FOREIGN KEY (ClassID) REFERENCES CLASS(ClassID)
ALTER TABLE TESTRESULT ADD CONSTRAINT fk_trs1 FOREIGN KEY (TestID) REFERENCES TEST(TestID)
ALTER TABLE TESTRESULT ADD CONSTRAINT fk_trs2 FOREIGN KEY (StudentID) REFERENCES STUDENT(StudentID)

ALTER TABLE STUDENTATTENDANCE ADD CONSTRAINT fk_sta1 FOREIGN KEY (StudentID) REFERENCES STUDENT(StudentID)
ALTER TABLE STUDENTATTENDANCE ADD CONSTRAINT fk_sta2 FOREIGN KEY (ClassID) REFERENCES CLASS(ClassID)

ALTER TABLE CLASS_TEACHER_SCHEDULE ADD CONSTRAINT fk_clts1 FOREIGN KEY (EmployeeID) REFERENCES EMPLOYEE(EmployeeID)
ALTER TABLE CLASS_TEACHER_SCHEDULE ADD CONSTRAINT fk_clts2 FOREIGN KEY (ClassID) REFERENCES CLASS(ClassID)
ALTER TABLE CLASS_TEACHER_SCHEDULE ADD CONSTRAINT fk_clts3 FOREIGN KEY (ScheduleID) REFERENCES SCHEDULE(ScheduleID)

--Add data
INSERT INTO ROLE(Name, Description)
VALUES(N'admin', N'This is admin')

INSERT INTO ROLE(Name, Description)
VALUES(N'receptionist', N'This is receptionist')

INSERT INTO ROLE(Name, Description)
VALUES(N'teacher', N'This is teacher')

DELETE FROM ROLE

INSERT INTO USERS(RoleID, Username, Password)
VALUES(1, N'admin', N'1')

INSERT INTO GRADESCHEME(Name, LowestGrade, HighestGrade, Rounding)
VALUES (N'IELTS', 1.0, 9.0,0.5)

DELETE FROM GRADESCHEME

INSERT INTO COURSE(GradeSchemeID, Name, Description, NumberOfLessons, NumberOfWeeks, Tuition)
VALUES (7, N'IELTS BASIC', N'IELTS - Basic course', 45, 15, 4000000)

UPDATE COURSE SET GradeSchemeID = 7 , Name = 'A' , Description = '' ,     NumberOfLessons = 45 , NumberOfWeeks = 30 ,     Tuition = 0 , StandardGrade = 30 WHERE CourseID = 2

SELECT GRADESCHEME.Name 
FROM GRADESCHEME, COURSE
WHERE GRADESCHEME.GradeSchemeID = COURSE.GradeSchemeID AND COURSE.CourseID = 2

INSERT INTO USERS(RoleID, Username, Password)
VALUES(1, N'admin', N'1')

SET DATEFORMAT dmy
INSERT INTO EMPLOYEE(RoleId, LastName, FirstName, Address, DateOfBirth, Phone, Certificate, Email)
VALUES(1, N'Nguyễn Thế', N'Bảo', N'43 Trường Chinh','1-1-1981', N'0996353540', NULL, N'ntbhcmuit@gmail.com')

-- Data for tests-related operations
INSERT INTO TEST(ClassId, Name) VALUES (7, 'Test 1')
INSERT INTO TEST(ClassId, Name) VALUES (7, 'Test 2')
INSERT INTO TEST(ClassId, Name) VALUES (7, 'Test 3')
INSERT INTO TEST(ClassId, Name) VALUES (7, 'Test 4')

INSERT INTO TESTRESULT(TestID, StudentID, Grade) VALUES (1, 1, 5.5)
INSERT INTO TESTRESULT(TestID, StudentID, Grade) VALUES (2, 1, 6.6)
INSERT INTO TESTRESULT(TestID, StudentID, Grade) VALUES (3, 1, 7.7)



-- TESTING OUT PIVOT OPERATION - NOT READY FOR USE
SELECT ClassName, StudentID, [1] AS 'Test 1', [2] AS 'Test 2', [3] AS 'Test 3'
FROM
(
SELECT CLASS.ClassID, CLASS.Name AS 'ClassName',STUDENT.StudentID, STUDENT.FirstName, STUDENT.LastName, TEST.TestID, TEST.Name AS 'TestName', TESTRESULT.Grade
FROM CLASS, TEST, TESTRESULT, STUDENT
WHERE  CLASS.ClassID = 7
AND CLASS.ClassID = TEST.ClassID 
	  AND TEST.TestID = TESTRESULT.TestID 
	  AND TESTRESULT.StudentID = STUDENT.StudentID 
	  AND TEST.ClassID = STUDENT.ClassID
	  )TRS

PIVOT
(  
	AVG(Grade)  
	FOR TestID IN  
	( [1], [2], [3] )  
) AS pvt 


SELECT TEST.TestID, TEST.ClassID, TEST.Name, TEST.TestDate, TEST.StartTime, TEST.EndTime, TEST.ROOM, TEST.NumberOfExaminees, TEST.Type
FROM CLASS, TEST
WHERE CLASS.ClassID = 7 AND CLASS.ClassID = TEST.ClassID



DECLARE @tests AS NVARCHAR(MAX), @query  AS NVARCHAR(MAX)
SELECT @tests = STUFF((SELECT ',' + QUOTENAME(Name) 
                    from TEST
                    group by Name
                    order by Name
            FOR XML PATH(''), TYPE
            ).value('.', 'NVARCHAR(MAX)') 
        ,1,1,'')

SET @query = 
'SELECT ' + @tests + 
'FROM   
(SELECT StudentID, TESTRESULT.TestID, Grade , TEST.Name
FROM dbo.TESTRESULT, dbo.TEST 
WHERE TEST.ClassID = 7 AND TEST.TestID = TESTRESULT.TestID AND StudentID = 1 ) TRS
PIVOT
(  
AVG(Grade) FOR TRS.Name IN  
('+ @tests+' )  
) AS pvt   '

EXECUTE(@query)


GO
SELECT [1] AS 'Test 1', [2] 'Test 2', [3] 'Test 3'
FROM   
(SELECT StudentID, TESTRESULT.TestID, Grade , dbo.TEST.Name
FROM dbo.TESTRESULT, dbo.TEST 
WHERE TEST.ClassID = 7 AND TEST.TestID = TESTRESULT.TestID AND StudentID = 1 ) TRS
PIVOT
(  AVG(Grade) FOR TRS.Name IN  
( [1], [2], [3] )  
) AS pvt  



-- SOME RANDOM STUFF
SELECT Grade FROM dbo.TESTRESULT 
WHERE TestId = 1 AND StudentId = 1

SELECT * FROM dbo.TESTRESULT 
WHERE StudentID = 1 AND TestID = 1

UPDATE dbo.TESTRESULT 
SET Grade = 7.5 
WHERE TestID = 3 AND StudentID = 1



--procedure
CREATE PROC GetAccountByUsername
@username nvarchar(50)
AS 
BEGIN
	SELECT * FROM USERS WHERE Username = @username
END

EXEC USP_GetAccountByUsername @username = N'admin'

--store procedure for Login
CREATE PROC USP_Login
@username nvarchar(50), @password nvarchar(100)
AS 
BEGIN
	SELECT * FROM USERS
	WHERE Username = @username COLLATE SQL_Latin1_General_CP1_CS_AS
	AND Password = @password COLLATE SQL_Latin1_General_CP1_CS_AS
END


EXEC USP_Login @username = N'admin', @password = N'1'

