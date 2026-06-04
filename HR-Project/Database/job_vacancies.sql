USE hr_db;

CREATE TABLE job_vacancies (
    vacancy_id INT AUTO_INCREMENT PRIMARY KEY,

    position_name VARCHAR(255),
    department VARCHAR(255),

    description TEXT,

    status ENUM('Open','Closed') DEFAULT 'Open'
);