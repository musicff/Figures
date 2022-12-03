SELECT p.Name ProductName, c.Name CategoryName
FROM Product p
LEFT JOIN ProductCategory pc ON pc.ProductId = p.Id
LEFT JOIN Category c ON c.Id = pc.CategoryId