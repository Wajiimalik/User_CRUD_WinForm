CREATE DATABASE db_USER_CRUD;

USE db_USER_CRUD;

CREATE TABLE tb_USER
(
	user_id int PRIMARY KEY IDENTITY(1,1),
	u_name varchar(50) NOT NULL,
	age int, 
	city varchar(50) NOT NULL
);

SELECT * FROM tb_USER;