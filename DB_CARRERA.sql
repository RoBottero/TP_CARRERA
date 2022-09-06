Create database Carreras_BD
GO

Use Carreras_BD
GO

create table Carreras (
id_carrera int identity(1,1),
nombre varchar(100) not null,
constraint pk_Carreras primary key (id_carrera)
)

create table Asignaturas (
id_asignatura int identity(1,1),
nombre varchar(100) not null,
constraint pk_Asignaturas primary key (id_asignatura)
)

create table DetalleCarreras(
id_detalleCarrera int identity(1,1),
anio_cursado tinyint not null,
cuatrimestre tinyint not null,
id_carrera int not null,
id_asignatura int not null,
constraint pk_DetalleCarreras primary key (id_detalleCarrera),
constraint fk_Carreras foreign key (id_carrera) references Carreras (id_carrera),
constraint fk_Asignaturas foreign key (id_asignatura) references Asignaturas(id_asignatura)
)


insert into asignaturas values ('Algebra 1')
insert into asignaturas values ('Algebra 2')
insert into asignaturas values ('Fisica')
insert into asignaturas values ('Química')
insert into asignaturas values ('Sistemas Operativos 1')
insert into asignaturas values ('Sistemas Operativos 2')
insert into Asignaturas values('Matemática')
insert into Asignaturas values('Inglés')
insert into Asignaturas values('Programación I')
insert into Asignaturas values('Laboratorio de Computación I')
insert into Asignaturas values('Sistemas de Procesamiento de Datos')
insert into Asignaturas values('Ingles II')
insert into Asignaturas values('Programación II')
insert into Asignaturas values('Laboratorio de Computación II')
insert into Asignaturas values('Arquitectura de Sistemas Operativos')
insert into Asignaturas values('Estadística')
insert into Asignaturas values('Metodología de la Investigación')
insert into Asignaturas values('Programacion III')
insert into Asignaturas values('Laboratorio de Computación III')
insert into Asignaturas values('Organización Contable de la Empresa')
insert into Asignaturas values('Organización Empresarial')
insert into Asignaturas values('Elementos de Investigación Operativa')
insert into Asignaturas values('Metodología de Sistemas')
insert into Asignaturas values('Diseño y administración de Bases de Datos')
insert into Asignaturas values('Legislación')
insert into Asignaturas values('Laboratorio de Computación IV')


select * from asignaturas



create proc sp_consultar_asignaturas
as
begin
	select id_asignatura, nombre from asignaturas
	order by nombre
end

create proc sp_insertar_carrera
@nombre varchar(100),
@new_id_carrera int output
as
begin
	insert into carreras(nombre) values(@nombre);
	set @new_id_carrera = SCOPE_IDENTITY();
end

create proc sp_insertar_detalleCarreras
@anioCursado tinyint,
@cuatrimestre tinyint,
@id_carrera int,
@id_asignatura int

as
begin
	insert into DetalleCarreras(anio_cursado, cuatrimestre, id_carrera, id_asignatura)
	values(@anioCursado, @cuatrimestre, @id_carrera, @id_asignatura)
end

create proc sp_consultar_carreras
as
begin
	select id_carrera, nombre from carreras
	order by id_carrera
end

create proc sp_consultar_detalleCarreras
as
begin
	select c.nombre as 'Carrera',
	a.nombre as 'Nombre Asignatura',
	dc.anio_cursado as 'Año Cursado', 
	dc.cuatrimestre as 'Cuatrimestre'
	from detalleCarreras as dc 
	inner join asignaturas as a on dc.id_asignatura = a.id_asignatura
	inner join carreras as c on dc.id_carrera = c.id_carrera
	order by c.id_carrera
end

alter table detallecarreras
add activo bit

