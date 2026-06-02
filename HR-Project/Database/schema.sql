CREATE DATABASE hr_db;

USE hr_db;

CREATE TABLE applicants (
    id INT AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(100),
    last_name VARCHAR(100),
    middle_name VARCHAR(100),
    email VARCHAR(100),
    contact VARCHAR(20),
    password VARCHAR(255)
);