use Company_SD
-- Lab Day 3

insert into Employee 
values 
('Rahma', 'Khaled', 102672, '2-06-2003', 'Mohandseen, Giza', 'F', 3000, 112233, 20);

insert into Employee (Fname, Lname, SSN, Bdate, Address, Sex, Dno)
values 
('Alaa', 'Khaled', 102660, '1-01-2005', 'Mohandseen, Giza', 'F', 30);

update employee 
set Salary = Salary + (Salary / 100 * 20)
----------------------------------------------------------------------

