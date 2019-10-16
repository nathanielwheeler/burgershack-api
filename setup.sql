USE nathanielwheeler;

-- CREATE TABLE burgershackMenu
-- (
-- 	id VARCHAR(255) NOT NULL,
-- 	name VARCHAR(255) NOT NULL,
-- 	price decimal(5,2) DEFAULT 5.99,
-- 	description VARCHAR(255) NOT NULL,

-- 	PRIMARY KEY(id)
-- );

-- DROP TABLE burgershackMenu

-- CREATE TABLE burgershackOrders
-- (
-- 	id INT NOT NULL AUTO_INCREMENT,
-- 	total DECIMAL(9, 2) NOT NULL,
-- 	PRIMARY KEY (id)
-- );

-- CREATE TABLE burgershackMenuOrders
-- (
-- 	id INT NOT NULL AUTO_INCREMENT,
-- 	menuId VARCHAR(255) NOT NULL,
-- 	orderId INT NOT NULL,

-- 	INDEX(orderId),

-- 	FOREIGN KEY(menuId)
-- 		REFERENCES burgershackMenu(id)
-- 		ON DELETE CASCADE,

-- 	FOREIGN KEY(orderId)
-- 		REFERENCES burgershackOrders(id)
-- 		ON DELETE CASCADE,

-- 	PRIMARY KEY (id)
-- );

