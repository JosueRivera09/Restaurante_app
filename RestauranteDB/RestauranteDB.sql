USE master

CREATE DATABASE RestauranteDB
GO


USE master
GO

CREATE DATABASE RestauranteDB
GO

USE RestauranteDB
GO


-- Tabla Usuarios/ loginPage / rol 
CREATE TABLE Usuarios (
    IdUsuario INT PRIMARY KEY CHECK (IdUsuario BETWEEN 1000 AND 9999),
    NombreUsuario NVARCHAR(50) UNIQUE NOT NULL,
    Contraseña NVARCHAR(255) NOT NULL,
    Rol NVARCHAR(20) NOT NULL
);
GO

/*
CREATE TABLE Productos (
    IdProducto INT IDENTITY(1,1) PRIMARY KEY,
    NombreProducto NVARCHAR(100) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    Categoria NVARCHAR(50),
    Estado NVARCHAR(10) NOT NULL CHECK (Estado IN ('Activo', 'Inactivo'))
);

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

