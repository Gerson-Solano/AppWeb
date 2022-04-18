create database BD_RRHH;
go

use BD_RRHH;
go

commit;

create table Empleados(
	Id int primary key identity,
	NombreCompleto varchar(100),
	Correo varchar(30),
	Telefono varchar(20),
	FechaRegistro datetime default getDate(),
	Estado char
);
select * from Empleados;
insert into Empleados(NombreCompleto, Correo, Telefono, Estado) values('Gerson Solano', 'gersol@gmail.com', '29394511', 'A');
drop table Empleados
/*
create table Departamentos(
	IdDepartamento int primary key identity,
	Nombre varchar(100),
	Correo varchar(30),
	Telefono varchar(20),
	FechaRegistro varchar(20),
	Estado char(1)
);*/
