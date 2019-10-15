USE nathanielwheeler;

CREATE TABLE burgershack
(
	id VARCHAR(255) NOT NULL,
	name VARCHAR(255) NOT NULL,
	price decimal(5,2) DEFAULT 5.99,
	description VARCHAR(255) NOT NULL,

	PRIMARY KEY(id)
);
