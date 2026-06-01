--CREATE TABLE Student
--(
--    RegNo VARCHAR(20) PRIMARY KEY,
--    FirstName VARCHAR(50),
--    LastName VARCHAR(50),
--    EnrollmentDate DATE
--);

--CREATE TABLE Teacher
--(
--    TeacherID VARCHAR(20) PRIMARY KEY,
--    Name VARCHAR(50),
--    Subject VARCHAR(50),
--    Qualification VARCHAR(50)
--);

--CREATE TABLE Course
--(
--    CourseCode VARCHAR(20) PRIMARY KEY,
--    CourseName VARCHAR(50),
--    CreditHours INT
--);

--CREATE TABLE Department
--(
--    DepartmentID VARCHAR(20) PRIMARY KEY,
--    DepartmentName VARCHAR(50),
--    Location VARCHAR(50)
--);

INSERT INTO Student
VALUES
('FA23-BSE-002', 'Haroon', 'Ijaz', '2023-04-01'),
('FA23-BSE-003', 'Husnain', 'Ali', '2023-04-01');

INSERT INTO Teacher
VALUES
('T001-CUI-ATK', 'Sir Umer Zia', 'OOP', 'MSCS'),
('T002-CUI-ATK', 'Sir Farman', 'PPIT', 'PhD');

INSERT INTO Course
VALUES
('CSC241', 'OOP', 4),
('CSC210', 'PPIT', 2);

INSERT INTO Department
VALUES
('D001-CUI-ATK', 'Computer Science', 'Block A'),
('D002-CUI-ATK', 'Software Engineering', 'Block B');