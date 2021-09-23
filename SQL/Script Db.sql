CREATE TABLE  Clientes (
  id INT NOT NULL,
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

	