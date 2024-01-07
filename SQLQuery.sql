SELECT Products.Name AS Product, Categories.Name AS Category FROM Products
JOIN ProductsCategories ON ProductsCategories.ProductId = Products.Id
LEFT JOIN Categories ON Categories.Id = ProductsCategories.CategoryId