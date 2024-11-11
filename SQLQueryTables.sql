-- Таблица механиков
CREATE TABLE Mechanics (
    MechanicID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Position NVARCHAR(50),
    Status NVARCHAR(20),
    Email NVARCHAR(100),
    Phone NVARCHAR(20)
);

-- Таблица задач по обслуживанию
CREATE TABLE ServiceTasks (
    TaskID INT PRIMARY KEY IDENTITY(1,1),
    TaskDescription NVARCHAR(255),
    Status NVARCHAR(50),
    CollectionTime DATETIME,
    AdditionalRepairs NVARCHAR(255),
    MechanicID INT FOREIGN KEY REFERENCES Mechanics(MechanicID)
);

-- Таблица запасов
CREATE TABLE Inventory (
    PartID INT PRIMARY KEY IDENTITY(1,1),
    PartName NVARCHAR(100),
    Quantity INT,
    Price DECIMAL(10, 2)
);

-- Таблица клиентов
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Phone NVARCHAR(20),
    Email NVARCHAR(100),
    Address NVARCHAR(255)
);

-- Таблица запросов на детали
CREATE TABLE PartsRequests (
    RequestID INT PRIMARY KEY IDENTITY(1,1),
    PartID INT FOREIGN KEY REFERENCES Inventory(PartID),
    Quantity INT,
    MechanicID INT FOREIGN KEY REFERENCES Mechanics(MechanicID),
    RequestDate DATETIME
);
