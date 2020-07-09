CREATE TABLE products(
  id INT NOT NULL PRIMARY KEY,
  name VARCHAR(255)
 );

CREATE TABLE categories(
  id INT NOT NULL PRIMARY KEY,
  name VARCHAR(255)
);

CREATE TABLE ProductCategories(
    productId INT NOT NULL,
    categoryId INT NOT NULL,
	FOREIGN KEY (productId) REFERENCES products(id),    
	FOREIGN KEY (categoryId) REFERENCES categories(id)    
);

SELECT P.Name, C.Name
FROM products P
LEFT JOIN ProductCategories PC
	ON P.id = PC.productId
LEFT JOIN categories C
	ON PC.categoryId = c.Id;