﻿CREATE DATABASE MANAGEMENT
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

CREATE TABLE STUDENTGRADE(
    StudentID INT NOT NULL,
    ClassID INT NOT NULL,
    TestName NVARCHAR(50),
    Grade FLOAT,
    constraint pk_stg primary key (StudentID,ClassID)
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
    ScheduleID INT,
    constraint pk_clts primary key (EmployeeID,ClassID)
)


ALTER TABLE EMPLOYEE ADD CONSTRAINT fk_emp FOREIGN KEY (RoleID) REFERENCES ROLE(RoleID)
ALTER TABLE USERS ADD CONSTRAINT fk_usr FOREIGN KEY (RoleID) REFERENCES ROLE(RoleID)
ALTER TABLE COURSE ADD CONSTRAINT fk_co FOREIGN KEY (GradeSchemeID) REFERENCES GRADESCHEME(GradeSchemeID)
ALTER TABLE CLASS ADD CONSTRAINT fk_cls FOREIGN KEY (CourseID) REFERENCES COURSE(CourseID)
ALTER TABLE STUDENT ADD CONSTRAINT fk_st FOREIGN KEY (ClassID) REFERENCES CLASS(ClassID)
ALTER TABLE STUDENTGRADE ADD CONSTRAINT fk_stg1 FOREIGN KEY (StudentID) REFERENCES STUDENT(StudentID)
ALTER TABLE STUDENTGRADE ADD CONSTRAINT fk_stg2 FOREIGN KEY (ClassID) REFERENCES CLASS(ClassID)
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

INSERT INTO CLASS(CourseID, Name, StartDate, EndDate, NumberOfStudents)
VALUES(2, N'TOEFL BASIC 01', '25-05-2022', '28-05-2022',0)

INSERT INTO EMPLOYEE(RoleId, LastName, FirstName, Address, DateOfBirth, Phone, Certificate, Email)
VALUES(3, N'Nguyễn Thế', N'Vỹ', N'43 Trường Chinh','1-1-1981', N'0996353540','' , N'ntbhcmuit@gmail.com')

GO
INSERT INTO CLASS_TEACHER_SCHEDULE(EmployeeID, ClassID)
VALUES(6,2)

GO
UPDATE CLASS_TEACHER_SCHEDULE SET EmployeeID = 3 WHERE ClassId = 2 AND EmployeeID = 

 SELECT * FROM dbo.EMPLOYEE  
                WHERE RoleID = (SELECT RoleID FROM ROLE WHERE Name = 'teacher')
--procedure
GO
CREATE PROC GetAccountByUsername
@username nvarchar(50)
AS 
BEGIN
	SELECT * FROM USERS WHERE Username = @username
END


EXEC USP_GetAccountByUsername @username = N'admin'

--store procedure for Login

GO
CREATE PROC USP_Login
@username nvarchar(50), @password nvarchar(100)
AS 
BEGIN
	SELECT * FROM USERS
	WHERE Username = @username AND Password = @password
END

EXEC USP_Login @username = N'admin', @password = N'1'

