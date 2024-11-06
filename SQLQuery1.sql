CREATE TABLE Vehicles (
    VehicleID INT IDENTITY(1,1) PRIMARY KEY,
    Make NVARCHAR(50),
    Model NVARCHAR(50),
    Year INT,
    Price DECIMAL(10, 2),
    IsElectric BIT,
    Color NVARCHAR(30),
    CreatedDate DATETIME,
    Image VARBINARY(MAX)
);

INSERT INTO Vehicles ( Make, Model, Year, Price, IsElectric, Color, CreatedDate, Image)
VALUES 
('Toyota', 'Camry', 2020, 24000.00, 0, 'Blue', GETDATE(), NULL),
('Tesla', 'Model 3', 2021, 35000.00, 1, 'Red', GETDATE(), NULL),
('Ford', 'Mustang', 2019, 26000.00, 0, 'Black', GETDATE(), NULL),
('Honda', 'Civic', 2022, 22000.00, 0, 'White', GETDATE(), NULL),
('Nissan', 'Leaf', 2021, 31000.00, 1, 'Green', GETDATE(), NULL);