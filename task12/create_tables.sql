USE ScheduleDb

CREATE TABLE Subjects(
	SubjectName NCHAR(15) NOT NULL PRIMARY KEY
);

CREATE TABLE Teachers(
	TeacherId INT PRIMARY KEY IDENTITY,
	TeacherName NCHAR(30) NOT NULL UNIQUE	
);

CREATE TABLE SubjectsTeacher(
	TeacherName NCHAR(30) NOT NULL,
	SubjectName NCHAR(15) NOT NULL,
	PRIMARY KEY (TeacherName, SubjectName),
	FOREIGN KEY (SubjectName) REFERENCES Subjects(SubjectName)
		ON DELETE CASCADE,
	FOREIGN KEY (TeacherName) REFERENCES Teachers(TeacherName)
		ON DELETE CASCADE,
);

CREATE TABLE Audiences(
	Number CHAR(3) NOT NULL PRIMARY KEY
);

CREATE TABLE Classes(
	ClassId INT PRIMARY KEY IDENTITY,
	Number NCHAR(3) NOT NULL UNIQUE,
	ClassCount INT NOT NULL	
		CHECK (ClassCount > 0)
		DEFAULT 1
);


CREATE TABLE DaysOfWeek(
	DName CHAR(3) NOT NULL PRIMARY KEY
);

CREATE TABLE Schudle(
	SubjectName NCHAR(15) NOT NULL,
	ClassNumber NCHAR(3) NOT NULL,
	TeacherName NCHAR(30) NOT NULL,
	LessonDay CHAR(3) NOT NULL,
	AudienceNumber CHAR(3) NOT NULL,

	PRIMARY KEY (SubjectName, ClassNumber),

	FOREIGN KEY (AudienceNumber) REFERENCES Audiences(Number)
		ON DELETE CASCADE,
	FOREIGN KEY (SubjectName) REFERENCES Subjects(SubjectName)
		ON DELETE CASCADE,
	FOREIGN KEY (ClassNumber) REFERENCES Classes(Number)
		ON DELETE CASCADE,
	FOREIGN KEY (TeacherName) REFERENCES Teachers(TeacherName)
		ON DELETE CASCADE,
	FOREIGN KEY (LessonDay) REFERENCES DaysOfWeek(DName)
		ON DELETE CASCADE
);