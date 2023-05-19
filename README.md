Link Video: https://drive.google.com/file/d/1hEbG5LlpDu9QVXke0v5HKVe2lSJdVsEn/view?usp=share_link


Base de Datos: 

create database dbEmpadronar
go
use dbEmpadronar

create table Personas 
(
Id int identity (1,1) primary key,
Nombre nvarchar (100),
Apellidos nvarchar (100),
DPI int,
Departamento nvarchar (100),
Municipio nvarchar (100)
)


Conexión Sql:
connectionString="Data Source=Alexis;Initial Catalog=dbEmpadronar;Integrated Security=True"
