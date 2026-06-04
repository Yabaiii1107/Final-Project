USE hr_db;

CREATE TABLE updates (
    update_id INT AUTO_INCREMENT PRIMARY KEY,

    applicant_id INT NOT NULL,

    update_message TEXT,

    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,

    FOREIGN KEY (applicant_id)
    REFERENCES applicants(id)
    ON DELETE CASCADE
);