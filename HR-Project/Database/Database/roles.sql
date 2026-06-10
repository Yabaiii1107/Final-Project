CREATE TABLE roles (
    role_id INT AUTO_INCREMENT PRIMARY KEY,
    role_name VARCHAR(50) NOT NULL
);

INSERT INTO roles(role_name)
VALUES
('Admin'),
('HR Manager'),
('HR Staff');