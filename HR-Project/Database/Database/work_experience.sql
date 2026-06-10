USE hr_db;

CREATE TABLE work_experience (
    experience_id INT AUTO_INCREMENT PRIMARY KEY,

    applicant_id INT NOT NULL,

    company_name VARCHAR(255),
    position_title VARCHAR(255),

    start_date DATE,
    end_date DATE,

    description TEXT,

    FOREIGN KEY (applicant_id)
    REFERENCES applicants(id)
    ON DELETE CASCADE
);