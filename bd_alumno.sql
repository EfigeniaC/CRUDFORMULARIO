CREATE DATABASE crudAlumnos
GO
USE crudAlumnos
GO

CREATE TABLE Alumnos(
	idAlumnos int IDENTITY(1,1) PRIMARY KEY,
	nombre varchar(50) NOT NULL,
	apellidos varchar(50) NOT NULL,
	sexo char(1),
	numero varchar(9) NOT NULL,
	email varchar(40) NOT NULL,
);
insert into Alumnos values ('dd','Carrasco', 'M','967687871','jose@gmail.com')
select*from Alumnos
delete from Alumnos where idAlumnos= 4 