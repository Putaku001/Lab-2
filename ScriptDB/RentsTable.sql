CREATE TABLE Rentas (
    RentaID INT PRIMARY KEY IDENTITY(1,1),
    ClienteID INT NOT NULL,
    VehiculoID INT NOT NULL,
    FechaRenta DATETIME NOT NULL,
    HoraRenta TIME NOT NULL,
    FechaDevolucion DATETIME NOT NULL,
    HoraDevolucion TIME NOT NULL,
    
    -- Definición de llaves foráneas
    CONSTRAINT FK_Rentas_Clientes FOREIGN KEY (ClienteId) REFERENCES Clientes(ClienteId),
    CONSTRAINT FK_Rentas_Vehiculos FOREIGN KEY (VehiculoId) REFERENCES Vehiculos(VehiculoId)
);

INSERT INTO Rentas (ClienteID, VehiculoID, FechaRenta, HoraRenta, FechaDevolucion, HoraDevolucion)
VALUES 
(1, 1, '2024-10-09 00:00:00', '10:00:00', '2024-10-12 00:00:00', '14:00:00');

select * from Rentas

