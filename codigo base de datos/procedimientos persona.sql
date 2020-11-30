create proc persona_listar
as
select idpersona as ID, tipo_persona as Tipo_Persona,nombre as Nombre,
tipo_documento as Tipo_Documento,num_documento as Num_Documento,
direccion as Direccion,telefono as Telefono,email as Email
from persona
order by idpersona desc
go

create proc persona_listar_proveedores
as
select idpersona as ID, tipo_persona as Tipo_Persona,nombre as Nombre,
tipo_documento as Tipo_Documento,num_documento as Num_Documento,
direccion as Direccion,telefono as Telefono,email as Email
from persona
where tipo_persona='Proveedor'
order by idpersona desc
go

create proc persona_listar_clientes
as
select idpersona as ID, tipo_persona as Tipo_Persona,nombre as Nombre,
tipo_documento as Tipo_Documento,num_documento as Num_Documento,
direccion as Direccion,telefono as Telefono,email as Email
from persona
where tipo_persona='Cliente'
order by idpersona desc
go

create proc persona_buscar
@valor varchar(50)
as
select idpersona as ID, tipo_persona as Tipo_Persona,nombre as Nombre,
tipo_documento as Tipo_Documento,num_documento as Num_Documento,
direccion as Direccion,telefono as Telefono,email as Email
from persona
where nombre like '%' +@valor + '%' Or email like '%' +@valor + '%'
order by nombre asc
go

create proc persona_buscar_proveedores
@valor varchar(50)
as
select idpersona as ID, tipo_persona as Tipo_Persona,nombre as Nombre,
tipo_documento as Tipo_Documento,num_documento as Num_Documento,
direccion as Direccion,telefono as Telefono,email as Email
from persona
where (nombre like '%' +@valor + '%' Or email like '%' +@valor + '%')
and tipo_persona='Proveedor'
order by nombre asc
go

create proc persona_buscar_clientes
@valor varchar(50)
as
select idpersona as ID, tipo_persona as Tipo_Persona,nombre as Nombre,
tipo_documento as Tipo_Documento,num_documento as Num_Documento,
direccion as Direccion,telefono as Telefono,email as Email
from persona
where (nombre like '%' +@valor + '%' Or email like '%' +@valor + '%')
and tipo_persona='Cliente'
order by nombre asc
go

create proc persona_insertar
@tipo_persona varchar(20),
@nombre varchar(100),
@tipo_documento varchar(20),
@num_documento varchar(20),
@direccion varchar(70),
@telefono varchar(20),
@email varchar(50)
as
insert into persona (tipo_persona,nombre,tipo_documento,num_documento,direccion,telefono,email)
values (@tipo_persona,@nombre,@tipo_documento,@num_documento,@direccion,@telefono,@email)
go

create proc persona_actualizar
@idpersona int,
@tipo_persona varchar(20),
@nombre varchar(100),
@tipo_documento varchar(20),
@num_documento varchar(20),
@direccion varchar(70),
@telefono varchar(20),
@email varchar(50)
as
update persona set tipo_persona=@tipo_persona,nombre=@nombre,
tipo_documento=@tipo_documento,num_documento=@num_documento,direccion=@direccion,
telefono=@telefono,email=@email
where idpersona=@idpersona
go

create proc persona_eliminar
@idpersona int
as
delete from persona
where idpersona=@idpersona
go

create proc persona_existe
@valor varchar(100),
@existe bit output
as
if exists (select nombre from persona where nombre = ltrim(rtrim(@valor)))
	begin
		set @existe=1
	end
else
	begin
		set @existe=0
	end
go