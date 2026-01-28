# ContactsAPI - ASP.NET Core Web API with Entity Framework Core

## Project Overview

This is a RESTful Web API built with **ASP.NET Core (.NET 10)** and **Entity Framework Core** for managing contacts. The API demonstrates modern API development practices including in-memory database usage, async/await operations, and Swagger documentation.

---

## Topics Covered

### 1. **What is a RESTful API?**
   - **REST** (Representational State Transfer) - Architectural style for building web services
   - Uses HTTP methods to perform CRUD operations
   - Stateless communication between client and server
   - Returns data in JSON format
   - Follows standard HTTP status codes

### 2. **HTTP Methods Used**
   | Operation | HTTP Method | Endpoint | Description | Status Code |
   |-----------|-------------|----------|-------------|-------------|
   | Read All | GET | `/api/contacts` | Retrieve all contacts | 200 OK |
   | Create | POST | `/api/contacts` | Add new contact | 200 OK |


### 4. **Contact Model (Contact.cs)**

**Key Points:**
- Uses `Guid` as primary key for uniqueness
- Contains essential contact information
- Acts as both database entity and response model

### 5. **AddContactsRequest DTO (AddContactsRequest.cs)**
			
**Why Use a DTO?**
- Separates API request structure from database entity
- Client doesn't need to provide `Id` (auto-generated)
- Provides better security and validation control

### 6. **Database Context (ContactsDbContext.cs)**

**Entity Framework Core Concepts:**
- `DbContext` - Bridge between C# models and database
- `DbSet<Contact>` - Represents the Contacts table
- Constructor accepts configuration options

---

## Application Configuration

### 7. **Program.cs - Dependency Injection & Middleware**

**Services Configured:**
- `AddControllers()` - Enables API controllers
- `AddSwaggerGen()` - Generates API documentation
- `AddDbContext()` - Registers database context with DI container

---

## API Controller

### 8. **ContactsController.cs - API Endpoints**

**Key Concepts:**
- `[ApiController]` - Enables API-specific behaviors (automatic validation, binding)
- `[Route("api/[controller]")]` - Sets base route to `/api/contacts`
- `async/await` - Non-blocking database operations
- Constructor injection - DbContext provided by DI container

---

## Database Approach

### 9. **In-Memory Database**

**What is It?**
- Database stored entirely in RAM (computer memory)
- Provided by `Microsoft.EntityFrameworkCore.InMemory` package
- No physical database file created

**Characteristics:**

| Feature | In-Memory Database |
|---------|-------------------|
| **Storage Location** | RAM (volatile memory) |
| **Persistence** | ❌ Data lost on app shutdown |
| **Speed** | ⚡ Extremely fast |
| **Setup Required** | ✅ None - zero configuration |
| **Best For** | Prototyping, testing, demos |
| **Production Ready** | ❌ Not suitable |

**Configuration:**


**Lifecycle:**
1. App starts → Empty in-memory database created
2. API calls → Data stored in RAM
3. App stops → All data deleted forever

---

## API Documentation

### 17. **Available Endpoints**

| Method | Endpoint | Description | Request Body | Response |
|--------|----------|-------------|--------------|----------|
| GET | `/api/contacts` | Get all contacts | None | Array of contacts |
| POST | `/api/contacts` | Create new contact | AddContactsRequest | Created contact |

### 18. **Response Examples**

**GET /api/contacts - Success (200 OK)**
**POST /api/contacts - Success (200 OK)**
---

## Key Points to Remember

### 19. **What We've Learned**

✅ **RESTful API Design**
- Created API endpoints using HTTP methods
- Used appropriate routing with `[Route]` attributes
- Returned proper HTTP status codes

✅ **Entity Framework Core**
- Created DbContext for database access
- Used `DbSet<T>` to represent tables
- Implemented async database operations
- Used In-Memory database for rapid development

✅ **Dependency Injection**
- Registered services in `Program.cs`
- Injected DbContext via constructor
- Understood service lifetime and scoping

✅ **DTOs (Data Transfer Objects)**
- Separated API contracts from database entities
- Used `AddContactsRequest` for input validation
- Kept database model separate from API model

✅ **Async/Await Pattern**
- Used async methods for all database operations
- Improved application scalability
- Followed modern C# best practices

✅ **API Documentation**
- Integrated Swagger/OpenAPI
- Auto-generated interactive API documentation
- Easy testing without external tools

---


## Conclusion

This ContactsAPI project demonstrates the fundamentals of building a RESTful Web API with ASP.NET Core and Entity Framework Core. You've learned:

- How to structure a Web API project
- Creating models and DTOs
- Setting up Entity Framework Core with In-Memory database
- Implementing API endpoints with async/await
- Using dependency injection
- Generating API documentation with Swagger

The project uses an **in-memory database** for rapid development and learning. When you're ready for production or want persistent data, follow the **Code First approach** outlined in Section 11-13 to switch to a real database.

---

## Resources

- [ASP.NET Core Documentation](https://learn.microsoft.com/en-us/aspnet/core/)
- [Entity Framework Core Documentation](https://learn.microsoft.com/en-us/ef/core/)
- [RESTful API Design](https://learn.microsoft.com/en-us/azure/architecture/best-practices/api-design)
- [C# Async/Await](https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/)

---

**Project Status:** ✅ Basic CRUD (CR implemented) | 🚧 Update & Delete pending | 📝 In-Memory Database

**Last Updated:** January 28, 2026

---

Made with ❤️ while learning ASP.NET Core Web API Development