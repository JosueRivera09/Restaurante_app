USE master

USE RestauranteDB

-- Insertar usuarios en la tabla Usuarios
INSERT INTO Usuarios (IdUsuario, NombreUsuario, Contraseña, Rol)
VALUES 
(1001, 'Maria Gonzalez', 'Maria123', 'Administrador'),
(1002, 'Carlos Mendez', 'Carlos123', 'Mesero'),
(1003, 'Ana Rodriguez', 'Ana123', 'Cocinero'),
(1004, 'Jose Ramirez', 'Jose123', 'Mesero'),
(1005, 'Laura Martinez', 'Laura123', 'Cajero');

SELECT * FROM Usuarios
GO
