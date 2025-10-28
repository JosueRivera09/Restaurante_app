USE master;
GO

CREATE DATABASE RestauranteDB;
GO

USE RestauranteDB;
GO

-- Tabla Usuarios (loginPage / rol)
CREATE TABLE Usuarios (
    IdUsuario INT PRIMARY KEY CHECK (IdUsuario BETWEEN 1000 AND 9999),
    NombreUsuario NVARCHAR(50) UNIQUE NOT NULL,
    Contraseña NVARCHAR(255) NOT NULL,
    Rol NVARCHAR(20) NOT NULL CHECK (Rol IN ('Administrador', 'Mesero', 'Cocinero', 'Cajero'))
);
GO

-- Tabla Productos (con imágenes desde recursos)
CREATE TABLE Productos (
    IdProducto INT IDENTITY(1,1) PRIMARY KEY,
    NombreProducto NVARCHAR(100) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    Categoria NVARCHAR(50),
    Estado NVARCHAR(10) NOT NULL CHECK (Estado IN ('Activo', 'Inactivo')),
    ImagenNombre NVARCHAR(100) NOT NULL, -- nombre del recurso en Properties.Resources
    Existencias INT NOT NULL DEFAULT 0,
    Descripcion NVARCHAR(250) NOT NULL DEFAULT 'Sin descripción'
);
GO

--insertar productos
-- Bebidas
INSERT INTO Productos (NombreProducto, Precio, Categoria, Estado, ImagenNombre, Existencias, Descripcion)
VALUES 
('Cervesa Brahma', 70.00, 'Bebidas', 'Activo', 'bebida_brahma', 25, 'Cerveza rubia refrescante'),
('Cervesa', 80.00, 'Bebidas', 'Activo', 'bebida_cervesa', 30, 'Cerveza clásica nacional'),
('Coca-Cola', 50.00, 'Bebidas', 'Activo', 'bebida_cocaCola', 50, 'Refresco gaseoso tradicional'),
('Coctel', 75.00, 'Bebidas', 'Activo', 'bebida_coctel1', 20, 'Coctel frutal tropical'),
('Cerveza corona', 85.00, 'Bebidas', 'Activo', 'bebida_corona', 15, 'Cerveza importada tipo lager'),
('Fanta', 60.00, 'Bebidas', 'Activo', 'bebida_fanta', 40, 'Refresco sabor naranja'),
('Heineken', 80.00, 'Bebidas', 'Activo', 'bebida_heineken', 18, 'Cerveza premium europea'),
('Limonada', 60.25, 'Bebidas', 'Activo', 'bebida_limonada', 35, 'Limonada natural con hielo'),
('Red Bull', 78.36, 'Bebidas', 'Activo', 'bebida_redbull', 22, 'Bebida energética'),
('Sprite', 65.32, 'Bebidas', 'Activo', 'bebida_sprite', 45, 'Refresco sabor lima-limón'),

-- Postres
('Budin', 85.00, 'Postres', 'Activo', 'postre_budin', 12, 'Budín casero de vainilla'),
('Croasan', 60.00, 'Postres', 'Activo', 'postre_croasan', 20, 'Croasan relleno de chocolate'),
('Helado', 80.00, 'Postres', 'Activo', 'postre_helado', 25, 'Helado artesanal de fresa'),
('Paheya', 60.25, 'Postres', 'Activo', 'postre_paheya', 10, 'Postre tradicional dulce'),
('Pastel de chocolate', 78.36, 'Postres', 'Activo', 'postre_pastelChocolate', 15, 'Pastel húmedo de chocolate'),
('Pastel de fresas', 65.32, 'Postres', 'Activo', 'postre_pastelFresas', 18, 'Pastel con fresas frescas');

