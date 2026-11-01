CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(100) NOT NULL,
    Category NVARCHAR(50) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    Quantity INT NOT NULL
);

CREATE TABLE Customers (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerName NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(20),
    Email NVARCHAR(100)
);

INSERT INTO Products (ProductName, Category, Price, Quantity)
VALUES ('Blue Pen', 'Writing', 50.00, 100),
       ('Exercise Book', 'Paper', 120.00, 60);

INSERT INTO Customers (CustomerName, Phone, Email)
VALUES ('John Mwangi', '0712345678', 'john@example.com');