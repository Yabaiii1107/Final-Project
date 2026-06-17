CREATE TABLE IF NOT EXISTS interview_schedules (
    interview_id     INT           NOT NULL AUTO_INCREMENT PRIMARY KEY,
    application_id   INT           NOT NULL,
    interview_date   DATE          NOT NULL,
    interview_time   TIME          NOT NULL,
    mode_location    VARCHAR(255)  NOT NULL,
    interviewer      VARCHAR(255)  NULL,
    status           VARCHAR(50)   NOT NULL DEFAULT 'Scheduled',
    created_at       DATETIME      NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT fk_is_application
        FOREIGN KEY (application_id)
        REFERENCES applications(application_id)
        ON DELETE CASCADE
);