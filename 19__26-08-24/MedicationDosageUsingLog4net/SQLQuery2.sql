create database Assessment4Db;
use Assessment4Db;
CREATE TABLE Prescription (
    PrescriptionID INT PRIMARY KEY, 
    PatientName NVARCHAR(100) NOT NULL,
    
    MedicationName NVARCHAR(100),
    Dosage DOUBLE PRECISION
 );

INSERT INTO  Prescription
(PrescriptionID, PatientName, MedicationName, Dosage ) VALUES 
(1, 'Ameya', 'Dolo 650', 200),
(2, 'Varun', 'Vicks',  150),
(3, 'Balu' , 'Halls', 350);

SELECT * FROM Prescription;
