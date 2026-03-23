CREATE DATABASE ProductManagement;
GO

USE ProductManagement;
GO

-- Creating the tables of the database

-- Category table
CREATE TABLE Categories (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Description NVARCHAR(255) NULL
);
GO

CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Description NVARCHAR(255) NULL,
    Price DECIMAL(10,2) NOT NULL
    CHECK (Price >= 0),
    ManufacturingDate DATE DEFAULT SYSDATETIME(),
    CategoryID INT NOT NULL,

    FOREIGN KEY(CategoryID) 
    REFERENCES Categories(CategoryID)
    ON DELETE NO ACTION 
);
GO

CREATE TABLE Suppliers (
    SupplierID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    City NVARCHAR(100) NULL,
    Street NVARCHAR(100) NULL
);
GO

CREATE TABLE Warehouses (
    WarehouseID INT IDENTITY(1,1) PRIMARY KEY,
    City NVARCHAR(100) NOT NULL,
    Street NVARCHAR(100) NOT NULL,
    Capacity INT NOT NULL CHECK (Capacity >= 0)
);
GO


CREATE TABLE Orders (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    OrderDate DATE DEFAULT SYSDATETIME(),
    OrderStatus NVARCHAR(50) NOT NULL
    CHECK (OrderStatus IN ('Pending','Shipped','Delivered','Cancelled'))
);
GO

-- Junction Tables
CREATE TABLE SupplierNumbers(
    SupplierID INT,
    PhoneNumber NVARCHAR(20),

    -- Primary Key
    PRIMARY KEY (SupplierID, PhoneNumber),
    FOREIGN KEY(SupplierID)
    REFERENCES Suppliers(SupplierID)
    ON DELETE CASCADE
);
GO

CREATE TABLE SuppliedProducts (
    SupplierID INT,
    ProductID INT,

    PRIMARY KEY (SupplierID, ProductID),

    FOREIGN KEY(SupplierID)
    REFERENCES Suppliers(SupplierID)
    ON DELETE CASCADE,

    FOREIGN KEY(ProductID)
    REFERENCES Products(ProductID)
    ON DELETE CASCADE
);
GO

CREATE TABLE WarehouseProducts (
    WarehouseID INT,
    ProductID INT,
    Quantity INT NOT NULL
    CHECK (Quantity >= 0),

    PRIMARY KEY (WarehouseID, ProductID),

    FOREIGN KEY(WarehouseID)
    REFERENCES Warehouses(WarehouseID)
    ON DELETE CASCADE,

    FOREIGN KEY(ProductID)
    REFERENCES Products(ProductID)
    ON DELETE CASCADE
);
GO

CREATE TABLE OrderItems (
    OrderID INT,
    ProductID INT,
    Quantity INT NOT NULL
    CHECK (Quantity > 0),
    UnitPrice DECIMAL(10,2) NOT NULL
    CHECK (UnitPrice >= 0),

    PRIMARY KEY(OrderID, ProductID),

    FOREIGN KEY(OrderID)
    REFERENCES Orders(OrderID)
    ON DELETE CASCADE,

    FOREIGN KEY(ProductID)
    REFERENCES Products(ProductID)
    ON DELETE CASCADE
);
GO


-- Improve the search in Products based on the category
CREATE INDEX idx_products_category ON Products(CategoryID);

CREATE INDEX idx_orderitems_product ON OrderItems(ProductID);

CREATE INDEX idx_warehouseproducts_product ON WarehouseProducts(ProductID);

CREATE INDEX idx_suppliedproducts_product ON SuppliedProducts(ProductID);
