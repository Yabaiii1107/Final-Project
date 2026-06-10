USE hr_db;

CREATE TABLE documents (
    document_id INT AUTO_INCREMENT PRIMARY KEY,

    applicant_id INT NOT NULL,

    document_type VARCHAR(100),

    file_name VARCHAR(255),

    file_data LONGBLOB,

    upload_date DATETIME DEFAULT CURRENT_TIMESTAMP,

    FOREIGN KEY (applicant_id)
    REFERENCES applicants(id)
    ON DELETE CASCADE
);