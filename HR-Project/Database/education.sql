USE hr_db;

CREATE TABLE education (
    education_id INT AUTO_INCREMENT PRIMARY KEY,

    applicant_id INT NOT NULL,

    highest_degree VARCHAR(100),
    institution_name VARCHAR(255),
    field_of_study VARCHAR(255),

    graduation_date DATE,

    FOREIGN KEY (applicant_id)
    REFERENCES applicants(id)
    ON DELETE CASCADE
);