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

    FOREIGN KEY (applicant_id)
    REFERENCES applicants(id),

    FOREIGN KEY (vacancy_id)
    REFERENCES job_vacancies(vacancy_id)
);