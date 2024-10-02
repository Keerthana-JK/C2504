create database Prescription;
use Prescription;
create table Prescription(PrescriptionID int, PatientName varchar(25), MedicationName varchar(25), Dosage float);
insert into Prescription(PrescriptionID, PatientName, MedicationName, Dosage)values
(1, 'Shreya', 'Dolo 650', 30),
(2, 'Nived', 'Paracetamol', 250);
select * from Prescription;
--SELECT PrescriptionID, PatientName, MedicationName, Dosage FROM Prescription;