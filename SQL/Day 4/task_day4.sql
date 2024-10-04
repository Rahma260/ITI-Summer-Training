--Assignment day 4

use Company_SD

--1
select dep_mgr.Dnum, dep_mgr.Dname, concat (e.Fname, '', e.Lname), dep_mgr.MGRSSN
from Employee e
INNER join Departments dep_mgr
on e.SSN= dep_mgr.MGRSSN

---2
select d.Dname, p.Pname
from Departments d
inner join Project p
on d.Dnum = p.Dnum

--3
select e.Fname, CONCAT(d.Dependent_name,'', d.ESSN,'', d.Sex,'', d.Bdate) as dependent
from Dependent d
inner join Employee e
on e.SSN = d.ESSN

--4
select p.Pnumber, p.Pname, p.Plocation
from Project p
where City in ('cairo', 'alex')

--5
select p.Pname, p.Pnumber, p.Plocation, p.City, p.Dnum
from Project p
where p.Pname like 'a%'

--6
select *
from Employee e
inner join Departments d
on d.Dnum = e.Dno
where d.Dnum = 30 and (e.Salary between 1000 and 2000)

--7
select concat (e.Fname, '', e.Lname)
from Employee e
inner join Departments d
on d.Dnum = e.Dno
inner join Project p 
on d.Dnum = p.Dnum
inner join Works_for w
on p.Pnumber = w.Pno
where d.Dnum = 10 and w.Hours >= 10 and p.Pname = 'AL RABWAH' 

--8
select concat(e.Fname, '' , e.Lname) employee_name
from Employee e
inner join Employee super
on super.SSN = e.Superssn
where super.Fname = 'kamel' and super.Lname = 'mohamed'

--9
select concat(e.Fname, '' , e.Lname) employee_name, p.Pname
from Employee e
inner join Works_for w
on e.SSN = w.ESSn
inner join Project p
on p.Pnumber = w.Pno
order by p.Pname asc

--10
select p.Pnumber, d.Dname, e.Lname, e.Address, e.Bdate
from Project p
inner join Departments d
on d.Dnum = p.Dnum
inner join Employee e
on e.SSN = d.MGRSSN
where p.City = 'cairo'

--11
select *
from Departments d
inner join Employee e
on e.SSN = d.MGRSSN

--12
select e.*, d.*
from Employee e
inner join Dependent d
on e.SSN = d.ESSN