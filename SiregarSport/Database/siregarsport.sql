CREATE DATABASE SiregarSport;
USE SiregarSport;
-- DROP DATABASE siregarsport;

CREATE TABLE ADMIN(
    id CHAR(5) PRIMARY KEY,
    ADMIN VARCHAR(100),
    passwoard VARCHAR(100),
    photo LONGBLOB
);

CREATE TABLE Category(
    id_Category CHAR(5) PRIMARY KEY,
    name_Category VARCHAR(100)
);

CREATE TABLE item(
    id_item CHAR(5) PRIMARY KEY,
    name_item VARCHAR(100),
    id_Category CHAR(5),
    Price INT,
    brand VARCHAR(50),
    stock INT,
    CONSTRAINT fk_item FOREIGN KEY (id_Category) REFERENCES Category(id_Category)
);

CREATE TABLE distributor(
    id_distributor CHAR(5) PRIMARY KEY,
    name_distributor VARCHAR(100),
    address VARCHAR(100)
);

CREATE TABLE customer(
    id_customer CHAR(5) PRIMARY KEY,
    name_customer VARCHAR(100),
    address VARCHAR(100)
);

CREATE TABLE sale(
    id_sale CHAR(5) PRIMARY KEY,
    date_sale DATE,
    id_customer CHAR(5),
    id_item CHAR(5),
    SUM INT,
    CONSTRAINT fk_sale1 FOREIGN KEY (id_customer) REFERENCES customer(id_customer),
    CONSTRAINT fk_sale2 FOREIGN KEY (id_item) REFERENCES item(id_item)
);

CREATE TABLE purchase(
    id_purchase CHAR(5) PRIMARY KEY,
    date_purchase DATE,
    id_distributor CHAR(5),
    id_item CHAR(5),
    SUM INT,
    CONSTRAINT fk_purchase1 FOREIGN KEY (id_distributor) REFERENCES distributor(id_distributor),
    CONSTRAINT fk_purchase2 FOREIGN KEY (id_item) REFERENCES item(id_item)
);

DELIMITER //

-- AFTER INSERT Trigger for sale
CREATE TRIGGER kurangi_stok_item_insert
AFTER INSERT ON sale
FOR EACH ROW
BEGIN
    IF (NEW.SUM IS NOT NULL) THEN
        -- Update stock based on the sales quantity
        UPDATE item
        SET stock = stock - NEW.SUM
        WHERE id_item = NEW.id_item;
    END IF;
END //

-- AFTER UPDATE Trigger for sale
CREATE TRIGGER update_stok_item_update
AFTER UPDATE ON sale
FOR EACH ROW
BEGIN
    IF (NEW.SUM IS NOT NULL AND OLD.SUM IS NOT NULL) THEN
        -- Add stock based on the old sales quantity
        UPDATE item
        SET stock = stock + OLD.SUM
        WHERE id_item = NEW.id_item;

        -- Subtract stock based on the new sales quantity
        UPDATE item
        SET stock = stock - NEW.SUM
        WHERE id_item = NEW.id_item;
    END IF;
END //

-- AFTER DELETE Trigger for sale
CREATE TRIGGER tambah_stok_item_delete
AFTER DELETE ON sale
FOR EACH ROW
BEGIN
    IF (OLD.SUM IS NOT NULL) THEN
        -- Add stock based on the quantity of deleted sales
        UPDATE item
        SET stock = stock + OLD.SUM
        WHERE id_item = OLD.id_item;
    END IF;
END //

DELIMITER ;

DELIMITER //

-- AFTER INSERT Trigger for purchase
CREATE TRIGGER tambah_stok_item_insert
AFTER INSERT ON purchase
FOR EACH ROW
BEGIN
    IF (NEW.SUM IS NOT NULL) THEN
        -- Add purchased quantity to item stock
        UPDATE item
        SET stock = stock + NEW.SUM
        WHERE id_item = NEW.id_item;
    END IF;
END //

-- AFTER UPDATE Trigger for purchase
CREATE TRIGGER tambah_stok_item_update
AFTER UPDATE ON purchase
FOR EACH ROW
BEGIN
    IF (NEW.SUM IS NOT NULL AND OLD.SUM IS NOT NULL) THEN
        -- Subtract old stock
        UPDATE item
        SET stock = stock - OLD.SUM
        WHERE id_item = NEW.id_item;

        -- Add new stock
        UPDATE item
        SET stock = stock + NEW.SUM
        WHERE id_item = NEW.id_item;
    END IF;
END //

