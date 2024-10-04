create database iti
use iti

create table student
(
st_id int primary key,
f_name varchar(50),
l_name varchar(50),
age int,
address varchar(50),
dep_id int references department(id),
)
create table department
(
id int primary key,
name varchar(50),
)
create table course
(
id int primary key,
name varchar(50),
duration time,
description varchar(50),
topic_id int references topic(id),
)
create table taken
(
student_id int references student(st_id),
course_id int references course(id),
grade int,
)
create table instructor
(
id int primary key,
name nvarchar(100),
address varchar(50),
salary int,
hourrate int,
bonus int,
dep_id int references department(id),
)
create table manage
(
instructor_id int references instructor(id),
dep_id int references department(id),
hiringdate date,
)
create table teach
(
instructor_id int references instructor(id),
course_id int references course(id),
evalution int,
)
create table topic 
(
id int primary key,
name varchar(50),
)











