CREATE DATABASE Apartment;
USE Apartment;
CREATE TABLE Login(
	Email VARCHAR(55),
	Password VARCHAR(55)
);
SELECT* FROM Login
SELECT COUNT (*) FROM Login where Email='rjmanikroj@gmail.com' and Password='asdfghjklc';
INSERT INTO Login VALUES('rjmanikroj@gmail.com','asdfghjklc');
delete from Login where Email='manikroj@gmail.com'