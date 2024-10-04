-- Day 3 Task

use Company_SD

--1
select *
from Employee

--2
select Fname, Lname, Salary, Dno
from Employee

--3
select Pname, Plocation, Dnum 
from Project

--4
select Fname + '' + Lname as Full_name , (Salary / 100 * 10) as ANNUAL_COMM
from Employee

--5
select SSN, Fname + '' + Lname as Full_name 
from Employee
where Salary > 1000

--6
select SSN, Fname + '' + Lname as Full_name 
from Employee
where Salary * 12 > 10000

--7
select Fname + '' + Lname as Full_name, salary
from Employee
where Sex = 'F'

--8
select Dnum, Dname
from Departments
where MGRSSN = 968574

--9
select Pnumber, Pname, Plocation
from Project
where Dnum = 10
------------------------------------------