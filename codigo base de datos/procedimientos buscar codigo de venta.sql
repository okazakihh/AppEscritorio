create proc articulo_buscar_codigo_venta
@valor varchar(50)
as
select idarticulo,codigo,nombre,precio_venta,stock
from articulo
where codigo=@valor and stock>0
go

create proc articulo_buscar_venta
@valor varchar(50)
as
select a.idarticulo as ID,a.idcategoria,c.nombre as Categoria,
a.codigo as Codigo,a.nombre as Nombre,a.precio_venta as Precio_Venta,
a.stock as Stock,a.descripcion as Descripcion,a.imagen as Imagen,
a.estado as Estado
from articulo a inner join categoria c on a.idcategoria=c.idcategoria
where (a.nombre like '%' +@valor + '%' Or a.descripcion like '%' +@valor + '%')
and a.stock>0
order by a.nombre asc
go

CREATE TRIGGER Venta_ActualizarStock
   ON detalle_venta
   FOR INSERT
   AS
   UPDATE a SET a.stock=a.stock-d.cantidad
   FROM articulo AS a INNER JOIN
   INSERTED AS d ON d.idarticulo=a.idarticulo
go

create proc venta_listar_detalle
@idventa int
as
select d.idarticulo as ID,a.codigo as CODIGO, a.nombre as ARTICULO,
d.cantidad as CANTIDAD,d.precio as PRECIO,d.descuento as DESCUENTO,
((d.cantidad*d.precio)-d.descuento) as IMPORTE
from detalle_venta d inner join articulo a on d.idarticulo=a.idarticulo
where d.idventa=@idventa
go

ALTER proc [dbo].[venta_anular]
@idventa int
as
update venta set estado='Anulado'
where idventa=@idventa;
update articulo
set stock=stock+d.cantidad
from articulo a
inner join
(select idarticulo,cantidad from detalle_venta where idventa=@idventa) as d
on a.idarticulo=d.idarticulo;