USE hr_db;

CREATE TABLE interviews (
    interview_id INT AUTO_INCREMENT PRIMARY KEY,

    application_id INT NOT NULL,

    interview_date DATE,
    interview_time TIME,

    interview_mode VARCHAR(50),

    interviewer VARCHAR(255),

    FOREIGN KEY (application_id)
    REFERENCES applications(id)
    ON DELETE CASCADE
);