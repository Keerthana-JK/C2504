
       CREATE DATABASE TrainersDb;
       USE TrainersDb;
       CREATE TABLE Trainers(Id int PRIMARY KEY IDENTITY(1,1), Name nvarchar(255), Skill nvarchar(255), Place nvarchar(255));
       INSERT INTO Trainers (Name, Skill, Place) VALUES ('Mahesh', 'C#', 'Mysore');
       INSERT INTO Trainers (Name, Skill, Place) VALUES ('Sanjay', 'Management', 'Trivendrum');
       INSERT INTO Trainers (Name, Skill, Place) VALUES ('Mishel', 'WPF', 'Idukki');
       SELECT * FROM Trainers;
