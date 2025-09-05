# TourismApp

An ASP.NET Core MVC application for managing tour packages, bookings, and user profiles.

## Requirements

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download)
- SQL Server instance (default connection string targets `.\\SQLEXPRESS`)
- Optional: [dotnet-ef](https://learn.microsoft.com/ef/core/cli/dotnet) tool for applying migrations

### NuGet Packages
The project uses the following NuGet packages:

- Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore 9.0.8
- Microsoft.AspNetCore.Identity.EntityFrameworkCore 9.0.8
- Microsoft.AspNetCore.Identity.UI 9.0.8
- Microsoft.EntityFrameworkCore.SqlServer 9.0.8
- Microsoft.EntityFrameworkCore.Tools 9.0.8

## Setup

1. Update the connection string in `appsettings.json` to point to your SQL Server.
2. Restore and build the project:

   ```bash
   dotnet build
   ```
3. Apply migrations (requires `dotnet-ef`):

   ```bash
   dotnet ef database update
   ```
4. Run the application:

   ```bash
   dotnet run
   ```

The site will start on `https://localhost:5001` (or a port shown in the console).

## Project Structure

- `Controllers/` – MVC controllers
- `Data/` – Entity Framework Core context and seed data
- `Models/` – domain models
- `Views/` – Razor views
- `Migrations/` – EF Core migrations

## Notes

Seed data for roles and demo users is created automatically at startup.
