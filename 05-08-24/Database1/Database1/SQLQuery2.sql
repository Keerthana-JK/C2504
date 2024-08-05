--create emp search db
create database emp_search_db;
--use db
use emp_search_db;

--create dept table
create table dept(
	deptno int primary key,
	dname varchar(50),
	loc varchar(50)
);

--create emp table
Create table emp(
	empno int primary key,
	ename varchar(50), 
	job varchar(50), 
	hiredate date, 
	sal int, 
	comm int, 
	deptno int
);

--insert into table dept
insert into dept values(1,'Sales','Kochi');
insert into dept values(2,'IT','Kochi');
insert into dept values(3,'Sales','TVM');
insert into dept values(4,'Finance','Palakkad');
insert into dept values(5,'IT','TVM');

--insert into table emp
insert into emp values(1352,'David','Manager','2022-09-13',2300,500,2);
insert into emp values(1352,'Jones','Programmer','2013-05-18',2000,'200',2);
insert into emp values(1352,'King','President','2015-03-23',5000,'250',4);

--display table dept
select * from dept;

--display table emp
select * from emp;