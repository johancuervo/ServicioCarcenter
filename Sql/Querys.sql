USE [Carcenter]
GO

SELECT *
FROM clientes cl
INNER JOIN facturas fa ON cl.id = fa.idClientes
GROUP BY cl.id
HAVING SUM(fa.totalFactura) > 100000
ORDER BY cl.id




GO


