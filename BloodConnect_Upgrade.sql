


USE BloodConnectDB;

GO



-- Donors: Age, LastDonationDate

IF COL_LENGTH('dbo.Donors', 'Age') IS NULL

    ALTER TABLE dbo.Donors ADD Age INT NULL;

GO



IF COL_LENGTH('dbo.Donors', 'LastDonationDate') IS NULL

    ALTER TABLE dbo.Donors ADD LastDonationDate DATETIME NULL;

GO



-- BloodStock: HospitalName (ALTER and UPDATE must be separate batches)

IF COL_LENGTH('dbo.BloodStock', 'HospitalName') IS NULL

    ALTER TABLE dbo.BloodStock ADD HospitalName NVARCHAR(200) NULL;

GO



IF COL_LENGTH('dbo.BloodStock', 'HospitalName') IS NOT NULL

    UPDATE dbo.BloodStock SET HospitalName = N'Local Hospital' WHERE HospitalName IS NULL;

GO



-- Receivers table

IF OBJECT_ID('dbo.Receivers', 'U') IS NULL

BEGIN

    CREATE TABLE dbo.Receivers

    (

        ID               INT IDENTITY(1,1) NOT NULL PRIMARY KEY,

        UserID           INT NOT NULL,

        BloodGroupNeeded NVARCHAR(5) NOT NULL,

        Phone            NVARCHAR(20) NULL,

        Address          NVARCHAR(250) NULL,

        FOREIGN KEY (UserID) REFERENCES dbo.Users(ID)

    );

END

GO



-- Donation appointments

IF OBJECT_ID('dbo.DonationAppointments', 'U') IS NULL

BEGIN

    CREATE TABLE dbo.DonationAppointments

    (

        ID              INT IDENTITY(1,1) NOT NULL PRIMARY KEY,

        DonorID         INT NOT NULL,

        AppointmentDate DATETIME NOT NULL,

        Status          NVARCHAR(20) NOT NULL DEFAULT 'Pending',

        FOREIGN KEY (DonorID) REFERENCES dbo.Donors(ID)

    );

END

GO



-- User roles: Donor (ID 2)

IF EXISTS (SELECT 1 FROM dbo.UserRoles WHERE ID = 2)

    UPDATE dbo.UserRoles SET RoleName = N'Donor' WHERE ID = 2 AND RoleName <> N'Donor';

ELSE

BEGIN

    SET IDENTITY_INSERT dbo.UserRoles ON;

    INSERT INTO dbo.UserRoles (ID, RoleName) VALUES (2, N'Donor');

    SET IDENTITY_INSERT dbo.UserRoles OFF;

END

GO



-- User roles: Receiver (ID 3)

IF NOT EXISTS (SELECT 1 FROM dbo.UserRoles WHERE ID = 3)

BEGIN

    SET IDENTITY_INSERT dbo.UserRoles ON;

    INSERT INTO dbo.UserRoles (ID, RoleName) VALUES (3, N'Receiver');

    SET IDENTITY_INSERT dbo.UserRoles OFF;

END

GO



PRINT 'SUCCESS: BloodConnectDB upgraded (no errors expected).';

GO

