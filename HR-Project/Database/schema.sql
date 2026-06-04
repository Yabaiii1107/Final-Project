USE hr_db;

CREATE TABLE applicants (
    id INT AUTO_INCREMENT PRIMARY KEY,

    first_name VARCHAR(100) NOT NULL,
    last_name VARCHAR(100) NOT NULL,
    middle_name VARCHAR(100),
    birth_date DATE,
   
    email VARCHAR(100) NOT NULL UNIQUE,
    contact VARCHAR(20) NOT NULL UNIQUE,

    password VARCHAR(255) NOT NULL,

    registration_date DATETIME DEFAULT CURRENT_TIMESTAMP
);
