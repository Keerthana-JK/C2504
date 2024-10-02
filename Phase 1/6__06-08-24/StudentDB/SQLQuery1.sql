create database StudentDB;
use StudentDB;
--create table Student if not exists
if not exists( select * from sys.tables where name = 'Student')
begin /* ( */
	create table Student(id int primary key not null identity(1,1), first_name varchar(50) not null, last_name varchar(50) not null, email nvarchar(100) not null unique);
	--sp_help Student;
end		/* )*/

--(alternate method, checks if table exists)
--select object_id('Student'); 
if object_id('Subjects') is null
begin
	--create table Subjects
	create table Subjects(id int primary key identity,
		[name] nvarchar(100) not null unique)
end

--table Marks
if object_id('Marks') is null
begin
	--create table Marks
	create table Marks(id int primary key identity,
		student_id int not null, 
		subject_id int not null, 
		marks int not null,
		constraint FK_Student foreign key (student_id) references Student(id),
		constraint FK_Subject foreign key (subject_id) references Subjects(id))
end

set IDENTITY_INSERT Student off;

insert into Student(id, first_name, last_name, email) values
(1,'Joe','Doe','johndoe@gmail.com'),
(2,'Elizabeth','Rodrigues','elirodrigues@gmail.com'),
(3,'Samuel','Jose','samjose@gmail.com'),
(4,'Dominic','Fernandez','dominicfernandez@gmail.com'),
(5,'Joanna','Philip','joannaphilip@gmail.com');
select * from Student;

set IDENTITY_INSERT Subjects off;
insert into Subjects(id, name) values
(101,'Maths'),
(102,'Economics'),
(103,'Physics'),
(104,'Chemistry'),
(105,'Biology');
select * from Subjects;

set IDENTITY_INSERT Marks off;
insert into Marks(id, student_id, subject_id, marks) values
(33,1,101,100),
(23,1,102,40),
(44,1,103,60),
(41,1,104,87),
(31,1,105,94),
(68,2,101,67),
(62,2,102,49),
(95,2,103,76),
(46,2,104,17),
(60,2,105,83),
(84,3,101,67),
(96,3,102,88),
(47,3,103,73),
(09,3,104,96),
(75,3,105,94),
(78,4,102,83),
(49,4,103,25),
(45,4,104,65),
(34,4,105,56),
(63,5,101,10),
(39,5,102,90),
(85,5,103,38),
(36,5,104,67),
(94,5,105,83);
select * from Marks;

--we have email, find marks of student (subquery)
select * from marks where student_id=(select id from student where email='Johndoe@gmail.com');
--JOINS

--display id, first, last name of students, marks for subjects 
select Student.id, Student.first_name, Student.last_name, Marks.marks, Marks.subject_id from Student inner join marks on Student.id=Marks.student_id;

--Create View
--create view as Student_marks as 
--	select student.id as Student_id, Student.fname, Student.email, Subjects.name, Marks.mark 
--		inner join mark on Marks.student_id = Student.id
--		inner join Subjects on mark.subject_id = subject.id;

-- STORED PROCEDURES

--Create procedure to Insert data into Student Table
--SP (Non-reusable code)
create procedure InsertIntoStudentTable
as
begin
	insert into Student(id, first_name, last_name, email) 
	values
	(7,'Ananya','BK', 'ananyabk@gmail.com'),
	(8,'Diwan','Kapoor', 'diwankapoor@gmail.com'),
	(9,'Maria','Nicholas', 'mariyan@gmail.com');
end;

--set IDENTITY_INSERT Student on;

--DROP PROCEDURE IF EXISTS InsertIntoStudentTable;
exec InsertIntoStudentTable;

select * from Student;

--SP (Reusable Code)
create procedure sp_NewStudent
	@FirstName varchar(50),
	@LastName varchar(50),
	@Email varchar(100)
as
begin
	insert into Student(first_name, last_name, email)
	VALUES (@FirstName, @LastName, @Email);
end

set IDENTITY_INSERT Student off;
exec sp_NewStudent
	@FirstName = 'Amy',
	@LastName = 'Edward',
	@Email = 'amyedward@gmail.com';

--//To Ensure id is Auto-Increment//
--select column_name, columnproperty(object_id(table_name), column_name, 'isidentity') as isidentity
--from information_schema.columns
--where table_name = 'student';

select * from Student;

--SP for selecting data of all Students

create procedure ShowStudentDetails
as
begin
	select * from Student;
end

exec ShowStudentDetails;