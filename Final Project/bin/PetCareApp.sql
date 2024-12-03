CREATE DATABASE PetCareApp;
Go

USE PetCareApp;
Go

-- Table for Users
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    Username NVARCHAR(50) UNIQUE,
    Password NVARCHAR(50)
);
Go

-- Table for Pets
CREATE TABLE Pets (
    PetID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    Type NVARCHAR(50),
    Breed NVARCHAR(100),
    Weight FLOAT,
    Age INT,
    Height FLOAT,
    UserID INT FOREIGN KEY REFERENCES Users(UserID)
);
Go


-- Table for PetTasks
CREATE TABLE PetTasks (
    TaskID INT PRIMARY KEY IDENTITY(1,1),
    Description NVARCHAR(255),
    IsCompleted BIT,
    ScheduledDate DATETIME,
    PetID INT FOREIGN KEY REFERENCES Pets(PetID)
);
Go

-- Table for Schedules
CREATE TABLE Schedules (
    ScheduleID INT PRIMARY KEY IDENTITY(1,1),
    Date DATETIME,
    Description NVARCHAR(255),
    PetID INT FOREIGN KEY REFERENCES Pets(PetID)
);
Go

-- Insert Users
INSERT INTO Users (Name, Username, Password) VALUES 
('Alice', 'alice', 'password'),
('Bob', 'bob', '1234');
Go

-- Insert Pets
INSERT INTO Pets (Name, Type, Breed, Weight, Age, Height, UserID) VALUES 
('Max', 'Dog', 'Golden Retriever', 30.5, 5, 24, 1),
('Whiskers', 'Cat', 'Siamese', 5.0, 3, 10, 1),
('Tweety', 'Bird', 'Canary', 0.2, 1, 4, 2),
('Buddy', 'Dog', 'Beagle', 12.0, 4, 15, 2);
Go
-- Insert Pet Tasks
INSERT INTO PetTasks (Description, IsCompleted, ScheduledDate, PetID) VALUES 
-- Tasks for Max
('Morning Walk', 0, '2024-12-04 07:00:00', 1),
('Evening Walk', 0, '2024-12-04 18:00:00', 1),
('Feeding', 0, '2024-12-04 08:00:00', 1),
-- Tasks for Whiskers
('Feeding', 0, '2024-12-04 08:30:00', 2),
('Litter Box Cleaning', 0, '2024-12-04 10:00:00', 2),
-- Tasks for Tweety
('Feeding', 0, '2024-12-04 07:00:00', 3),
('Cage Cleaning', 0, '2024-12-04 12:00:00', 3),
-- Tasks for Buddy
('Morning Walk', 0, '2024-12-04 06:30:00', 4),
('Feeding', 0, '2024-12-04 07:30:00', 4);
Go

-- Insert Pet Schedules
INSERT INTO Schedules (Date, Description, PetID) VALUES 
-- Schedules for Max
('2024-12-05 10:00:00', 'Vet Appointment', 1),
('2024-12-10 09:00:00', 'Grooming Appointment', 1),
-- Schedules for Whiskers
('2024-12-06 14:00:00', 'Vet Appointment', 2),
('2024-12-08 10:00:00', 'House Cleaning', 2),
-- Schedules for Tweety
('2024-12-07 11:00:00', 'Cage Cleaning', 3),
('2024-12-12 08:00:00', 'Vet Appointment', 3),
-- Schedules for Buddy
('2024-12-06 15:00:00', 'Vet Appointment', 4),
('2024-12-09 10:00:00', 'Grooming Appointment', 4);
Go
