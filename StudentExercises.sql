CREATE TABLE Cohort (
Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
CohortName TEXT NOT NULL
);

CREATE TABLE Student (
Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
FirstName TEXT NOT NULL,
LastName TEXT NOT NULL,
SlackHandle TEXT NOT NULL,
StudentCohortId INTEGER NOT NULL,
FOREIGN KEY (StudentCohortId) REFERENCES Cohort(Id)
);

CREATE TABLE Instructor (
Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
FirstName TEXT NOT NULL,
LastName TEXT NOT NULL,
SlackHandle TEXT NOT NULL,
InstructorCohortId INTEGER NOT NULL,
FOREIGN KEY (InstructorCohortId) REFERENCES Cohort(Id)
);

CREATE TABLE Exercise (
Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
ExerciseName TEXT NOT NULL,
ExerciseLanguage TEXT NOT NULL
);

INSERT INTO Cohort (CohortName) VALUES ("Cohort 26");
INSERT INTO Cohort (CohortName) VALUES ("Cohort 27");
INSERT INTO Cohort (CohortName) VALUES ("Cohort 28");

INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Aaron" ,"Miller", "Aaron Miller", 1);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Adam" ,"Wieckert", "Adam Wiekert", 1);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Adelaide" ,"Yoder", "Adelaide Yoder", 1);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Austin" ,"Gorman", "Austin Gorman", 1);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Brett" ,"Shearin", "Brett Shearin", 1);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Elliot" ,"Huck", "Elliot Huck", 1);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Emily" ,"Venturino", "Emily Venturino", 1);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Evan" ,"Lusky", "Evan Wallace Lusky", 1);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Jennifer" ,"Lawson", "Jennifer Lawson", 1);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Jewel" ,"Ramirez", "Jewel Ramirez", 1);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Joey" ,"Smith", "Joey Smith", 1);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Jordan" ,"Williams", "Jordan Williams", 1);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Lauren" ,"Richert", "Lauren Richert", 1);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Leah" ,"Gwin", "Leah Gwin", 1);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Michael" ,"Robers", "Michael Roberts", 1);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Natasha" ,"Cox", "Natasha Cox", 1);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Phillip" ,"Patton", "Phillip Patton", 1);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Robert" ,"Leedy", "Robert Leedy", 1);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Seth" ,"Dana", "Seth Dana", 1);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Shuaib" ,"Sajid", "Shuaib Sajid", 1);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("William" ,"Kimball", "William Kimball", 1);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Amanda" ,"Mitchell", "Amanda Mitchell", 1);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Sathvik" ,"Reddy", "Sathvik Reddy", 1);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Aaron" ,"Keen", "Aaron Keen", 2);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Alejandro" ,"Font", "alejandro font", 2);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Daniel" ,"Figueroa", "Daniel Figueroa", 2);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("David" ,"Taylor", "David Taylor", 2);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Dejan" ,"Stjepanovic", "Dejan Stjepanovic", 2);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Gretchen" ,"Ward", "Gretchenmward", 2);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Helen" ,"Chalmers", "Helen Chalmers", 2);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Jeremiah" ,"Pritchard", "Jeremiah Pritchard", 2);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Johnathan" ,"Edwards", "Johnathan Edwards", 2);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Kayla" ,"Reid", "Kayla Reid", 2);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Kelly" ,"Cook", "Kelly Cook", 2);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Klaus" ,"Hardt", "Klaus Hardt", 2);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Madi" ,"Peper", "Madi Peper", 2);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Mark" ,"Hale", "Mark Hale", 2);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Mateus" ,"Hall", "Mateusvanhalen", 2);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Michael" ,"McClenton", "Michael McClenton", 2);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Mike" ,"Parrish", "Mike Parrish", 2);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Nick" ,"Black", "Nick Black", 2);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Priyanka" ,"Garg", "Priyanka Garg", 2);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Ricky" ,"Bruner", "Ricky Bruner", 2);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Streator" ,"Ward", "Streator Ward", 2);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Taylor" ,"Gulley", "Taylor Gulley", 2);

INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Alfonso" ,"Miranda", "Alfonso Miranda", 3);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Andrew" ,"Herring", "Andrew Herring", 3);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Austin" ,"Zoradi", "Austin Zoradi", 3);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Brad" ,"Davis", "Brad Davis", 3);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Bredan" ,"McCray", "Brendan McCray", 3);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Brian" ,"Nilsen", "BryanNilsen", 3);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Daniel" ,"Combs", "Daniel Reed Combs", 3);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Jase" ,"Hackman", "Jase Hackman", 3);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Jessica" ,"Barnett", "Jessica Barnett", 3);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("John" ,"Wood", "John Nathan Wood", 3);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Justina" ,"Vickers", "Justina Vickers", 3);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Kelly" ,"Morin", "Kelly Morin", 3);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Lesley" ,"Boyd", "Lesley Boyd", 3);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Lindsey" ,"Maddox", "Lindsey Maddox", 3);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Nicholas" ,"Wessel", "Nicholas Wessel", 3);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Noah" ,"Woods", "Noahwoods", 3);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Nolan" ,"Little", "Nolan Little", 3);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Ousama" ,"Elayan", "Ousama Elayan", 3);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Rachel" ,"Daniel", "Rachel Daniel", 3);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Richard" ,"Lancaster", "Richard Lancaster", 3);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Robby" ,"Hecht", "Robbyhecht", 3);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Samuel" ,"Webber", "Samuel Webber", 3);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Sean" ,"Davis", "Sean D Davis86", 3);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Sebastian" ,"Civarolo", "Sebastian Civarolo", 3);
INSERT INTO Student (FirstName, LastName, SlackHandle, StudentCohortId)
VALUES("Zac" ,"Jones", "Zac Jones", 3);

INSERT INTO Instructor (FirstName, LastName, SlackHandle, InstructorCohortId)
VALUES("Jisie" ,"David", "Jisie David", 1);
INSERT INTO Instructor (FirstName, LastName, SlackHandle, InstructorCohortId)
VALUES("Brenda" ,"Long", "Brenda Long", 2);
INSERT INTO Instructor (FirstName, LastName, SlackHandle, InstructorCohortId)
VALUES("Steve" ,"Brownlee", "Steve Brownlee", 2);
INSERT INTO Instructor (FirstName, LastName, SlackHandle, InstructorCohortId)
VALUES("Joe" ,"Sheppard", "Joe Shepherd", 3);
INSERT INTO Instructor (FirstName, LastName, SlackHandle, InstructorCohortId)
VALUES("Greg" ,"Korte", "Joe Shepherd", 3);

INSERT INTO Exercise (ExerciseName, ExerciseLanguage)
VALUES ("HTML 101", "HTML");
INSERT INTO Exercise (ExerciseName, ExerciseLanguage)
VALUES ("CSS 101", "CSS");
INSERT INTO Exercise (ExerciseName, ExerciseLanguage)
VALUES ("Functions", "Javascript");
INSERT INTO Exercise (ExerciseName, ExerciseLanguage)
VALUES ("Arrays", "Javascript");
INSERT INTO Exercise (ExerciseName, ExerciseLanguage)
VALUES ("Objects", "Javascript");
INSERT INTO Exercise (ExerciseName, ExerciseLanguage)
VALUES ("Modular Coding", "Javascript");
INSERT INTO Exercise (ExerciseName, ExerciseLanguage)
VALUES ("Nutshell", "Javascript");
INSERT INTO Exercise (ExerciseName, ExerciseLanguage)
VALUES ("React Nutshell", "React");
INSERT INTO Exercise (ExerciseName, ExerciseLanguage)
VALUES ("Importing", "Python");
INSERT INTO Exercise (ExerciseName, ExerciseLanguage)
VALUES ("Types", "Python");
INSERT INTO Exercise (ExerciseName, ExerciseLanguage)
VALUES ("Functions", "Python");
INSERT INTO Exercise (ExerciseName, ExerciseLanguage)
VALUES ("Classes", "Python");
INSERT INTO Exercise (ExerciseName, ExerciseLanguage)
VALUES ("Lists", "C#");
INSERT INTO Exercise (ExerciseName, ExerciseLanguage)
VALUES ("Sets", "C#");
INSERT INTO Exercise (ExerciseName, ExerciseLanguage)
VALUES ("Dictionaries", "C#");