create database Prescription;
use Prescription;
create table Prescription(PrescriptionID int, PatientName varchar(25), MedicationName varchar(25), Dosage decimal);
exec sp_help Prescription;
insert into Prescription(PrescriptionID,PatientName,MedicationName,Dosage) values (1, 'Suman', 'Dolo 650', 100),
(2, 'Amar', 'Paracetamol', 350),(3, 'Rohit', 'Becosules', 75),(4, 'Jisha', 'Dolo 650', 320),(5, 'Jyothi', 'Vitamin D', 6000);
select * from Prescription;
