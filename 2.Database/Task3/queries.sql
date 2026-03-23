USE ProductManagement2;
GO

-- Display all products in the system.
SELECT * FROM Products;
GO

-- Display the product name and price for all products.
SELECT ProductName, Price FROM Products;
GO

-- Display all categories.
SELECT * FROM Categories;
GO

-- Display all products whose price is greater than 1000.
SELECT * FROM Products
WHERE Price > 1000;
GO

-- Display all orders with status Completed.
SELECT * FROM Orders
WHERE [Status] = 'Delivered';

-- Display all suppliers with their phone numbers.
SELECT SupplierName, Phone 
FROM Suppliers;
GO

-- Display each product with its category name.
SELECT p.ProductName as 'Product Name',
c.CategoryName as 'Category'
FROM Products p
JOIN Categories c
ON p.CategoryID = c.CategoryID;

-- Display all products that belong to the Electronics category.
SELECT p.ProductName as 'Product Name',
c.CategoryName as 'Category'
FROM Products p
INNER JOIN Categories c
ON p.CategoryID = c.CategoryID
WHERE CategoryName = 'Electronics';

-- Display the number of products in each category.
SELECT c.CategoryName, COUNT(p.ProductID) AS ProductCount
FROM Categories c
LEFT JOIN Products p 
ON c.CategoryID = p.CategoryID
GROUP BY c.CategoryName;

-- Display categories that do not contain any products.
SELECT c.CategoryName
FROM Categories c
LEFT JOIN Products p 
ON c.CategoryID = p.CategoryID
WHERE p.ProductID IS NULL;

-- Display products along with their manufacturing dates and category names.
SELECT 
    p.ProductName,
    p.ManufacturingDate,
    c.CategoryName
FROM Products p
JOIN Categories c 
ON p.CategoryID = c.CategoryID;


SELECT *
FROM Products
WHERE CategoryID IN (
    SELECT CategoryID
    FROM Categories
    WHERE CategoryName = 'Electronics'
);