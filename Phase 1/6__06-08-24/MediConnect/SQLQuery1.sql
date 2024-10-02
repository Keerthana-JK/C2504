--create database
CREATE DATABASE mediconnect_db;
--use db
USE mediconnect_db;
--#1 create users table
CREATE TABLE Users (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    Role NVARCHAR(50) CHECK (Role IN ('admin', 'doctor', 'nurse', 'staff')) NOT NULL,
    CreatedAt DATETIME2 DEFAULT GETDATE(),
    UpdatedAt DATETIME2 DEFAULT GETDATE()
);

--#2 create patients table
CREATE TABLE Patients (
    PatientId INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Dob DATE NOT NULL,
    Gender NVARCHAR(10) CHECK (Gender IN ('Male', 'Female', 'Other')) NOT NULL,
    Phone NVARCHAR(20),
    Email NVARCHAR(100),
    Address NVARCHAR(255),
    CreatedAt DATETIME2 DEFAULT GETDATE(),
    UpdatedAt DATETIME2 DEFAULT GETDATE()
);

--#3 create medical history table
CREATE TABLE MedicalHistory (
    MedicalHistoryId INT IDENTITY(1,1) PRIMARY KEY,
    PatientId INT FOREIGN KEY REFERENCES Patients(PatientId) ON DELETE CASCADE,
    Condition NVARCHAR(255) NOT NULL,
    DiagnosisDate DATE NOT NULL,
    Notes NVARCHAR(MAX),
    CreatedAt DATETIME2 DEFAULT GETDATE(),
    UpdatedAt DATETIME2 DEFAULT GETDATE()
);

--#4 create appointments table
CREATE TABLE Appointments (
    AppointmentId INT IDENTITY(1,1) PRIMARY KEY,
    PatientId INT FOREIGN KEY REFERENCES Patients(PatientId) ON DELETE CASCADE,
    DoctorId INT FOREIGN KEY REFERENCES Users(UserId) ON DELETE CASCADE,
    Date DATE NOT NULL,
    Time TIME NOT NULL,
    Reason NVARCHAR(255),
    Status NVARCHAR(50) CHECK (Status IN ('scheduled', 'completed', 'canceled')) DEFAULT 'scheduled' NOT NULL,
    CreatedAt DATETIME2 DEFAULT GETDATE(),
    UpdatedAt DATETIME2 DEFAULT GETDATE()
);

--#5 create messages table
CREATE TABLE Messages (
    MessageId INT IDENTITY(1,1) PRIMARY KEY,
    FromUserId INT FOREIGN KEY REFERENCES Users(UserId) ON DELETE CASCADE,
    ToUserId INT FOREIGN KEY REFERENCES Users(UserId) /*ON DELETE NO ACTION*/,
    Message NVARCHAR(MAX) NOT NULL,
    Timestamp DATETIME2 DEFAULT GETDATE(),
    CreatedAt DATETIME2 DEFAULT GETDATE(),
    UpdatedAt DATETIME2 DEFAULT GETDATE()
);

--#6 EHR_IntegrationLogs Table
CREATE TABLE EHR_IntegrationLogs (
    LogId INT IDENTITY(1,1) PRIMARY KEY,
    EPatientId INT FOREIGN KEY REFERENCES Patients(PatientId) ON DELETE CASCADE,
    EHRSystem NVARCHAR(100) NOT NULL,
    Operation NVARCHAR(50) CHECK (Operation IN ('import', 'update')) NOT NULL,
    Status NVARCHAR(50) CHECK (Status IN ('success', 'failure')) NOT NULL,
    Details NVARCHAR(MAX),
    Timestamp DATETIME2 DEFAULT GETDATE()
);

--#7 Notifications Table

CREATE TABLE Notifications (
    NotificationId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT FOREIGN KEY REFERENCES Users(UserId) ON DELETE CASCADE,
    Message NVARCHAR(255) NOT NULL,
    IsRead BIT DEFAULT 0,
    CreatedAt DATETIME2 DEFAULT GETDATE(),
    UpdatedAt DATETIME2 DEFAULT GETDATE()
);

--insert values in tables

--insert into Users table

