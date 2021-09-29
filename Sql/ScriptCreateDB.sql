CREATE DATABASE Carcenter;
USE Carcenter;

CREATE TABLE  Clientes (
  id INT NOT NULL IDENTITY(1,1),
  tipoDocumento VARCHAR(50) NOT NULL,
  documento INT NOT NULL,
  primerNombre VARCHAR(50) NOT NULL,
  segundoNombre VARCHAR(50) NULL,
  primerApellido VARCHAR(50) NOT NULL,
  segundoApellido VARCHAR(50) NOT NULL,
  celular INT NOT NULL,
  direccion VARCHAR(50) NULL,
  Correo VARCHAR(50) NOT NULL,
  PRIMARY KEY (id));

  CREATE TABLE Mecanicos (
  id INT NOT NULL,
  tipoDocumento VARCHAR(45) NOT NULL,
  documento INT NOT NULL,
  primerNombre VARCHAR(45) NOT NULL,
  segundoNombre VARCHAR(45) NULL,
  primerApellido VARCHAR(45) NOT NULL,
  segundoApellido VARCHAR(45) NOT NULL,
  celular INT NOT NULL,
  direccion VARCHAR(45) NULL,
  correo VARCHAR(45) NOT NULL,
  estado VARCHAR(45) NOT NULL,
  PRIMARY KEY (id));

  CREATE TABLE RepuestosUsados (
  id INT NOT NULL,
  precioUnidad DECIMAL NOT NULL,
  numeroUnidades INT NOT NULL,
  descuento DECIMAL NOT NULL,
  PRIMARY KEY (id));


  CREATE TABLE Servicios (
  id INT NOT NULL,
  descripcion VARCHAR(45) NOT NULL,
  precioManoObraMin DECIMAL NOT NULL,
  precioManoObraMax VARCHAR(45) NOT NULL,
  descuento DECIMAL NOT NULL,
  PRIMARY KEY (id));

  CREATE TABLE Producto (
  id INT NOT NULL,
  descripcion VARCHAR(45) NOT NULL,
  precio Decimal NOT NULL,
  PRIMARY KEY (id));

CREATE TABLE Tienda (
  id INT NOT NULL,
  nombre VARCHAR(45) NOT NULL,
  ciudad VARCHAR(45) NOT NULL,
  PRIMARY KEY (id));

  CREATE TABLE Mantenimientos (
  id INT NOT NULL,
  estado VARCHAR(45) NOT NULL,
  idRepuestosUsados INT NOT NULL,
  idServicios INT NOT NULL,
  PRIMARY KEY (id, idRepuestosUsados, idServicios),
    FOREIGN KEY (idRepuestosUsados)
    REFERENCES RepuestosUsados (id),
    FOREIGN KEY (idServicios)
    REFERENCES Servicios (id));


	CREATE TABLE Facturas (
  id INT NOT NULL,
  fechaFactura DATE NOT NULL,
  totalFactura DECIMAL NOT NULL,
  idClientes INT NOT NULL,
  idMecanicos INT NOT NULL,
  PRIMARY KEY (id, idClientes, idMecanicos),
    FOREIGN KEY (idClientes)
    REFERENCES Clientes (id),
    FOREIGN KEY (idMecanicos)
    REFERENCES Mecanicos (id));

	CREATE TABLE MantenimientosFacturas (
  id INT NOT NULL,
  Mantenimientos_id INT NOT NULL,
  Mantenimientos_idRepuestosUsados INT NOT NULL,
  Mantenimientos_idServicios INT NOT NULL,
  Facturas_id INT NOT NULL,
  Facturas_idClientes INT NOT NULL,
  Facturas_idMecanicos INT NOT NULL,
  PRIMARY KEY (Mantenimientos_id, Mantenimientos_idRepuestosUsados, Mantenimientos_idServicios, Facturas_id, Facturas_idClientes, Facturas_idMecanicos),
    FOREIGN KEY (Mantenimientos_id , Mantenimientos_idRepuestosUsados , Mantenimientos_idServicios)
    REFERENCES Mantenimientos (id , idRepuestosUsados , idServicios)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
    FOREIGN KEY (Facturas_id , Facturas_idClientes , Facturas_idMecanicos)
    REFERENCES Facturas (id , idClientes , idMecanicos)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


CREATE TABLE ProductoTienda (
  id INT NOT NULL,
  Producto_idProducto INT NOT NULL,
  Tienda_idTienda INT NOT NULL,
  PRIMARY KEY (id, Producto_idProducto, Tienda_idTienda),
    FOREIGN KEY (Producto_idProducto)
    REFERENCES Producto (id),
    FOREIGN KEY (Tienda_idTienda)
    REFERENCES Tienda (id));

CREATE TABLE ProductoTiendaFacturas (
  id INT NOT NULL,
  ProductoTienda_id INT NOT NULL,
  ProductoTienda_Producto_idProducto INT NOT NULL,
  ProductoTienda_Tienda_idTienda INT NOT NULL,
  Facturas_id INT NOT NULL,
  Facturas_idClientes INT NOT NULL,
  Facturas_idMecanicos INT NOT NULL,
  PRIMARY KEY (ProductoTienda_id, ProductoTienda_Producto_idProducto, ProductoTienda_Tienda_idTienda, Facturas_id, Facturas_idClientes, Facturas_idMecanicos),
    FOREIGN KEY (ProductoTienda_id , ProductoTienda_Producto_idProducto , ProductoTienda_Tienda_idTienda)
    REFERENCES ProductoTienda (id , Producto_idProducto , Tienda_idTienda)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
    FOREIGN KEY (Facturas_id , Facturas_idClientes , Facturas_idMecanicos)
    REFERENCES Facturas (id , idClientes , idMecanicos)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);