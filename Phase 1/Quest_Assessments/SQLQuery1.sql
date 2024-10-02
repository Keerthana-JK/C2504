create database Prescription;
use Prescription;
create table Prescription(PrescriptionID int identity(1,1), PatientName varchar(25), MedicationNameName varchar(25), Dosage float);
set identity_insert Prescription on;
insert into Prescription(PrescriptionID, PatientName, MedicationNameName, Dosage) values
(1,'Aaradhya', 'Dolo 650', 250),
(2,'Mitsuha', 'Calpol', 350),
(3,'Xing', 'Paracetamol',480);
select * from Prescription;