set IDENTITY_INSERT Users off;
INSERT INTO Users (UserId, Username, Email, PasswordHash, Role, CreatedAt, UpdatedAt)
VALUES 
('1', 'john_doe', 'john@example.com', 'hashed_password_1', 'Doctor', GETDATE(), GETDATE()),
('2', 'jane_smith', 'jane@example.com', 'hashed_password_2', 'Nurse', GETDATE(), GETDATE()),
('3', 'emily_jones', 'emily@example.com', 'hashed_password_3', 'Admin', GETDATE(), GETDATE()),
('4', 'michael_brown', 'michael@example.com', 'hashed_password_4', 'Doctor', GETDATE(), GETDATE());

select * from Users;
--insert into Patients table

set IDENTITY_INSERT Patients off;
INSERT INTO Patients (PatientId, Name, Dob, Gender, Phone, Email, Address, CreatedAt, UpdatedAt)
VALUES 
('1', 'Alice Johnson', '1980-05-12', 'Female', '123-456-7890', 'alice@example.com', '123 Main St', GETDATE(), GETDATE()),
('2', 'Bob Smith', '1975-07-23', 'Male', '234-567-8901', 'bob@example.com', '456 Elm St', GETDATE(), GETDATE()),
('3', 'Charlie Brown', '1990-10-10', 'Male', '345-678-9012', 'charlie@example.com', '789 Oak St', GETDATE(), GETDATE()),
('4', 'Diana Prince', '1985-01-15', 'Female', '456-789-0123', 'diana@example.com', '101 Pine St', GETDATE(), GETDATE());
INSERT INTO Patients (PatientId, Name, Dob, Gender, Phone, Email, Address, CreatedAt, UpdatedAt)
VALUES 
('5', 'Eve Adams', '1978-02-25', 'Female', '567-890-1234', 'eve@example.com', '234 Birch St', GETDATE(), GETDATE()),
('6', 'Frank Miller', '1982-09-30', 'Male', '678-901-2345', 'frank@example.com', '567 Cedar St', GETDATE(), GETDATE()),
('7', 'Grace Lee', '1995-11-10', 'Female', '789-012-3456', 'grace@example.com', '890 Dogwood St', GETDATE(), GETDATE()),
('8', 'Henry Wilson', '1987-06-15', 'Male', '890-123-4567', 'henry@example.com', '123 Fir St', GETDATE(), GETDATE()),
('9', 'Ivy Clark', '1992-03-05', 'Female', '901-234-5678', 'ivy@example.com', '456 Green St', GETDATE(), GETDATE()),
('10', 'Jack Harris', '1980-08-22', 'Male', '012-345-6789', 'jack@example.com', '789 Hawthorn St', GETDATE(), GETDATE()),
('11', 'Kara White', '1975-04-17', 'Female', '123-456-7890', 'kara@example.com', '101 Ivy St', GETDATE(), GETDATE()),
('12', 'Leo King', '1990-12-30', 'Male', '234-567-8901', 'leo@example.com', '202 Jasmine St', GETDATE(), GETDATE()),
('13', 'Mona Scott', '1985-01-25', 'Female', '345-678-9012', 'mona@example.com', '303 Lotus St', GETDATE(), GETDATE()),
('14', 'Nina Perez', '1998-05-10', 'Female', '456-789-0123', 'nina@example.com', '404 Maple St', GETDATE(), GETDATE());
select * from Patients;

--insert into MedicalHistory table
set IDENTITY_INSERT MedicalHistory off;
INSERT INTO MedicalHistory (MedicalHistoryId, PatientId, Condition, DiagnosisDate, Notes, CreatedAt, UpdatedAt)
VALUES 
('1', '1', 'Hypertension', '2020-01-01', 'Patient has a history of high blood pressure', GETDATE(), GETDATE()),
('2', '2', 'Diabetes', '2019-05-20', 'Patient diagnosed with type 2 diabetes', GETDATE(), GETDATE()),
('3', '3', 'Asthma', '2018-03-15', 'Patient suffers from chronic asthma', GETDATE(), GETDATE()),
('4', '4', 'Heart Disease', '2021-07-30', 'Patient has a history of heart disease', GETDATE(), GETDATE());
INSERT INTO MedicalHistory (MedicalHistoryId, PatientId, Condition, DiagnosisDate, Notes, CreatedAt, UpdatedAt)
VALUES 
('5', '5', 'Arthritis', '2021-02-01', 'Patient experiencing joint pain.', GETDATE(), GETDATE()),
('6', '6', 'High Cholesterol', '2020-09-15', 'Patient has high cholesterol levels.', GETDATE(), GETDATE()),
('7', '7', 'Migraines', '2019-11-20', 'Patient suffers from chronic migraines.', GETDATE(), GETDATE()),
('8', '8', 'Depression', '2018-06-05', 'Patient undergoing therapy for depression.', GETDATE(), GETDATE()),
('9', '9', 'Eczema', '2022-03-15', 'Patient has skin rash.', GETDATE(), GETDATE()),
('10', '10', 'Osteoporosis', '2019-08-25', 'Patient diagnosed with low bone density.', GETDATE(), GETDATE()),
('11', '11', 'Allergies', '2017-04-10', 'Patient allergic to pollen and dust.', GETDATE(), GETDATE()),
('12', '12', 'Thyroid Disorder', '2021-12-01', 'Patient has hypothyroidism.', GETDATE(), GETDATE()),
('13', '13', 'Chronic Kidney Disease', '2018-01-30', 'Patient has stage 3 CKD.', GETDATE(), GETDATE()),
('14', '14', 'Hypertension', '2023-05-20', 'Patient recently diagnosed with high blood pressure.', GETDATE(), GETDATE());
select * from MedicalHistory;

