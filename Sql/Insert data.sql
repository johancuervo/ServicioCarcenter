USE [Carcenter]
GO

INSERT INTO [dbo].[Clientes]
           ([tipoDocumento]
           ,[documento]
           ,[primerNombre]
           ,[segundoNombre]
           ,[primerApellido]
           ,[segundoApellido]
           ,[celular]
           ,[direccion]
           ,[Correo])
     VALUES
           ('CC',125233,'Diego','Andres','Rodriguez','Cadena',32133241,'Diag 22 1123','drodrigz@gmail.com'),
           ('CE',123125,'Juan','Camilo','Contreras','Macias',321542541,'Cr 4312','jcontreras@gmail.com'),
		   ('CE',104123,'Ivan','Andres','Camargo','Caro',321552341,'calle 33 22 11','icamargo@gmail.com'),
		   ('CC',102313,'Laura','Camila','Alvarez','Vega',321576541,'carrera 09481','lalvarez@gmail.com'),
		   ('CC',1213,'Marcela','Silvana','Diaz','Machado',321362541,'Transversal 45 33 12','mdiaz@gmail.com'),
		   ('CE',656423,'Oscar','Daniel','Segura','Cardenas',3262361541,'Carrera 235112','osegura@gmail.com'),
		   ('CC',125233,'Diego','Andres','Rodriguez','Cadena',3213321541,'Diag 22 1123','drodriguez@gmail.com')

GO

GO
INSERT INTO [dbo].[Tienda]
           ([id]
           ,[nombre]
           ,[ciudad])
     VALUES
           (1,'Calle 80','Bogota'),
		   (2,'Mosquera','Mosquera'),
		   (3,'Norte','Cali'),
		   (4,'MallPlaza','Bogota'),
           (5,'Ibague','Ibague'),
           (6,'Girardot','Girardot')

GO

GO
INSERT INTO [dbo].[Producto]
           ([id]
           ,[descripcion]
           ,[cantidad]
		   ,[precio])
		   Values
		   (1,'Tornillos empaque *12 ',40,12000.00),
		   (2,'Madera tipo Wengue ',35,45000.00),
		   (3,'Porcelanato*6',56,25000),
		   (4,'Cable Cat 6 ',100,35000.00),
		   (5,'Ozom Box',15,350000.00)
GO

INSERT INTO [dbo].[Mecanicos]
           ([id]
		   ,[tipoDocumento]
           ,[documento]
           ,[primerNombre]
           ,[segundoNombre]
           ,[primerApellido]
           ,[segundoApellido]
           ,[celular]
           ,[direccion]
           ,[Correo]
		   ,[estado])
     VALUES
           (1,'Carnet',1221514,'Juan','Daniel','Contreras','Diaz',4214515,'Diag 22 1123','afernan@gmail.com','Disponible'),
           (2,'Carnet',25123125,'Juan','Camilo','Vargas','Mesa',321542541,'Cr 4312','jcoeras@gmail.co','Ocupad@'),
		   (3,'Carnet',512512,'Camila','Andrea','Camargo','Caro',321552341,'calle 33 22 11','icamargo@gmail.com','Disponible'),
		   (4,'Carnet',6123123,'Laura','Camila','Alvarez','Vega',321576541,'carrera 09481','lalvarez@gmail.com','Ocupad@')

		   

GO

GO
INSERT INTO [dbo].[Servicios]
           ([id]
           ,[descripcion]
           ,[precioManoObraMin]
		   ,[precioManoObraMax]
		   ,[descuento])
		   Values
		   (1,'Lavado ',30000.00,50000.00,20000.00),
		   (2,'Lavado Polichado ',35000.00,45000.00,30000.00),
		   (3,'Cambio de llantas',56000.00,65000.00,10000.00),
		   (4,'Calibracion de llantas',120000.00,145000.00,50000.00),
		   (5,'Calibracion de frenos',155000.00,185000.00,10000.00)
GO

GO
INSERT INTO [dbo].[RepuestosUsados]
           ([id]
           ,[precioUnidad]
           ,[numeroUnidades]
		   ,[descuento])
		   Values
		   (1,350000.00,3,20000.00),
		   (2,430000.00,5,25000.00),
		   (3,560000.00,4,10000.00),
		   (4,345000.00,3,50000.00),
		   (5,440000.00,2,12000.00)
GO

GO
INSERT INTO [dbo].[ProductoTienda]
           ([id]
           ,[Producto_idProducto]
           ,[Tienda_idTienda])
		   Values
		   (2,3,2),
		   (3,3,3),
		   (4,3,4),
		   (5,1,1),
		   (6,1,2),
		   (7,1,3),
		   (8,1,4),
		   (9,1,5),
		   (10,1,6),
		   (11,2,6),
		   (12,2,5),
		   (13,2,4),
		   (14,3,3),
		   (15,3,2),
		   (16,4,1),
		   (17,4,2),
		   (18,4,4),
		   (19,5,2),
		   (20,5,3),
		   (21,5,4),
		   (22,5,5),
		   (23,5,6),
		   (24,5,5),
		   (25,5,5)	  
GO



GO
INSERT INTO [dbo].[Facturas]
           ([id]
           ,[fechaFactura]
           ,[totalFactura]
		   ,[idClientes]
		   ,[idMecanicos])
		   Values
		   (1,'2020-03-19',500000.00,19,1), 
		   (2,'2020-10-11',630000.00,19,1),
		   (3,'2020-01-22',750000.00,19,1),
		   (4,'2020-03-23',1360000.00,20,1),
		   (5,'2020-05-10',223000.00,20,1),
		   (6,'2020-02-22',1500000.00,20,1),
		   (7,'2020-11-19',2300000.00,20,2),
		   (8,'2020-09-09',760000.00,21,2),
		   (9,'2020-03-13',8400000.00,21,2),
		   (10,'2020-01-03',50000.00,21,2),
		   (11,'2020-07-02',130000.00,21,2),
		   (12,'2020-08-25',943000.00,21,3),
		   (13,'2020-12-22',375000.00,22,3),
	       (14,'2020-10-11',650000.00,22,3),
		   (15,'2020-01-22',1320000.00,22,3),
		   (16,'2020-03-23',450000.00,22,3),
		   (17,'2020-05-10',322000.00,22,3),
		   (18,'2020-11-22',870000.00,22,4),
	       (19,'2020-10-11',765000.00,24,4),
		   (20,'2020-01-22',980000.00,24,4),
		   (21,'2020-03-23',650000.00,24,4),
		   (22,'2020-05-10',923000.00,24,4)
		   

GO
   
   GO

   INSERT INTO [dbo].[ProductoTiendaFacturas]
           ([id]
           ,[ProductoTienda_id]
           ,[ProductoTienda_Producto_idProducto]
		   ,[ProductoTienda_Tienda_idTienda]
		   ,[Facturas_id]
		   ,[Facturas_idClientes]
		   ,[Facturas_idMecanicos]
		   )
		   Values
	(1,2,3,2,1,19,1),
    (2,2,3,2,1,19,1),
    (3,3,3,3,3,19,1),
    (4,4,3,4,4,20,1),
    (5,5,1,1,5,20,1),
    (6,6,1,2,6,20,1),
    (7,7,1,3,7,20,2),
    (8,8,1,4,8,21,2),
    (9,9,1,5,9,21,2),
	(10,10,1,6,10,21,2),
	(11,11,2,6,11,21,2),
	(12,12,2,5,12,21,3),
	(13,13,2,4,13,22,3),
	(14,14,3,3,14,22,3),
	(15,15,3,2,15,22,3) 
		     

   GO
   
		   
		   
		   
		   
		

  