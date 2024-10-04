-- Assignment day 5

use Route

--1
SELECT s.St_Id, CONCAT(s.St_Fname, ' ', s.St_Lname) AS full_name, ISNULL(d.Dept_Name, 'No Department') AS Dept_Name
FROM Student s
LEFT JOIN Department d
ON d.Dept_Id = s.Dept_Id;
 
--2
select i.Ins_Name, isnull(i.Salary, 100)
from Instructor i

--3
select super.St_Fname as supervisor_name, count(s.St_Id) as num_of_students
from Student s 
right join Student super
on super.St_Id = s.St_super
group by super.St_Fname

--4
select t.Top_Name, COUNT( c.Crs_Id ) as num_of_courses
from Topic t
join Course c
on t.Top_Id = c.Top_Id
group by t.Top_Name

--5
select MAX(Salary) max_salary, MIN(Salary) min_salary
from Instructor

--6
select *
from Instructor i
where i.Salary < (select avg(Salary) from Instructor)

--7
select d.Dept_Name
from Department d
join Instructor i
on d.Dept_Id = i.Dept_Id
where i.Salary = (select min(Salary) from Instructor)

--8
select top(2) Salary
from Instructor
order by Salary desc

--9
select avg(Salary)
from Instructor
where Salary is not null
-- OR --
select sum(Salary) / count(Salary)
from Instructor