-- COMIDAS 
INSERT INTO Productos (NombreProducto, Precio, Categoria, Estado, ImagenNombre, Existencias, Descripcion)
VALUES
('Tacos de carne', 85.00, 'Comidas', 'Activo', 'Comida_Tacos_de_carne', 25, 'Tacos rellenos de carne sazonada con vegetales frescos'),
('Arroz con carne', 70.00, 'Comidas', 'Activo', 'Comida_Arroz_carne', 30, 'Arroz blanco acompañado de carne guisada'),
('Combo pollo con arroz', 95.00, 'Comidas', 'Activo', 'Comida_Combo_pollo-arroz', 20, 'Combo completo con pollo asado y arroz'),
('Ensalada con huevo', 60.00, 'Comidas', 'Activo', 'Comida_Ensalada_huevo', 15, 'Ensalada fresca con huevo cocido y aderezo ligero'),
('Ensalada con pescado', 75.00, 'Comidas', 'Inactivo', 'Comida_Ensalada_pescado', 10, 'Ensalada verde con filete de pescado a la plancha'),
('Hamburguesa clásica', 80.00, 'Comidas', 'Activo', 'Comida_hamburguesa', 40, 'Hamburguesa con carne de res, queso y vegetales'),
('Pasta italiana', 90.00, 'Comidas', 'Activo', 'Comida_pasta', 20, 'Pasta con salsa de tomate y especias italianas'),
('Pescado entero', 120.00, 'Comidas', 'Inactivo', 'Comida_Pescado_entero', 12, 'Pescado entero frito con acompañamientos'),
('Pescado con verduras', 110.00, 'Comidas', 'Activo', 'Comida_Pescado_verduras', 18, 'Filete de pescado acompañado de verduras salteadas'),
('Pizza Familiar', 150.00, 'Comidas', 'Activo', 'Comida_Pizza_Familiar', 8, 'Pizza grande con variedad de ingredientes'),
('Pollo con arroz 1', 85.00, 'Comidas', 'Activo', 'Comida_pollo_arroz_1', 22, 'Pollo guisado con arroz y ensalada'),
('Pollo con arroz 2', 88.00, 'Comidas', 'Activo', 'Comida_Pollo_arroz_2', 20, 'Pollo al horno con arroz especiado'),
('Pollo con arroz 3', 90.00, 'Comidas', 'Inactivo', 'Comida_Pollo_arroz_3', 18, 'Pollo frito con arroz y vegetales'),
('Pollo entero', 130.00, 'Comidas', 'Activo', 'Comida_Pollo_Entero', 10, 'Pollo entero asado con papas'),
('Pollo rico', 95.00, 'Comidas', 'Activo', 'Comida_pollo_rico', 16, 'Pollo en salsa especial con arroz'),
('Sándwich mixto', 65.00, 'Comidas', 'Activo', 'Comida_sandwich', 35, 'Sándwich con jamón, queso y vegetales'),
('Sushi variado', 140.00, 'Comidas', 'Inactivo', 'Comida_sushi', 12, 'Rollos de sushi con pescado, arroz y vegetales'),
('Tacos mexicanos', 90.00, 'Comidas', 'Activo', 'Comida_Tacos_mexicanos', 25, 'Tacos tradicionales con carne, cebolla y cilantro');


/*
CREATE TABLE Clientes (
    IdCliente INT IDENTITY(1,1) PRIMARY KEY,
    NombreCliente NVARCHAR(100) NOT NULL
);

--------------------------------------------------------------

CREATE TABLE Pedidos (
    IdPedido INT IDENTITY(1,1) PRIMARY KEY,
    IdCliente INT NULL,
    EstadoPedido NVARCHAR(20) NOT NULL CHECK (EstadoPedido IN ('Pendiente', 'Preparando', 'Listo', 'Entregado')),
    FechaHora DATETIME DEFAULT GETDATE(),
    IdMesero INT NOT NULL,
    FOREIGN KEY (IdCliente) REFERENCES Clientes(IdCliente),
    FOREIGN KEY (IdMesero) REFERENCES Usuarios(IdUsuario)
);

CREATE TABLE DetallePedido (
    IdDetalle INT IDENTITY(1,1) PRIMARY KEY,
    IdPedido INT NOT NULL,
    IdProducto INT NOT NULL,
    Cantidad INT NOT NULL,
    FOREIGN KEY (IdPedido) REFERENCES Pedidos(IdPedido),
    FOREIGN KEY (IdProducto) REFERENCES Productos(IdProducto)
);


----------------------------------------

CREATE TABLE Ventas (
    IdVenta INT IDENTITY(1,1) PRIMARY KEY,
    TipoTransaccion NVARCHAR(10) NOT NULL CHECK (TipoTransaccion IN ('Entrada', 'Salida')),
    FechaTransaccion DATETIME DEFAULT GETDATE(),
    TotalVenta DECIMAL(10,2) NOT NULL,
    IdUsuario INT NOT NULL,
    FOREIGN KEY (IdUsuario) REFERENCES Usuarios(IdUsuario)
);

CREATE TABLE DetalleVenta (
    IdDetalleVenta INT IDENTITY(1,1) PRIMARY KEY,
    IdVenta INT NOT NULL,
    IdProducto INT NOT NULL,
    Cantidad INT NOT NULL,
    PrecioUnitario DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (IdVenta) REFERENCES Ventas(IdVenta),
    FOREIGN KEY (IdProducto) REFERENCES Productos(IdProducto)
);

---------------------------------------------------
CREATE VIEW ProductosMasVendidos AS
SELECT 
    P.NombreProducto,
    SUM(DV.Cantidad) AS TotalVendidos
FROM DetalleVenta DV
INNER JOIN Productos P ON DV.IdProducto = P.IdProducto
GROUP BY P.NombreProducto;

------------------------------------------


CREATE VIEW VentasPorClienteMesero AS
SELECT 
    V.IdVenta,
    C.NombreCliente,
    U.NombreUsuario AS Mesero,
    V.TotalVenta,
    V.FechaTransaccion
FROM Ventas V
INNER JOIN Pedidos P ON V.IdVenta = P.IdPedido
INNER JOIN Clientes C ON P.IdCliente = C.IdCliente
INNER JOIN Usuarios U ON P.IdUsuario = U.IdUsuario;


*/
