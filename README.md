# TourApp - Tourism Management System

A comprehensive ASP.NET Core MVC web application for managing tourism packages, bookings, and user profiles. This system supports both tourists and travel agencies with role-based access control and a complete booking workflow.

## 🚀 Features

### For Tourists
- **User Registration & Authentication** - Create accounts and manage profiles
- **Browse Tour Packages** - View available tours with detailed information
- **Make Bookings** - Reserve spots on tours with participant management
- **Booking Management** - View and manage current/past bookings
- **Feedback System** - Provide ratings and reviews for completed tours

### For Travel Agencies
- **Agency Profile Management** - Comprehensive agency information management
- **Tour Package Creation** - Create and manage tour offerings
- **Booking Management** - View and manage customer bookings
- **Tour Scheduling** - Set up multiple dates for tour packages
- **Amenity Management** - Define amenities included in tours
- **Reports & Analytics** - Track bookings and performance

### System Features
- **Role-Based Access Control** - Separate interfaces for tourists and agencies
- **Payment Status Tracking** - Monitor payment states (Pending, Paid, Failed, Refunded)
- **Booking Status Management** - Track booking lifecycle (Pending, Confirmed, Completed, Cancelled)
- **Responsive UI** - Mobile-friendly design
- **Entity Framework Integration** - Robust data persistence

## 🛠️ Technology Stack

- **Framework**: ASP.NET Core 9.0 MVC
- **Authentication**: ASP.NET Core Identity with Role Management
- **Database**: SQL Server with Entity Framework Core 9.0.8
- **ORM**: Entity Framework Core with Code-First Migrations
- **UI Framework**: Bootstrap (via ASP.NET Core scaffolding)
- **Development Tools**: Visual Studio 2022

## 📋 Prerequisites

- .NET 9.0 SDK
- SQL Server or SQL Server Express
- Visual Studio 2022 or VS Code
- Git

## 🚦 Getting Started

### 1. Clone the Repository
```bash
git clone https://github.com/yourusername/TourApp.git
cd TourApp
```

### 2. Database Setup
The application is configured to use SQL Server Express with the following connection string:
```
Server=.\\SQLEXPRESS;Database=TourismDb;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=true
```

### 3. Database Migration
```bash
dotnet ef database update
```

### 4. Run the Application
```bash
dotnet run
```

The application will be available at `https://localhost:5001` or `http://localhost:5000`.

## 📁 Project Structure

```
TourApp/
├── TourismApp/                 # Main application project
│   ├── Controllers/           # MVC Controllers
│   │   ├── BookingsController.cs
│   │   ├── FeedbacksController.cs
│   │   ├── HomeController.cs
│   │   ├── ProfileController.cs
│   │   ├── ReportsController.cs
│   │   └── ToursController.cs
│   ├── Data/                  # Database context and seeding
│   │   ├── ApplicationDbContext.cs
│   │   └── SeedData.cs
│   ├── Models/                # Data models
│   │   ├── ViewModels/        # View-specific models
│   │   ├── AgencyProfile.cs
│   │   ├── ApplicationUser.cs
│   │   ├── Booking.cs
│   │   ├── Enums.cs
│   │   ├── Feedback.cs
│   │   ├── TourDate.cs
│   │   ├── TouristProfile.cs
│   │   ├── TourPackage.cs
│   │   └── TourPackageAmenity.cs
│   ├── Views/                 # Razor views
│   ├── wwwroot/              # Static files
│   ├── Migrations/           # EF Core migrations
│   ├── Properties/           # Application properties
│   ├── Areas/               # Identity scaffolding area
│   ├── Program.cs           # Application entry point
│   └── appsettings.json     # Configuration
├── enum.cs                  # Global enums
└── TourApp.sln             # Solution file
```

## 🗄️ Database Schema

### Core Entities

**ApplicationUser** (Identity)
- Extends IdentityUser with custom fields
- Links to TouristProfile or AgencyProfile

**TouristProfile**
- Personal information for tourists
- One-to-one relationship with ApplicationUser

**AgencyProfile**
- Business information for travel agencies
- One-to-one relationship with ApplicationUser

**TourPackage**
- Tour information (title, description, price, duration)
- Belongs to an AgencyProfile
- Has multiple TourDates and Amenities

**TourDate**
- Specific dates when tours are available
- Links to TourPackage
- Has multiple Bookings

**Booking**
- Customer reservations
- Links User to TourDate
- Tracks status and payment information

**Feedback**
- Customer reviews and ratings
- One-to-one relationship with Booking

**Amenity**
- Services/features included in tours
- Many-to-many relationship with TourPackages

### Enums
- **BookingStatus**: Pending, Confirmed, Completed, Cancelled
- **PaymentStatus**: Pending, Paid, Failed, Refunded

## 🔐 Authentication & Authorization

The application uses ASP.NET Core Identity with the following setup:
- **Password Requirements**: Minimum 6 characters (relaxed for development)
- **Email Confirmation**: Disabled for development
- **Role-Based Access**: Tourist and Agency roles
- **Seed Data**: Demo users and roles are created automatically

### Default Development Credentials
The system automatically seeds demo data including sample users (check `SeedData.cs` for details).

## 🏃‍♂️ Development Workflow

### Adding New Features
1. Create/modify models in `Models/` directory
2. Add/update database context in `Data/ApplicationDbContext.cs`
3. Create migration: `dotnet ef migrations add MigrationName`
4. Update database: `dotnet ef database update`
5. Implement controllers and views
6. Test functionality

### Code Conventions
- Follow C# naming conventions
- Use Entity Framework Code-First approach
- Implement proper error handling
- Follow MVC architectural patterns
- Use ViewModels for complex view data

## 🧪 Testing

Currently, the project includes basic MVC structure. To add testing:

```bash
# Add test project
dotnet new mstest -n TourismApp.Tests
dotnet add TourismApp.Tests reference TourismApp/TourismApp.csproj

# Run tests
dotnet test
```

## 📝 Configuration

### Connection Strings
Update `appsettings.json` to modify database connection:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Your-Connection-String-Here"
  }
}
```

### Identity Configuration
Password and user requirements are configured in `Program.cs`:
```csharp
options.Password.RequiredLength = 6;
options.SignIn.RequireConfirmedAccount = false;
```

## 🚀 Deployment

### Prerequisites for Production
1. Update connection strings for production database
2. Configure proper authentication settings
3. Set up HTTPS certificates
4. Configure logging and monitoring
5. Update `appsettings.Production.json`

### Deployment Steps
```bash
# Publish the application
dotnet publish -c Release -o ./publish

# Deploy to your hosting platform
# (Azure, IIS, Linux, etc.)
```

## 🤝 Contributing

1. Fork the project
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License - see the LICENSE file for details.

## 🆘 Support

For support and questions:
1. Check the documentation
2. Search existing issues
3. Create a new issue with detailed information

## 🔄 Version History

- **v1.0.0** - Initial release with core tourism management features
- Features include user management, tour packages, bookings, and feedback system

---

**Built with ❤️ using ASP.NET Core MVC**
