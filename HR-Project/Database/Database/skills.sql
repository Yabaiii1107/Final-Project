USE hr_db;

CREATE TABLE skills (
    skill_id INT AUTO_INCREMENT PRIMARY KEY,

    applicant_id INT NOT NULL,

    skill_name VARCHAR(255),

    FOREIGN KEY (applicant_id)
    REFERENCES applicants(id)
    ON DELETE CASCADE
);