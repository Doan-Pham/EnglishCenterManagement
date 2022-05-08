CREATE DATABASE MANAGEMENT
USE MANAGEMENT


CREATE TABLE ROLE(
    RoleID INT NOT NULL IDENTITY(1,1) ,
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
    EmplyeeID INT NOT NULL,
    ClassID INT NOT NULL,
    SheduleID INT NOT NULL,
    constraint pk_clts primary key (EmplyeeID,ClassID,SheduleID)
)
-- ALTER TABLE MONAN ADD CONSTRAINT fk_ma FOREIGN KEY (MaLoaiMonAn) REFERENCES LOAIMONAN(MaLoaiMonAn)
ALTER TABLE EMPLOYEE ADD CONSTRAINT fk_emp FOREIGN KEY (RoleID) REFERENCES ROLE(RoleID)
ALTER TABLE USERS ADD CONSTRAINT fk_usr FOREIGN KEY (RoleID) REFERENCES ROLE(RoleID)
ALTER TABLE COURSE ADD CONSTRAINT fk_co FOREIGN KEY (GradeSchemeID) REFERENCES GRADESCHEME(GradeSchemeID)
ALTER TABLE CLASS ADD CONSTRAINT fk_cls FOREIGN KEY (CourseID) REFERENCES COURSE(CourseID)
ALTER TABLE STUDENT ADD CONSTRAINT fk_st FOREIGN KEY (ClassID) REFERENCES CLASS(ClassID)
ALTER TABLE STUDENTGRADE ADD CONSTRAINT fk_stg1 FOREIGN KEY (StudentID) REFERENCES STUDENT(StudentID)
ALTER TABLE STUDENTGRADE ADD CONSTRAINT fk_stg2 FOREIGN KEY (ClassID) REFERENCES CLASS(ClassID)
ALTER TABLE STUDENTATTENDANCE ADD CONSTRAINT fk_sta1 FOREIGN KEY (StudentID) REFERENCES STUDENT(StudentID)
ALTER TABLE STUDENTATTENDANCE ADD CONSTRAINT fk_sta2 FOREIGN KEY (ClassID) REFERENCES CLASS(ClassID)
ALTER TABLE CLASS_TEACHER_SCHEDULE ADD CONSTRAINT fk_clts1 FOREIGN KEY (EmplyeeID) REFERENCES EMPLOYEE(EmployeeID)
ALTER TABLE CLASS_TEACHER_SCHEDULE ADD CONSTRAINT fk_clts2 FOREIGN KEY (ClassID) REFERENCES CLASS(ClassID)
ALTER TABLE CLASS_TEACHER_SCHEDULE ADD CONSTRAINT fk_clts3 FOREIGN KEY (SheduleID) REFERENCES SCHEDULE(ScheduleID)