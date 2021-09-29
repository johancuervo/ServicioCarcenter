USE [Carcenter]
GO
DECLARE @DIAS DATE;
SET @DIAS=GETDATE()-60;

SELECT *
FROM clientes cl
INNER JOIN facturas fa ON cl.id = fa.idClientes
GROUP BY cl.id,cl.tipoDocumento,cl.documento,cl.primerNombre,cl.segundoNombre,cl.primerApellido,cl.segundoApellido,cl.celular,cl.direccion,cl.Correo,Fa.id,fa.fechaFactura,fa.totalFactura,fa.idClientes,fa.idMecanicos
HAVING SUM(fa.totalFactura) > 100000 AND fechaFactura>=@DIAS
ORDER BY cl.id

GO

GO
DECLARE @DIAS DATE;
SET @DIAS=GETDATE()-30;
SELECT * FROM Producto pr
INNER JOIN ProductoTiendaFacturas PrTdFt ON pr.id=PrTdFt.ProductoTienda_id
INNER JOIN Facturas fa ON fa.id=PrTdFt.Facturas_id
GROUP BY pr.descripcion,Fa.fechaFactura,pr.id,pr.cantidad,pr.precio,
PrTdFt.id,PrTdFt.ProductoTienda_id,PrTdFt.ProductoTienda_Producto_idProducto,
PrTdFt.ProductoTienda_Tienda_idTienda,PrTdFt.Facturas_id,PrTdFt.Facturas_idClientes,
PrTdFt.Facturas_idMecanicos,fa.id,fa.totalFactura,fa.idClientes,fa.idMecanicos

HAVING fa.fechaFactura>=@DIAS AND SUM(pr.cantidad)>100
GO


GO



CREATE OR ALTER PROCEDURE discountCantidad
AS

UPDATE Producto set cantidad=cantidad-1 SELECT pr.cantidad FROM Producto pr INNER JOIN
ProductoTiendaFacturas ptf ON ptf.ProductoTienda_Producto_idProducto=pr.id

GO


