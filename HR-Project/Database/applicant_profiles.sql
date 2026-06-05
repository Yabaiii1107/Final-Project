USE hr_db;

CREATE TABLE applicant_profiles (
    profile_id INT AUTO_INCREMENT PRIMARY KEY,

    applicant_id INT NOT NULL UNIQUE,

    gender ENUM('Male','Female'),

    alternate_phone VARCHAR(20),

    address TEXT,
    province VARCHAR(100),
    postal_code VARCHAR(20),

    profile_picture LONGBLOB,

    FOREIGN KEY (applicant_id)
    REFERENCES applicants(id)
    ON DELETE CASCADE
);
