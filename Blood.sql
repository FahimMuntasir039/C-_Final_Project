/* ============================================================

   BLOOD CONNECT - Database setup

   In SSMS: Ctrl+A  then  F5  (run ALL lines)

   ============================================================ */



USE master;

GO



IF DB_ID(N'BloodConnectDB') IS NOT NULL

BEGIN

    ALTER DATABASE BloodConnectDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;

    DROP DATABASE BloodConnectDB;

END

GO



CREATE DATABASE BloodConnectDB;

GO



USE BloodConnectDB;

GO



CREATE TABLE dbo.UserRoles

(

    ID       INT IDENTITY(1,1) NOT NULL PRIMARY KEY,

    RoleName NVARCHAR(50) NOT NULL

);

GO



CREATE TABLE dbo.Users

(

    ID         INT IDENTITY(1,1) NOT NULL PRIMARY KEY,

    Username   NVARCHAR(50) NOT NULL,

    FullName   NVARCHAR(250) NOT NULL,

    Email      NVARCHAR(250) NULL,

    Password   NVARCHAR(255) NULL,

    UserRoleID INT NOT NULL,

    UpdatedAt  DATETIME NULL,

    FOREIGN KEY (UserRoleID) REFERENCES dbo.UserRoles(ID)

);

GO



CREATE TABLE dbo.Donors

(

    ID               INT IDENTITY(1,1) NOT NULL PRIMARY KEY,

    UserID           INT NOT NULL,

    BloodGroup       NVARCHAR(5) NOT NULL,

    Age              INT NULL,

    Phone            NVARCHAR(20) NULL,

    Address          NVARCHAR(250) NULL,

    LastDonationDate DATETIME NULL,

    FOREIGN KEY (UserID) REFERENCES dbo.Users(ID)

);

GO



CREATE TABLE dbo.Receivers

(

    ID               INT IDENTITY(1,1) NOT NULL PRIMARY KEY,

    UserID           INT NOT NULL,

    BloodGroupNeeded NVARCHAR(5) NOT NULL,

    Phone            NVARCHAR(20) NULL,

    Address          NVARCHAR(250) NULL,

    FOREIGN KEY (UserID) REFERENCES dbo.Users(ID)

);

GO



CREATE TABLE dbo.BloodStock

(

    ID             INT IDENTITY(1,1) NOT NULL PRIMARY KEY,

    BloodGroup     NVARCHAR(5) NOT NULL,

    UnitsAvailable INT NOT NULL,

    HospitalName   NVARCHAR(200) NULL

);

GO



CREATE TABLE dbo.BloodRequests

(

    ID            INT IDENTITY(1,1) NOT NULL PRIMARY KEY,

    UserID        INT NOT NULL,

    BloodGroup    NVARCHAR(5) NOT NULL,

    UnitsRequired INT NOT NULL,

    HospitalName  NVARCHAR(200) NULL,

    ContactPhone  NVARCHAR(20) NULL,

    Status        NVARCHAR(20) NOT NULL DEFAULT 'Pending',

    RequestDate   DATETIME NOT NULL DEFAULT GETDATE(),

    FOREIGN KEY (UserID) REFERENCES dbo.Users(ID)

);

GO



CREATE TABLE dbo.DonationAppointments

(

    ID              INT IDENTITY(1,1) NOT NULL PRIMARY KEY,

    DonorID         INT NOT NULL,

    AppointmentDate DATETIME NOT NULL,

    Status          NVARCHAR(20) NOT NULL DEFAULT 'Pending',

    BloodRequestID  INT NULL,

    UnitsDonated    INT NULL,

    FOREIGN KEY (DonorID) REFERENCES dbo.Donors(ID),

    FOREIGN KEY (BloodRequestID) REFERENCES dbo.BloodRequests(ID)

);

GO



CREATE TABLE dbo.Donations

