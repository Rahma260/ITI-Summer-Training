--Lab day 4

use Route

--1
select count(St_Fname)
from student 
where St_Age is not null

--2
select DISTINCT Ins_Name  
from Instructor 

--3
select I.Ins_Name, D.Dept_name 
from Instructor I left join Department D
on D.Dept_Id = I.Dept_Id

--4
select s.St_Fname, c.Crs_Name, sc.Grade
from Student s
inner join  Stud_Course sc
on s.St_Id = sc.St_Id
inner join Course c
on c.Crs_Id = sc.Crs_Id

--5
select t.Top_Name, COUNT(Crs_name) number_of_courses
from Course c
inner join Topic t
on t.Top_Id = c.Top_Id
group by t.Top_Name

--6
select s.St_Fname student,concat(s_super.St_Fname, '' , s_super.St_Lname, '' ,s_super.St_Address, s_super.St_Age) super_visor
from Student s, Student s_super 
where s_super.St_Id = s.St_super



