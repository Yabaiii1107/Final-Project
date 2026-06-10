USE hr_db;

CREATE TABLE application_profile_snapshots (
    snapshot_id      INT AUTO_INCREMENT PRIMARY KEY,
    application_id   INT NOT NULL UNIQUE,
    applicant_id     INT NOT NULL,

    first_name       VARCHAR(100),
    last_name        VARCHAR(100),
    middle_name      VARCHAR(100),
    birth_date       DATE,
    email            VARCHAR(100),
    contact          VARCHAR(20),

    gender           ENUM('Male','Female'),
    alternate_phone  VARCHAR(20),
    address          TEXT,
    province         VARCHAR(100),
    postal_code      VARCHAR(20),
    profile_picture  LONGBLOB,

    highest_degree   VARCHAR(100),
    institution_name VARCHAR(255),
    field_of_study   VARCHAR(255),
    graduation_date  DATE,

    snapshotted_at   DATETIME DEFAULT CURRENT_TIMESTAMP,

    FOREIGN KEY (application_id)
        REFERENCES applications(application_id)
        ON DELETE CASCADE,

    FOREIGN KEY (applicant_id)
        REFERENCES applicants(id)
        ON DELETE CASCADE
);

CREATE TABLE snapshot_skills (
    id             INT AUTO_INCREMENT PRIMARY KEY,
    snapshot_id    INT NOT NULL,
    skill_name     VARCHAR(255),
    FOREIGN KEY (snapshot_id)
        REFERENCES application_profile_snapshots(snapshot_id)
        ON DELETE CASCADE
);

CREATE TABLE snapshot_work_experience (
    id               INT AUTO_INCREMENT PRIMARY KEY,
    snapshot_id      INT NOT NULL,
    company_name     VARCHAR(255),
    position_title   VARCHAR(255),
    employment_type  VARCHAR(50),
    start_date       DATE,
    end_date         DATE,
    currently_working TINYINT(1),
    job_description  TEXT,
    FOREIGN KEY (snapshot_id)
        REFERENCES application_profile_snapshots(snapshot_id)
        ON DELETE CASCADE
);