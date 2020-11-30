create proc categoria_listar
as 
select idcategoria as ID,nombre as Nombre,descripcion as Descripcion,estado as Estado
from categoria 
order by idcategoria desc
go
create proc categoria_buscar
@valor varchar (50)
as 
select idcategoria as ID,nombre as Nombre,descripcion as Descripcion,estado as Estado
from categoria 
where nombre like '%'+ @valor+ '%' or descripcion like '%'+ @valor + '%'
order by idcategoria desc
go

create proc categoria_insertar
@nombre varchar (50),
@descripcion varchar (255)
as
insert into categoria (nombre, descripcion) values (@nombre, @descripcion)
go

create proc categoria_actualizar
@idcategoria int,
@nombre varchar (50),
@descripcion varchar (255)
as 
update categoria set nombre = @nombre, descripcion = @descripcion
where idcategoria = @idcategoria
go

create proc categoria_eliminar
@idcategoria int
as
delete from categoria
where idcategoria = @idcategoria
go

create proc categoria_desactivar
@idcategoria int
as 
update categoria set estado = 0
where idcategoria = @idcategoria
go

create proc categoria_activar
@idcategoria int
as 
update categoria set estado = 1
where idcategoria = @idcategoria
go

create proc categoria_existe
@valor varchar(100),
@existe bit output
as
	if exists (select nombre from categoria where nombre = ltrim(rtrim(@valor)))
		begin
		set @existe=1
		end
	else
		begin
		set @existe=0
		end
go