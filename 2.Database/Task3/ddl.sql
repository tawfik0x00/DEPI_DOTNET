CREATE DATABASE ProductManagement2;
GO

USE ProductManagement2;
GO


-- Category(CategoryID, CategoryName, Description)
CREATE TABLE Categories (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName NVARCHAR(100) UNIQUE NOT NULL,
    Description NVARCHAR(255)
);
GO

--Product(ProductID, ProductName, Description, Price, ManufacturingDate, CategoryID)
CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    CategoryID INT NOT NULL,
    ProductName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(255),
    Price DECIMAL(10,2) NOT NULL,
    ManufacturingDate DATE DEFAULT GETDATE(),

    -- Constratin
    CONSTRAINT c1_price CHECK(Price >= 0),

    CONSTRAINT c2_LinkWithCategory FOREIGN KEY(CategoryID) 
    REFERENCES Categories (CategoryID)
    ON DELETE NO ACTION
    ON UPDATE CASCADE
);
GO

-- Supplier(SupplierID, SupplierName, Phone, Address)
CREATE TABLE Suppliers (
    SupplierID INT IDENTITY(1,1) PRIMARY KEY,
    SupplierName NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(20) NOT NULL,
    Address NVARCHAR(150) NOT NULL
);
GO

-- ProductSupplier(ProductID, SupplierID)
CREATE TABLE ProductSupplier (
    ProductID INT NOT NULL,
    SupplierID INT NOT NULL,

    CONSTRAINT c1_LinkToProducts FOREIGN KEY(ProductID) 
    REFERENCES Products(ProductID)
    ON DELETE CASCADE,

    CONSTRAINT c2_LinkWithSuppliers FOREIGN KEY (SupplierID)
    REFERENCES Suppliers(SupplierID)
    ON DELETE CASCADE,

    CONSTRAINT c3_PrimaryKey PRIMARY KEY(ProductID, SupplierID)
);
GO

-- Warehouse(WarehouseID, Location, Capacity)
CREATE TABLE Warehouses 
(
    WarehouseID INT IDENTITY(1,1) PRIMARY KEY,
    Location NVARCHAR(150) NOT NULL,
    Capacity INT DEFAULT(0) CHECK(Capacity >= 0)
);
GO

-- ProductWarehouse(ProductID, WarehouseID, Quantity)
CREATE TABLE ProductWarehouse (
    ProductID int NOT NULL,
    WarehouseID INT NOT NULL,
    Quantity INT DEFAULT(0) check(Quantity >= 0),

    CONSTRAINT C1_LinkWithProducts 
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
    ON DELETE CASCADE,

    CONSTRAINT C2_LinkWithWarehouse 
    FOREIGN KEY(WarehouseID) 
    REFERENCES Warehouses(WarehouseID)
    ON DELETE CASCADE,

    CONSTRAINT C3_ProductWarehousePrimaryKey 
    PRIMARY KEY(ProductID, WarehouseID)
);
GO

-- Orders(OrderID, OrderDate, Status)
CREATE TABLE Orders (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    OrderDate DATE DEFAULT GETDATE(),
    Status VARCHAR(50) 
    DEFAULT 'Pending'
    CHECK(Status IN ('Pending','Shipped','Delivered','Cancelled'))
    NOT NULL
);
GO

-- OrderItem(OrderID, ProductID, Quantity, UnitPrice)
CREATE TABLE OrderItems (
    OrderID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT CHECK(Quantity > 0) NOT NULL,
    UnitPrice DECIMAL(10,2)
    NOT NULL CHECK(UnitPrice >= 0),

    CONSTRAINT C1_LinkToOrders
    FOREIGN KEY (OrderID) REFERENCES Orders (OrderID)
    ON UPDATE CASCADE
    ON DELETE CASCADE,

    CONSTRAINT C2_LinkToProducts 
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
    ON DELETE CASCADE,

    CONSTRAINT C3_OrderItemsPrimaryKey 
    PRIMARY KEY(OrderID, ProductID)
);
GO

CREATE INDEX idx_Product_CategoryID ON Products(CategoryID);
CREATE INDEX idx_OrderItems_ProductID ON OrderItems(ProductID);