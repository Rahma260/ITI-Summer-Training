use Route

--1
create view studentgrade (student_name, course_name)
as
select concat(s.St_Fname, ' ', s.St_Lname), c.Crs_Name
from Student s
join Stud_Course sc
on s.St_Id = sc.St_Id
join Course c
on c.Crs_Id = sc.Crs_Id
where sc.Grade > 50

--2
create view managertopic (manager_name, topic_name)
with encryption
as
select i.Ins_Name, t.Top_Name
from Instructor i
join Ins_Course ic
on i.Ins_Id = ic.Ins_Id
join Course c
on c.Crs_Id = ic.Crs_Id
join Topic t
on t.Top_Id = c.Top_Id
--3
Create schema binding

create view instructordept(instructor_name, department_name)
as
select i.Ins_Name, d.Dept_Name
from Department d
join Instructor i
on d.Dept_Id = i.Ins_Id
where d.Dept_Name = 'SD' OR d.Dept_Name = 'JAVA'

alter schema binding 
transfer instructordept

--4
create view v1 
as
select s.*
from Student s
where s.St_Address like 'alex%'or St_Address like'cairo%'

update v1 
set st_address = 'tanta'
where st_address = 'alex'