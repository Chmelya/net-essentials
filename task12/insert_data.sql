USE ScheduleDb

INSERT INTO Audiences
VALUES
('111'),
('222'),
('333')

INSERT INTO Classes(Number, ClassCount)
VALUES
('11A', DEFAULT),
('11B', 18)

INSERT INTO DaysOfWeek
VALUES
('MON'),
('TUE'),
('WED'),
('THU'),
('FRI'),
('SAT'),
('SUN')

INSERT INTO Subjects
VALUES
('Mathematics'),
('English'),
('Biology'),
('Geography')

INSERT INTO Teachers(TeacherName)
VALUES
('Jhon Doe'),
('William Shakespeare'),
('Jhon Shepard')

INSERT INTO SubjectsTeacher
VALUES
('Jhon Doe', 'Mathematics'),
('Jhon Doe', 'English'),
('William Shakespeare', 'English'),
('Jhon Shepard', 'Biology'),
('Jhon Shepard', 'Geography')

INSERT INTO Schudle (SubjectName, ClassNumber, TeacherName, LessonDay, AudienceNumber)
VALUES
('Mathematics', '11A', 'Jhon Doe', 'MON', '111'),
('English', '11B', 'William Shakespeare', 'FRI', '222')