(

    ID             INT IDENTITY(1,1) NOT NULL PRIMARY KEY,

    DonorID        INT NOT NULL,

    BloodGroup     NVARCHAR(5) NOT NULL,

    UnitsDonated   INT NOT NULL,

    DonationDate   DATETIME NOT NULL DEFAULT GETDATE(),

    Status         NVARCHAR(20) NOT NULL DEFAULT 'Completed',

    BloodRequestID INT NULL,

    AppointmentID  INT NULL,

    FOREIGN KEY (DonorID) REFERENCES dbo.Donors(ID),

    FOREIGN KEY (BloodRequestID) REFERENCES dbo.BloodRequests(ID),

    FOREIGN KEY (AppointmentID) REFERENCES dbo.DonationAppointments(ID)

);

GO



SET IDENTITY_INSERT dbo.UserRoles ON;

INSERT INTO dbo.UserRoles (ID, RoleName) VALUES (1, N'Admin');

INSERT INTO dbo.UserRoles (ID, RoleName) VALUES (2, N'Donor');

INSERT INTO dbo.UserRoles (ID, RoleName) VALUES (3, N'Receiver');

SET IDENTITY_INSERT dbo.UserRoles OFF;

GO



SET IDENTITY_INSERT dbo.Users ON;

INSERT INTO dbo.Users (ID, Username, FullName, Email, Password, UserRoleID, UpdatedAt)

VALUES (1, N'admin', N'Admin User', N'admin@bloodconnect.com', N'12345', 1, GETDATE());



INSERT INTO dbo.Users (ID, Username, FullName, Email, Password, UserRoleID, UpdatedAt)

VALUES (2, N'donor1', N'Karim Donor', N'donor1@bloodconnect.com', N'12345', 2, GETDATE());



INSERT INTO dbo.Users (ID, Username, FullName, Email, Password, UserRoleID, UpdatedAt)

VALUES (3, N'receiver1', N'Sara Receiver', N'receiver1@bloodconnect.com', N'12345', 3, GETDATE());

SET IDENTITY_INSERT dbo.Users OFF;

GO



INSERT INTO dbo.Donors (UserID, BloodGroup, Age, Phone, Address, LastDonationDate)

VALUES (2, N'O+', 28, N'01700000001', N'Dhaka, Bangladesh', DATEADD(MONTH, -4, GETDATE()));

GO



INSERT INTO dbo.Receivers (UserID, BloodGroupNeeded, Phone, Address)

VALUES (3, N'B+', N'01800000002', N'Chittagong, Bangladesh');

GO



INSERT INTO dbo.BloodStock (BloodGroup, UnitsAvailable, HospitalName) VALUES (N'A+', 10, N'Dhaka Medical College');

INSERT INTO dbo.BloodStock (BloodGroup, UnitsAvailable, HospitalName) VALUES (N'A-', 5, N'Square Hospital Dhaka');

INSERT INTO dbo.BloodStock (BloodGroup, UnitsAvailable, HospitalName) VALUES (N'B+', 8, N'Chittagong Medical College');

INSERT INTO dbo.BloodStock (BloodGroup, UnitsAvailable, HospitalName) VALUES (N'B-', 4, N'United Hospital Dhaka');

INSERT INTO dbo.BloodStock (BloodGroup, UnitsAvailable, HospitalName) VALUES (N'AB+', 6, N'Dhaka Medical College');

INSERT INTO dbo.BloodStock (BloodGroup, UnitsAvailable, HospitalName) VALUES (N'AB-', 3, N'Square Hospital Dhaka');

INSERT INTO dbo.BloodStock (BloodGroup, UnitsAvailable, HospitalName) VALUES (N'O+', 15, N'Chittagong Medical College');

INSERT INTO dbo.BloodStock (BloodGroup, UnitsAvailable, HospitalName) VALUES (N'O-', 7, N'United Hospital Dhaka');

GO



INSERT INTO dbo.BloodRequests (UserID, BloodGroup, UnitsRequired, HospitalName, ContactPhone, Status, RequestDate)

VALUES (3, N'B+', 2, N'Chittagong Medical College', N'01800000002', N'Pending', GETDATE());

GO



PRINT 'SUCCESS: BloodConnectDB is ready (Admin, Donor, Receiver roles).';

GO