--insert into Appointments table
set IDENTITY_INSERT Appointments off;
INSERT INTO Appointments (AppointmentId, PatientId, DoctorId, Date, Time, Reason, Status, CreatedAt, UpdatedAt)
VALUES 
('1', '1', '1', '2024-08-10', '10:00', 'Regular check-up', 'Scheduled', GETDATE(), GETDATE()),
('2', '2', '1', '2024-08-11', '11:00', 'Follow-up for diabetes management', 'Scheduled', GETDATE(), GETDATE()),
('3', '3', '2', '2024-08-12', '09:00', 'Asthma consultation', 'Scheduled', GETDATE(), GETDATE()),
('4', '4', '2', '2024-08-13', '14:00', 'Cardiology consultation', 'Scheduled', GETDATE(), GETDATE());
INSERT INTO Appointments (AppointmentId, PatientId, DoctorId, Date, Time, Reason, Status, CreatedAt, UpdatedAt)
VALUES 
('5', '5', '1', '2024-08-14', '10:00', 'Joint pain consultation', 'Scheduled', GETDATE(), GETDATE()),
('6', '6', '1', '2024-08-15', '11:00', 'Cholesterol check-up', 'Scheduled', GETDATE(), GETDATE()),
('7', '7', '2', '2024-08-16', '09:00', 'Migraine treatment', 'Scheduled', GETDATE(), GETDATE()),
('8', '8', '2', '2024-08-17', '14:00', 'Therapy session', 'Scheduled', GETDATE(), GETDATE()),
('9', '9', '1', '2024-08-18', '13:00', 'Skin rash consultation', 'Scheduled', GETDATE(), GETDATE()),
('10', '10', '1', '2024-08-19', '10:00', 'Bone density scan', 'Scheduled', GETDATE(), GETDATE()),
('11', '11', '2', '2024-08-20', '11:00', 'Allergy treatment', 'Scheduled', GETDATE(), GETDATE()),
('12', '12', '2', '2024-08-21', '09:00', 'Thyroid check-up', 'Scheduled', GETDATE(), GETDATE()),
('13', '13', '1', '2024-08-22', '14:00', 'Kidney function test', 'Scheduled', GETDATE(), GETDATE()),
('14', '14', '2', '2024-08-23', '13:00', 'Blood pressure monitoring', 'Scheduled', GETDATE(), GETDATE());
select * from Appointments;

