﻿--create database
CREATE DATABASE appointments_search_db;
--use db
USE appointments_search_db;
--create users table
CREATE TABLE Users (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    Role NVARCHAR(50) CHECK (Role IN ('admin', 'doctor', 'nurse', 'staff')) NOT NULL,
    CreatedAt DATETIME2 DEFAULT GETDATE(),
    UpdatedAt DATETIME2 DEFAULT GETDATE()
);

--create patients table
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

--create medical history table
CREATE TABLE MedicalHistory (
    MedicalHistoryId INT IDENTITY(1,1) PRIMARY KEY,
    PatientId INT FOREIGN KEY REFERENCES Patients(PatientId) ON DELETE CASCADE,
    Condition NVARCHAR(255) NOT NULL,
    DiagnosisDate DATE NOT NULL,
    Notes NVARCHAR(MAX),
    CreatedAt DATETIME2 DEFAULT GETDATE(),
    UpdatedAt DATETIME2 DEFAULT GETDATE()
);

--create appointments table
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

--create messages table
CREATE TABLE Messages (
    MessageId INT IDENTITY(1,1) PRIMARY KEY,
    FromUserId INT FOREIGN KEY REFERENCES Users(UserId) ON DELETE CASCADE,
    ToUserId INT FOREIGN KEY REFERENCES Users(UserId) ON DELETE CASCADE,
    Message NVARCHAR(MAX) NOT NULL,
    Timestamp DATETIME2 DEFAULT GETDATE(),
    CreatedAt DATETIME2 DEFAULT GETDATE(),
    UpdatedAt DATETIME2 DEFAULT GETDATE()
);

--EHR_IntegrationLogs Table
CREATE TABLE EHR_IntegrationLogs (
    LogId INT IDENTITY(1,1) PRIMARY KEY,
    EHRSystem NVARCHAR(100) NOT NULL,
    PatientId INT FOREIGN KEY REFERENCES Patients(PatientId) ON DELETE CASCADE,
    Operation NVARCHAR(50) CHECK (Operation IN ('import', 'update')) NOT NULL,
    Status NVARCHAR(50) CHECK (Status IN ('success', 'failure')) NOT NULL,
    Details NVARCHAR(MAX),
    Timestamp DATETIME2 DEFAULT GETDATE()
);

--Notifications Table

CREATE TABLE Notifications (
    NotificationId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT FOREIGN KEY REFERENCES Users(UserId) ON DELETE CASCADE,
    Message NVARCHAR(255) NOT NULL,
    IsRead BIT DEFAULT 0,
    CreatedAt DATETIME2 DEFAULT GETDATE()
);
--insert values into table

--Users Table

INSERT INTO Users (Username, Email, PasswordHash, Role, CreatedAt, UpdatedAt)
VALUES
('admin', 'admin@mediconnect.com', 'hashed_password1', 'admin', GETDATE(), GETDATE()),
('dr_john', 'john.doe@mediconnect.com', 'hashed_password2', 'doctor', GETDATE(), GETDATE()),
('nurse_anna', 'anna.smith@mediconnect.com', 'hashed_password3', 'nurse', GETDATE(), GETDATE()),
('staff_mike', 'mike.jones@mediconnect.com', 'hashed_password4', 'staff', GETDATE(), GETDATE());

--Patients Table

INSERT INTO Patients (Name, Dob, Gender, Phone, Email, Address, CreatedAt, UpdatedAt)
VALUES
('Alice Johnson', '1985-04-12', 'Female', '123-456-7890', 'alice.johnson@gmail.com', '123 Elm St, Springfield', GETDATE(), GETDATE()),
('Bob Smith', '1990-08-22', 'Male', '234-567-8901', 'bob.smith@gmail.com', '456 Oak St, Springfield', GETDATE(), GETDATE());

--MedicalHistory Table

INSERT INTO MedicalHistory (PatientId, Condition, DiagnosisDate, Notes, CreatedAt, UpdatedAt)
VALUES
(1, 'Hypertension', '2020-01-15', 'Taking medication daily', GETDATE(), GETDATE()),
(1, 'Diabetes', '2019-06-22', 'On insulin therapy', GETDATE(), GETDATE()),
(2, 'Asthma', '2018-11-05', 'Using inhaler as needed', GETDATE(), GETDATE());

INSERT INTO Appointments (PatientId, DoctorId, Date, Time, Reason, Status, CreatedAt, UpdatedAt)
VALUES
(1, 2, '2024-08-10', '10:00', 'Routine Checkup', 'scheduled', GETDATE(), GETDATE()),
(2, 2, '2024-08-11', '11:00', 'Follow-up on asthma', 'scheduled', GETDATE(), GETDATE());

--Messages Table

INSERT INTO Messages (FromUserId, ToUserId, Message, Timestamp, CreatedAt, UpdatedAt)
VALUES
(2, 1, 'Please review the patient records before our meeting.', GETDATE(), GETDATE(), GETDATE()),
(1, 3, 'Schedule a meeting with the new patient.', GETDATE(), GETDATE(), GETDATE());

--EHR_IntegrationLogs Table

INSERT INTO EHR_IntegrationLogs (EHRSystem, PatientId, Operation, Status, Details, Timestamp)
VALUES
('Epic', 1, 'import', 'success', 'Imported patient records successfully.', GETDATE()),
('Cerner', 2, 'update', 'failure', 'Failed to update patient records.', GETDATE());

--Notifications Table

INSERT INTO Notifications (UserId, Message, IsRead, CreatedAt)
VALUES
(2, 'You have a new appointment scheduled for Alice Johnson on 2024-08-10 at 10:00.', 0, GETDATE()),
(3, 'Please confirm the new meeting with the patient.', 0, GETDATE());

--Display tables
select * from Users;
select * from Patients;
select * from MedicalHistory;
select * from Appointments;
select * from Messages;
select * from EHR_IntegrationLogs;
select * from Notifications;

--Query to Get All Appointments for a Specific Doctor
SELECT * FROM Appointments WHERE DoctorId = 2;

--Query to Get Medical History for a Specific Patient
SELECT * FROM MedicalHistory WHERE PatientId = 1;

--Query to Get All Messages Sent by a Specific User
SELECT * FROM Messages WHERE FromUserId = 2;

--Query to Get All Users with the Role of 'doctor'
SELECT * FROM Users WHERE Role = 'doctor';

--Query to Get All Notifications for a Specific User
SELECT * FROM Notifications WHERE UserId = 2;

--Query to Get All Successful EHR Imports
SELECT * FROM EHR_IntegrationLogs WHERE Operation = 'import' AND Status = 'success';

--Query to Update the Status of an Appointment
UPDATE Appointments
SET Status = 'completed'
WHERE AppointmentId = 1;

--Query to Delete a Patient Record
DELETE FROM Patients
WHERE PatientId = 2;

--Query to Insert a New User
INSERT INTO Users (Username, Email, PasswordHash, Role, CreatedAt, UpdatedAt)
VALUES ('dr_jane', 'jane.doe@mediconnect.com', 'hashed_password5', 'doctor', GETDATE(), GETDATE());