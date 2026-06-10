USE hr_db;

CREATE TABLE applications (
    application_id INT AUTO_INCREMENT PRIMARY KEY,

    applicant_id INT NOT NULL,
    vacancy_id INT NOT NULL,

    application_date DATETIME DEFAULT CURRENT_TIMESTAMP,

    status ENUM(
        'Draft',
        'Submitted',
        'Under Review',
        'Shortlisted',
        'Interview',
        'Final Review',
        'Accepted',
        'Rejected'
    ) DEFAULT 'Submitted',

    profile_completed TINYINT(1) DEFAULT 0,
    documents_uploaded TINYINT(1) DEFAULT 0,
    hr_review TINYINT(1) DEFAULT 0,
    technical_interview TINYINT(1) DEFAULT 0,

    FOREIGN KEY (applicant_id)
        REFERENCES applicants(id),

    FOREIGN KEY (vacancy_id)
        REFERENCES job_vacancies(vacancy_id)
);