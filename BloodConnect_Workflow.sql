/* ============================================================
   BLOOD CONNECT - Appointment / assignment workflow upgrade
   Run on existing BloodConnectDB (Ctrl+A, F5). Safe to re-run.
   ============================================================ */

USE BloodConnectDB;
GO

IF COL_LENGTH('dbo.DonationAppointments', 'BloodRequestID') IS NULL
    ALTER TABLE dbo.DonationAppointments ADD BloodRequestID INT NULL;
GO

IF COL_LENGTH('dbo.DonationAppointments', 'UnitsDonated') IS NULL
    ALTER TABLE dbo.DonationAppointments ADD UnitsDonated INT NULL;
GO

IF NOT EXISTS (
    SELECT 1 FROM sys.foreign_keys
    WHERE name = 'FK_DonationAppointments_BloodRequests')
BEGIN
    ALTER TABLE dbo.DonationAppointments
    ADD CONSTRAINT FK_DonationAppointments_BloodRequests
        FOREIGN KEY (BloodRequestID) REFERENCES dbo.BloodRequests(ID);
END
GO

IF COL_LENGTH('dbo.Donations', 'BloodRequestID') IS NULL
    ALTER TABLE dbo.Donations ADD BloodRequestID INT NULL;
GO

IF COL_LENGTH('dbo.Donations', 'AppointmentID') IS NULL
    ALTER TABLE dbo.Donations ADD AppointmentID INT NULL;
GO

PRINT 'SUCCESS: Workflow columns ready (assign donor to receiver, admin completes).';
GO
