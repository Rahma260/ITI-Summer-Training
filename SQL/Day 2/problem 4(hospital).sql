create Database Hospital_general
create table patient (
patient_id int primary key identity (1,1),
patient_name varchar (100) not null,
bd date,
--c_id int references consultant (consultant_id),
--w_id int references ward (ward_id),
)
create table consultant (
consultant_id int primary key identity (1,1),
consultant_name varchar (100) not null,
)
create table examine(
p_id int references patient (patient_id),
c_id int references consultant (consultant_id),
primary key (p_id, c_id),
)
create table ward 
(
ward_name varchar(100),
ward_id int primary key identity (1,1),
--number int references nurse (nurse_number),
)
create table nurse
(
nurse_name varchar(100) not null,
nurse_number int primary key ,
address varchar(100),
w_id int references ward (ward_id),
)
create table drug 
(
code int primary key,
dosage int ,
)
create table brand_name
(
brand_name varchar(50),
code_num int references drug(code),
primary key(brand_name, code_num),
)
create table give 
(
code_num int references drug(code),
number int references nurse (nurse_number),
p_id int references patient (patient_id),
date date,
time time,
dosage int,
primary key (p_id),
)


alter table patient
add c_id int references consultant (consultant_id)

alter table patient
add w_id int references ward (ward_id)


alter table ward 
add number int references nurse (nurse_number)