-- AFTER DELETE Trigger for purchase
CREATE TRIGGER kurangi_stok_item_delete
AFTER DELETE ON purchase
FOR EACH ROW
BEGIN
    IF (OLD.SUM IS NOT NULL) THEN
        -- Subtract stock based on the deleted purchase quantity
        UPDATE item
        SET stock = stock - OLD.SUM
        WHERE id_item = OLD.id_item;
    END IF;
END //

DELIMITER ;

-- Insert data into ADMIN table
INSERT INTO ADMIN (id, ADMIN, passwoard, photo)
VALUES ('AD01', 'Aeidi', 'aeidi123', LOAD_FILE('C:\\Users\\Aeidi Muttaqin\\source\\repos\\SiregarSport\\SiregarSport\\Resources\\my.jpg'));

-- Insert data into Category table
INSERT INTO Category VALUES 
('C01', 'Sepatu'),
('C02', 'Jersey'),
('C03', 'Raket'),
('C04', 'Bola'),
('C05', 'Perlengkapan Lain');

-- Insert data into item table
INSERT INTO item VALUES
-- Sepatu
('B001', 'Sepatu Basket', 'C01', 900000, 'Under Armour', 40),
('B002', 'Sepatu Tenis', 'C01', 750000, 'Wilson', 50),
('B003', 'Sepatu Voli', 'C01', 680000, 'Mizuno', 30),
('B004', 'Sepatu Lari', 'C01', 830000, 'Reebok', 50),
-- Jersey
('B005', 'Jersey Basket', 'C02', 300000, 'Jordan', 60),
('B006', 'Jersey Sepak Bola', 'C02', 275000, 'Adidas', 40),
('B007', 'Jersey Timnas', 'C02', 350000, 'Specs', 20),
('B008', 'Jersey Klub Lokal', 'C02', 150000, 'Ortuseight', 70),
-- Raket
('B009', 'Raket Control', 'C03', 550000, 'Victor', 40),
('B010', 'Raket All-Around', 'C03', 600000, 'Li-Ning', 35),
('B011', 'Raket Squash', 'C03', 500000, 'Dunlop', 25),
('B012', 'Raket Tenis', 'C03', 700000, 'Babolat', 50),
-- Bola
('B013', 'Bola Sepak', 'C04', 250000, 'Adidas', 100),
('B014', 'Bola Basket', 'C04', 350000, 'Spalding', 80),
('B015', 'Bola Voli', 'C04', 200000, 'Molten', 60),
('B016', 'Bola Futsal', 'C04', 280000, 'Mitre', 50),
-- Perlengkapan Lain
('B017', 'Sarung Tangan Kiper', 'C05', 150000, 'Reusch', 50),
('B018', 'Tas Olahraga', 'C05', 300000, 'Nike', 40),
('B019', 'Kacamata Renang', 'C05', 100000, 'Speedo', 70),
('B020', 'Topi Olahraga', 'C05', 85000, 'Under Armour', 60),
('B021', 'Matras Yoga', 'C05', 120000, 'Manduka', 50),
('B022', 'Skateboard', 'C05', 450000, 'Element', 30),
('B023', 'Protektor Lutut', 'C05', 75000, 'McDavid', 100),
('B024', 'Sweatband', 'C05', 50000, 'Head', 80),
('B025', 'Water Bottle', 'C05', 70000, 'Nike', 90);

-- Insert data into customer table
INSERT INTO customer VALUES
('CU001', 'Iqbal', 'Pariaman'),
('CU002', 'Efengsi Rahmanto', 'PekanBaru'),
('CU003', 'Akbar Hidayat', 'PekanBaru'),
('CU004', 'Afi Naufal', 'Aceh');

-- Insert data into distributor table
INSERT INTO distributor VALUES
('D001', 'Adidas Official Distributor', 'Jl. Sport Center No.1'),
('D002', 'Nike Authorized Distributor', 'Jl. Atletik No.2'),
('D003', 'Puma Distributor', 'Jl. Sepak Bola No.3'),
('D004', 'Under Armour Distributor', 'Jl. Basket No.4'),
('D005', 'Yonex Official Distributor', 'Jl. Bulu Tangkis No.5');

-- Insert data into purchase table
INSERT INTO purchase VALUES
('P001', '2024-12-01', 'D001', 'B001', 10),
('P002', '2024-12-01', 'D002', 'B001', 10),
('P003', '2024-12-01', 'D003', 'B001', 10);

-- Insert data into sale table
INSERT INTO sale VALUES
('S001', '2024-03-30', 'CU001', 'B001', 1),
('S002', '2024-03-30', 'CU002', 'B001', 1),
('S003', '2024-03-30', 'CU003', 'B001', 1);
