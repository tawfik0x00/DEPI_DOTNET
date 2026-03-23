USE ProductManagement2;
GO

-- =========================
-- Insert Categories
-- =========================
INSERT INTO Categories (CategoryName, Description)
VALUES 
('Electronics', 'Devices and gadgets'),
('Clothing', 'Men and women clothes'),
('Food', 'Groceries and consumables');
GO

-- =========================
-- Insert Products
-- =========================
INSERT INTO Products (CategoryID, ProductName, Description, Price, ManufacturingDate)
VALUES
(1, 'Laptop', 'Gaming Laptop', 25000, '2024-01-10'),
(1, 'Headphones', 'Wireless Headphones', 1500, '2024-02-15'),
(2, 'T-Shirt', 'Cotton T-Shirt', 200, '2024-03-01'),
(3, 'Chocolate', 'Dark Chocolate', 50, '2024-02-20');
GO

-- =========================
-- Insert Suppliers
-- =========================
INSERT INTO Suppliers (SupplierName, Phone, Address)
VALUES
('Tech Supplier Co', '01000000001', 'Cairo'),
('Fashion Hub', '01000000002', 'Alexandria'),
('Food Supply Ltd', '01000000003', 'Giza');
GO

-- =========================
-- Insert ProductSupplier
-- =========================
INSERT INTO ProductSupplier (ProductID, SupplierID)
VALUES
(1,1), -- Laptop -> Tech Supplier
(2,1), -- Headphones -> Tech Supplier
(3,2), -- T-Shirt -> Fashion Hub
(4,3); -- Chocolate -> Food Supplier
GO

-- =========================
-- Insert Warehouses
-- =========================
INSERT INTO Warehouses (Location, Capacity)
VALUES
('Cairo Warehouse', 1000),
('Giza Warehouse', 500);
GO

-- =========================
-- Insert ProductWarehouse
-- =========================
INSERT INTO ProductWarehouse (ProductID, WarehouseID, Quantity)
VALUES
(1,1,50),  -- Laptop in Cairo
(2,1,100), -- Headphones in Cairo
(3,2,200), -- T-Shirt in Giza
(4,2,300); -- Chocolate in Giza
GO

-- =========================
-- Insert Orders
-- =========================
INSERT INTO Orders (OrderDate, Status)
VALUES
('2025-03-01','Pending'),
('2025-03-05','Shipped'),
('2025-03-10','Delivered');
GO

-- =========================
-- Insert OrderItems
-- =========================
INSERT INTO OrderItems (OrderID, ProductID, Quantity, UnitPrice)
VALUES
(1,1,1,25000), -- Order 1 -> Laptop
(1,2,2,1500),  -- Order 1 -> Headphones
(2,3,3,200),   -- Order 2 -> T-Shirt
(3,4,5,50);    -- Order 3 -> Chocolate
GO