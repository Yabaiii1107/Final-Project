USE hr_db;

CREATE TABLE application_status_history (
    history_id     INT AUTO_INCREMENT PRIMARY KEY,
    application_id INT NOT NULL,
    status         VARCHAR(50) NOT NULL,
    changed_at     DATETIME DEFAULT CURRENT_TIMESTAMP,

    FOREIGN KEY (application_id)
        REFERENCES applications(application_id)
        ON DELETE CASCADE
);