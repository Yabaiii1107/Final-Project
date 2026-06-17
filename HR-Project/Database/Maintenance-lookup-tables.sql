USE hr_db;

CREATE TABLE IF NOT EXISTS departments (
    department_id   INT AUTO_INCREMENT PRIMARY KEY,
    department_name VARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE IF NOT EXISTS positions (
    position_id   INT AUTO_INCREMENT PRIMARY KEY,
    position_name VARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE IF NOT EXISTS employment_types (
    employment_id   INT AUTO_INCREMENT PRIMARY KEY,
    employment_type VARCHAR(50)  NOT NULL UNIQUE
);

-- Requirement Types (used for document requirement labels)
CREATE TABLE IF NOT EXISTS requirement_types (
    requirement_id   INT AUTO_INCREMENT PRIMARY KEY,
    requirement_name VARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE IF NOT EXISTS interview_types (
    interview_type_id   INT AUTO_INCREMENT PRIMARY KEY,
    interview_type_name VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE IF NOT EXISTS assessment_types (
    assessment_id   INT AUTO_INCREMENT PRIMARY KEY,
    assessment_name VARCHAR(100) NOT NULL UNIQUE
);

INSERT IGNORE INTO departments (department_name) VALUES
    ('Human Resources'), ('Finance'), ('Information Technology'),
    ('Operations'), ('Marketing'), ('Administration');

INSERT IGNORE INTO positions (position_name) VALUES
    ('HR Manager'), ('HR Staff'), ('Accountant'),
    ('Software Developer'), ('Operations Manager'), ('Admin Assistant');

INSERT IGNORE INTO employment_types (employment_type) VALUES
    ('Full-time'), ('Part-time'), ('Contract'), ('Internship'), ('Freelance');

INSERT IGNORE INTO requirement_types (requirement_name) VALUES
    ('Resume'), ('Government ID'), ('Transcript of Records'),
    ('Certificate of Employment'), ('NBI Clearance'), ('Birth Certificate');

INSERT IGNORE INTO interview_types (interview_type_name) VALUES
    ('Online'), ('Onsite'), ('Phone');

INSERT IGNORE INTO assessment_types (assessment_name) VALUES
    ('Technical Exam'), ('Personality Assessment'),
    ('Background Check'), ('Medical Exam');