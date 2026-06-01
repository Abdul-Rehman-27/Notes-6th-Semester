--CREATE TABLE Users
--(
--    UserID    INT IDENTITY(1,1) PRIMARY KEY,
--    FullName  NVARCHAR(100) NOT NULL,
--    Username  NVARCHAR(50)  NOT NULL,
--    Email     NVARCHAR(100) NOT NULL,
--    Password  NVARCHAR(50)  NOT NULL
--)

CREATE TABLE StudentDetails (
    RegNo        VARCHAR(20)   PRIMARY KEY,
    FirstName    VARCHAR(50)   NOT NULL,
    LastName     VARCHAR(50)   NOT NULL,
    FatherName   VARCHAR(100)  NOT NULL,
    CNIC         VARCHAR(20)   UNIQUE NOT NULL,
    Department   VARCHAR(50)   NOT NULL,
    Program      VARCHAR(50)   NOT NULL,
    YearOfStudy  INT           NOT NULL,
    Semester     INT           NOT NULL,
    CGPA         DECIMAL(4,2)  CHECK (CGPA >= 0.00 AND CGPA <= 4.00),
    Status       VARCHAR(20)   DEFAULT 'Active',
    Email        VARCHAR(100)  UNIQUE NOT NULL,
    Contact      VARCHAR(20)   NOT NULL,
    EnrollmentDate DATE        NOT NULL
);