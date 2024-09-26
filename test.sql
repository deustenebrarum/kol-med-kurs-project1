-- Table: ServiceType
CREATE TABLE ServiceType (
    ServiceTypeID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL
);

-- Table: Specialist
CREATE TABLE Specialist (
    SpecialistID INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(255) NOT NULL,
    Position NVARCHAR(255) NOT NULL,
    Experience INT NOT NULL
);

-- Table: Users
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL,
    Login NVARCHAR(255) NOT NULL UNIQUE,
    Email NVARCHAR(255) NOT NULL,
    Password NVARCHAR(255) NOT NULL,
    Role NVARCHAR(50) NOT NULL
);

-- Table: Request
CREATE TABLE Request (
    RequestID INT PRIMARY KEY IDENTITY(1,1),
    Date DATETIME NOT NULL,
    ServiceTypeID INT FOREIGN KEY REFERENCES ServiceType(ServiceTypeID),
    SpecialistID INT FOREIGN KEY REFERENCES Specialist(SpecialistID),
    PatientID INT FOREIGN KEY REFERENCES Users(UserID),
    Number NVARCHAR(50) NOT NULL
);

-- Table: Reviews
CREATE TABLE Reviews (
    ReviewID INT PRIMARY KEY IDENTITY(1,1),
    SpecialistID INT FOREIGN KEY REFERENCES Specialist(SpecialistID),
    Title NVARCHAR(255),
    Content NVARCHAR(MAX),
    Date DATETIME NOT NULL
);