--insert into Messages table
set IDENTITY_INSERT Messages off;
INSERT INTO Messages (MessageId, FromUserId, ToUserId, Message, Timestamp, CreatedAt, UpdatedAt)
VALUES 
('1', '1', '2', 'Please update me on patient Alice Johnson''s status.', GETDATE(), GETDATE(), GETDATE()),
('2', '2', '1', 'Alice Johnson\''s status has been updated.', GETDATE(), GETDATE(), GETDATE()),
('3', '3', '1', 'Reminder: Staff meeting tomorrow at 9 AM.', GETDATE(), GETDATE(), GETDATE()),
('4', '4', '3', 'Confirmed for the meeting.', GETDATE(), GETDATE(), GETDATE());
select * from Messages;

set IDENTITY_INSERT Notifications off;
INSERT INTO Notifications (NotificationId, UserId, Message, IsRead, CreatedAt, UpdatedAt)
VALUES 
('1', '1', 'Your appointment with Alice Johnson is scheduled for 2024-08-10 at 10:00.', 0, GETDATE(), GETDATE()),
('2', '2', 'Your appointment with Bob Smith is scheduled for 2024-08-11 at 11:00.', 0, GETDATE(), GETDATE()),
('3', '3', 'Your appointment with Charlie Brown is scheduled for 2024-08-12 at 09:00.', 0, GETDATE(), GETDATE()),
('4', '4', 'Your appointment with Diana Prince is scheduled for 2024-08-13 at 14:00.', 0, GETDATE(), GETDATE());
select * from Notifications;

set IDENTITY_INSERT EHR_IntegrationLogs on;
INSERT INTO EHR_IntegrationLogs (LogId, EPatientId, EHRSystem, Operation, Status, Details, Timestamp)
VALUES 
('1','1', 'System A', 'import', 'Success', 'Data synced successfully.', GETDATE()),
('2','2', 'System B', 'import','Failure', 'Data sync failed due to network error.', GETDATE()),
('3','3', 'System C', 'import', 'Success', 'Data synced successfully.', GETDATE()),
('4','4', 'System A', 'import', 'Failure', 'Data sync failed due to authentication error.', GETDATE());
select * from EHR_IntegrationLogs;


--QUERIES


-- to find age of Patient with PatientId = 1
SELECT DATEDIFF( YEAR, DOB, Getdate() )  AS AGE 
FROM Patients where PatientId=1;

--number of days left till appointment for each patient
select PatientId, DATEDIFF(day, GETDATE(), Date) from Appointments;

--COUNT
--find count of Patients
SELECT COUNT(*) AS TOTAL_NUM_PATIENTS from Patients;
select * from Patients;

--find count of Users
SELECT COUNT(*) AS TOTAL_NUM_USERS from Users;

--find count of Users
SELECT COUNT(*) AS TOTAL_NUM_APPOINTMENTS from Appointments;

--find count of Female Patients
SELECT COUNT(*) AS TOTAL_NUM_FEMALE from Patients where Gender='Female';

-- to count distinct jobs 
SELECT COUNT(DISTINCT JOB) FROM EMP;


--SUM

-- to find avg of Patient's ages -- two aggregators used to find avg (SUM & COUNT)
SELECT SUM(DATEDIFF( YEAR, DOB, Getdate()))/COUNT(*) AS AVG_AGE FROM Patients;

--AVG

-- to find age of average age of Patients (AVG)
SELECT AVG( DATEDIFF( YEAR, DOB, Getdate() ) ) AS AVG_AGE 
FROM Patients;

-- to find Patients with age less than average age (AVG)
SELECT PatientId
FROM Patients
WHERE DATEDIFF(YEAR, DOB, GETDATE()) < (
    SELECT AVG(DATEDIFF(YEAR, DOB, GETDATE()))
    FROM Patients
);

--MIN
-- to find minimum age from patients (MIN)
SELECT MIN( DATEDIFF( YEAR, DOB, GETDATE() ) ) AS MIN_AGE FROM PATIENTS;

--MAX
-- to find maximum age from patients (MAX)
SELECT MAX( DATEDIFF( YEAR, DOB, GETDATE() ) ) AS MIN_AGE FROM PATIENTS;




-- GROUP BY

--to diplay distinct role of users (using DISTINCT, not using group by)
select distinct(role) from Users;

--to display roles of Users group by role (GROUP BY)
select role from Users group by role;

-- to display the count of users for each role (COUNT & GROUP BY)
SELECT Role, COUNT(UserId) AS UserCount
FROM Users
GROUP BY Role;

--to display number of patients with each condition (COUNT & GROUP BY)
SELECT Condition, COUNT(PatientId) AS PatientCount
FROM MedicalHistory
GROUP BY Condition;

--total number of patients with condition "Hypertension" (COUNT & GROUP BY)
SELECT Condition, COUNT(PatientId) AS PatientCount 
FROM MedicalHistory
WHERE Condition = 'Hypertension'
GROUP BY Condition;

--average number of appointments per doctor (SUB QUERY)
SELECT DoctorId, AVG(AppointmentCount) AS AvgAppointments
FROM (
    SELECT DoctorId, COUNT(AppointmentId) AS AppointmentCount
    FROM Appointments
    GROUP BY DoctorId
) AS DoctorAppointments
GROUP BY DoctorId;

--to display number of successful and failed EHR Integrations (COUNT & GROUP BY)
SELECT Status, COUNT(LogId) AS IntegrationCount
FROM EHR_IntegrationLogs
GROUP BY Status;

--GROUP BY, HAVING

--display number of appointments each patient has (GROUP BY, HAVING)
SELECT PatientId, COUNT(AppointmentId) AS NumberOfAppointments
FROM Appointments
GROUP BY PatientId
HAVING COUNT(AppointmentId) < 5;


--to find the name of the patient with age 30 greater than 30 using HAVING (GROUP BY, HAVING)
SELECT Name, Dob, DATEDIFF(YEAR, DOB, GETDATE()) AS Age
FROM Patients
GROUP BY Name, DOB
HAVING DATEDIFF(YEAR, DOB, GETDATE()) >=30;

--order by name desc
--to find the name of the patient with age 30 greater than 30 using HAVING , then order by name in descending order (GROUP BY, HAVING, ORDER BY)
SELECT Name, Dob, DATEDIFF(YEAR, DOB, GETDATE()) AS Age
FROM Patients
GROUP BY Name, DOB
HAVING DATEDIFF(YEAR, DOB, GETDATE()) >=30
order by name desc;

--to find the name of the patient with age 30 greater than 30 using HAVING , then order by age first and then by name (GROUP BY, HAVING, ORDER BY)
SELECT Name, Dob, DATEDIFF(YEAR, DOB, GETDATE()) AS Age
FROM Patients
GROUP BY Name, DOB
HAVING DATEDIFF(YEAR, DOB, GETDATE()) >=30
order by age, name;

--to display the patient id, date, time of appointments order by time (ORDER BY)
select PatientId,date, time from Appointments order by time;


----View---


SELECT * FROM DEPT; -- normalized
SELECT * FROM EMP;	-- normalized 
-- unormalized table [Sarika, Minnu, Nivya] 
	-- join 
SELECT EMP., DEPT. 
FROM EMP INNER JOIN DEPT ON (EMP.DEPTNO = DEPT.DEPTNO);


-- to display emp cols, dept cols for matched dept
DROP VIEW IF EXISTS EMP_DEPT;
CREATE VIEW EMP_DEPT 
AS 
SELECT EMP.*, DEPT.DNAME, DEPT.LOC  
FROM EMP INNER JOIN DEPT ON (EMP.DEPTNO = DEPT.DEPTNO);

-- display all emp cols and dept cols using view "EMP_DEPT"
SELECT * FROM EMP_DEPT;

-- display ENAME, DNAME
SELECT ENAME, DNAME FROM EMP_DEPT;

DROP VIEW IF EXISTS DEPT_SAL;
CREATE VIEW DEPT_SAL
AS 
SELECT DEPTNO, SUM(SAL) as DEPT_SAL FROM EMP GROUP BY DEPTNO;

SELECT * FROM DEPT_SAL;

sp_help DEPT_SAL;
sp_help EMP_DEPT;

DROP TABLE IF EXISTS MedicalHistory;
CREATE TABLE MedicalHistory (
    MedicalHistoryId INT IDENTITY(1,1),
    PatientId INT,
    Condition NVARCHAR(255),
    DiagnosisDate DATE,
    Notes NVARCHAR(MAX),
    CreatedAt DATETIME2 ,
    UpdatedAt DATETIME2 
);


--Alter Constraints--

ALTER TABLE MedicalHistory
ADD CONSTRAINT PK_MedicalHistory_MedicalHistoryId PRIMARY KEY(MedicalHistoryId);

ALTER TABLE MedicalHistory
ADD CONSTRAINT FK_MedicalHistory_PatientId_Patient_PatientId 
    FOREIGN KEY(PatientId) REFERENCES Patient(PatientId);

ALTER TABLE MedicalHistory
ALTER  Condition  NVARCHAR(255) NOT NULL;

ALTER TABLE MedicalHistory
ALTER  DiagnosisDate  DATE NOT NULL;

ALTER TABLE MedicalHistory
ADD CONSTRAINT DEF_MedicalHistory_CreatedAt DEFAULT GETDATE() FOR CreatedAt;

ALTER TABLE MedicalHistory
ADD CONSTRAINT DEF_MedicalHistory_UpdatedAt DEFAULT GETDATE() FOR UpdatedAt;