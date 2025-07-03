# 🏨 Hotel Management API

This is a layered ASP.NET Core Web API project that manages hotel services, staff, rooms, and more.  
The project follows **Clean Architecture** and uses DTOs, AutoMapper, and Identity for user management.

---

## 🧱 Project Architecture

This project is structured using a layered architecture:

![Architecture](./architecture.png)

**Layers:**
- `Entity Layer`: Defines core entities (Room, Staff, Service, etc.)
- `Data Access Layer`: Contains EF Core repositories for data access
- `Business Layer`: Includes service interfaces and logic
- `Dto Layer`: Contains DTOs for API communication
- `Api Layer`: Hosts the Web API controllers
- `UI Layer`: (Optional) Could be used for frontend if applicable

---

## 🚀 Features

- ✅ Staff, Room, Service management
- ✅ CRUD operations using DTOs
- ✅ AutoMapper integration
- ✅ ASP.NET Core Identity-based registration
- ✅ Swagger documentation
- ✅ CORS configuration
- ✅ Clean and modular architecture

---

## 🧪 Technologies Used

- ASP.NET Core 8.0
- Entity Framework Core
- AutoMapper
- Microsoft Identity
- Swagger / Swashbuckle
- SQL Server

---

## 📁 Project Setup

```bash
+ git clone https://github.com/al1yavuz/RapidConsumeAPI.git
cd RapidConsumeAPI
dotnet restore
dotnet ef database update
dotnet run

