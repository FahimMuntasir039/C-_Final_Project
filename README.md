# Blood Connect

A Windows Forms blood donation management system (C# .NET 10 + SQL Server).

## Setup

1. Install the [.NET 10 SDK](https://dotnet.microsoft.com/download) and Visual Studio 2026 (or 2022 17.14+) with **.NET desktop development**.
2. Open `BloodConnect.sln` in Visual Studio.
3. Database setup in SSMS (Ctrl+A, then F5):
   - **New install:** run `Blood.sql` (creates **BloodConnectDB** from scratch).
   - **Already have BloodConnectDB:** run `BloodConnect_Upgrade.sql` then `BloodConnect_Workflow.sql` (adds columns for donor–receiver assignment).
4. SQL Server **SQLEXPRESS** must be running. Default connection uses a **named pipe** (works without SQL Browser). If login fails with “server not found”, start the **SQL Server Browser** service or change `Server=` in `DataAccess.cs` to `localhost\SQLEXPRESS`.
5. Build and run (F5), or from terminal: `dotnet build` then `dotnet run --project BloodConnect`.

## Default Login

| Role     | Username   | Password |
|----------|------------|----------|
| Admin    | admin      | 12345    |
| Donor    | donor1     | 12345    |
| Receiver | receiver1  | 12345    |

## User Types

### Blood Donor (red portal)
- Register/login as **Blood Donor**
- Update profile (blood group, age, address, phone)
- **Search / Update / Delete** donation records
- **Search / Update / Delete** donation appointments
- Record new donations

### Blood Receiver (blue portal)
- Register/login as **Blood Receiver**
- Update profile (blood group needed, address, phone)
- **Search** blood by group and hospital location
- **Search / Update / Delete** own blood requests (pending only for delete)
- Submit new blood requests
- Track request status

### Admin
- Manage donors, blood stock, and blood requests
- **Appointments workflow:** Approve donor appointment → Assign to matching receiver request (same blood group) → Mark complete (creates donation record + fulfills receiver request)
- Approve/reject receiver blood requests (fulfilled only via appointment completion)

## Registration

On the register screen, choose **Blood Donor** or **Blood Receiver**. Each account is routed to its own dashboard after login.
