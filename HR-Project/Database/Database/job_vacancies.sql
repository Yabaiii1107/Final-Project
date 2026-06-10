USE hr_db;

CREATE TABLE job_vacancies
(
    vacancy_id INT AUTO_INCREMENT PRIMARY KEY,

    position VARCHAR(100) NOT NULL,
    department VARCHAR(100) NOT NULL,

    employment_type VARCHAR(50),
    status VARCHAR(50),

    qualifications TEXT,
    requirements TEXT
);