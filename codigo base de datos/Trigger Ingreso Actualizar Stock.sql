CREATE TRIGGER Ingreso_ActualizarStock
   ON detalle_ingreso
   FOR INSERT
   AS
   UPDATE a SET a.stock=a.stock+d.cantidad
   FROM articulo AS a INNER JOIN
   INSERTED AS d ON d.idarticulo=a.idarticulo
go

create proc ingreso_listar_detalle
@idingreso int
as
select d.idarticulo as ID,a.codigo as CODIGO,a.nombre as ARTICULO,
d.cantidad as CANTIDAD,d.precio as PRECIO,(d.precio*d.cantidad) as IMPORTE
from detalle_ingreso d inner join articulo a on d.idarticulo=a.idarticulo
where d.idingreso=@idingreso
go
