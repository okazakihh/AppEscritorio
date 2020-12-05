
create proc ingreso_listar
as
select i.idingreso as ID, i.idusuario,u.nombre as Usuario,p.nombre as Proveedor,
i.tipo_comprobante as Tipo_Comprobante,i.serie_comprobante as Serie,
i.num_comprobante as Numero,i.fecha as Fecha,i.impuesto as Impuesto,
i.total as Total,i.estado as Estado
from ingreso i inner join usuario u on i.idusuario=u.idusuario
inner join persona p on i.idproveedor=p.idpersona
order by i.idingreso desc
go


create proc ingreso_buscar
@valor varchar(50)
as
select i.idingreso as ID, i.idusuario,u.nombre as Usuario,p.nombre as Proveedor,
i.tipo_comprobante as Tipo_Comprobante,i.serie_comprobante as Serie,
i.num_comprobante as Numero,i.fecha as Fecha,i.impuesto as Impuesto,
i.total as Total,i.estado as Estado
from ingreso i inner join usuario u on i.idusuario=u.idusuario
inner join persona p on i.idproveedor=p.idpersona
where i.num_comprobante like '%' +@valor + '%' Or p.nombre like '%' +@valor + '%' 
order by i.fecha asc
go


create proc ingreso_anular
@idingreso int
as
update ingreso set estado='Anulado'
where idingreso=@idingreso
go


create type types_detalle_ingreso as table
(
	idarticulo int,
	codigo varchar(50),
	articulo varchar(100),
	cantidad int,
	precio decimal(11,2),
	importe decimal(11,2)
);
go


create proc ingreso_insertar
@idusuario int,
@idproveedor int,
@tipo_comprobante varchar(20),
@serie_comprobante varchar(7),
@num_comprobante varchar(10),
@impuesto decimal(4,2),
@total decimal(11,2),
@detalle types_detalle_ingreso READONLY
as
begin

	insert into ingreso (idproveedor,idusuario,tipo_comprobante,serie_comprobante,
	num_comprobante,fecha,impuesto,total,estado)
	values(@idproveedor,@idusuario,@tipo_comprobante,@serie_comprobante,
	@num_comprobante,getdate(),@impuesto,@total,'Aceptado');

	insert detalle_ingreso (idingreso,idarticulo,cantidad,precio)
	select @@IDENTITY,d.idarticulo,d.cantidad,d.precio
	from @detalle d;
end
go
