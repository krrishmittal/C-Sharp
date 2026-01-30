# EmployeeCrud - ASP.NET Core Web API with AutoMapper & Entity Framework Core

## Project Overview

This is a RESTful Web API built with **ASP.NET Core (.NET 10)** and **Entity Framework Core** for managing employee data. The API demonstrates advanced development practices including **AutoMapper** for object mapping, async/await operations, DTOs pattern, and comprehensive CRUD operations with Swagger documentation.

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
   | Read All | GET | `/api/employees` | Retrieve all employees | 200 OK |
   | Read One | GET | `/api/employees/{id}` | Retrieve employee by ID | 200 OK / 404 Not Found |
   | Create | POST | `/api/employees` | Add new employee | 201 Created |
   | Update | PUT | `/api/employees/{id}` | Update existing employee | 200 OK / 404 Not Found |
   | Delete | DELETE | `/api/employees/{id}` | Delete employee | 200 OK / 404 Not Found |


---

## Key Features

### 3. **AutoMapper - Object-to-Object Mapping**

**What is AutoMapper?**
- Library that automatically maps properties between objects
- Eliminates repetitive manual mapping code
- Keeps your code clean and maintainable
- Reduces mapping errors

**Why Use AutoMapper?**

**Without AutoMapper (Manual Mapping):**
```csharp
var employeeDto = new EmployeeDto { 
	Id = employee.Id, 
	Name = employee.Name, 
	Email = employee.Email, 
	Phone = employee.Phone, 
	Department = employee.Department,
	Salary = employee.Salary, 
	JoiningDate = employee.JoiningDate 
};
```

**With AutoMapper (Automatic Mapping):**
```csharp
var employeeDto = _mapper.Map<EmployeeDto>(employee);
```

**Benefits:**
- ✅ Less code to write and maintain
- ✅ Reduced human error
- ✅ Centralized mapping configuration
- ✅ Easy to update when models change

---

## Models & DTOs

### 4. **Employee Entity (Employee.cs)**
```csharp
public class Employee { 
	public Guid Id { get; set; } 
	public string Name { get; set; } 
	public string Email { get; set; } 
	public string Phone { get; set; } 
	public string Department { get; set; } 
	public decimal Salary { get; set; } 
	public DateTime JoiningDate { get; set; } 
}
```

**Key Points:**
- Uses `Guid` as primary key for uniqueness
- Represents the database table structure
- Should not be directly exposed to clients

### 5. **DTOs (Data Transfer Objects)**

**a) AddEmployeeRequest.cs - For Creating Employees**

**b) UpdateEmployeeRequest.cs - For Updating Employees**

**c) EmployeeDto.cs - For API Responses**


**Why Use Separate DTOs?**
- **Security**: Hide sensitive database properties
- **Flexibility**: API contract independent of database structure
- **Validation**: Different validation rules for create/update
- **Versioning**: Change API without changing database

---

## AutoMapper Configuration

### 6. **MappingProfile.cs - AutoMapper Profile**


**How It Works:**
1. `CreateMap<Source, Destination>()` - Defines mapping relationship
2. AutoMapper automatically maps properties with matching names
3. No need for manual property assignment

**Mapping Flow:**


---

## Database Context

### 7. **EmployeeDbContext.cs**

**Entity Framework Core Concepts:**
- `DbContext` - Bridge between C# models and database
- `DbSet<Employee>` - Represents the Employees table
- Injected via Dependency Injection

---

## Application Configuration

### 8. **Program.cs - Dependency Injection & Middleware**

**Services Configured:**
- `AddControllers()` - Enables API controllers
- `AddSwaggerGen()` - Generates API documentation
- `AddDbContext()` - Registers database context
- `AddAutoMapper()` - Registers AutoMapper services

---

## API Controller

### 9. **EmployeesController.cs - Complete CRUD Operations**



**Key Concepts:**
- `[ApiController]` - Enables automatic validation and model binding
- `[Route("api/[controller]")]` - Sets base route to `/api/employees`
- **Constructor Injection** - Receives `DbContext` and `IMapper`
- **async/await** - Non-blocking database operations
- **AutoMapper Usage** - `_mapper.Map<T>()` for all conversions

---

## AutoMapper in Action

### 10. **Mapping Examples**

**Single Object Mapping:**

**Collection Mapping:**
**Update Existing Obje
---

## API Documentation

### 11. **Available Endpoints**

| Method | Endpoint | Description | Request Body | Response |
|--------|----------|-------------|--------------|----------|
| GET | `/api/employees` | Get all employees | None | Array of EmployeeDto |
| GET | `/api/employees/{id}` | Get employee by ID | None | EmployeeDto |
| POST | `/api/employees` | Create new employee | AddEmployeeRequest | EmployeeDto (201) |
| PUT | `/api/employees/{id}` | Update existing employee | UpdateEmployeeRequest | EmployeeDto (200) |
| DELETE | `/api/employees/{id}` | Delete employee | None | Success message (200) |

---

## Key Concepts Learned

### 11. **What We've Mastered**

✅ **Complete CRUD Operations**
- Implemented all five HTTP methods (GET, POST, PUT, DELETE)
- Used proper HTTP status codes (200, 201, 404)
- Implemented resource-based routing

✅ **AutoMapper Integration**
- Configured mapping profiles
- Automated object-to-object transformations
- Eliminated repetitive mapping code
- Mapped entities ↔ DTOs seamlessly

✅ **DTOs Pattern**
- Separated API contracts from database entities
- Created request DTOs (AddEmployeeRequest, UpdateEmployeeRequest)
- Created response DTOs (EmployeeDto)
- Improved security and flexibility

✅ **Entity Framework Core**
- Created DbContext for database access
- Used `DbSet<T>` to represent tables
- Implemented async database operations
- Used In-Memory database for development

✅ **Dependency Injection**
- Registered services in `Program.cs`
- Injected `DbContext` and `IMapper` via constructor
- Followed SOLID principles

✅ **RESTful API Best Practices**
- Resource-based routing (`/api/employees`)
- Proper HTTP verbs usage
- Meaningful status codes
- Consistent response format

✅ **Async/Await Pattern**
- All database operations are async
- Improved scalability and performance
- Non-blocking I/O operations

✅ **API Documentation**
- Integrated Swagger/OpenAPI
- Interactive API testing interface
- Auto-generated documentation

---

## AutoMapper vs Manual Mapping Comparison

### 12. **Performance & Benefits**

| Aspect | Manual Mapping | AutoMapper |
|--------|----------------|------------|
| **Code Lines** | 7-10 per mapping | 1 line |
| **Maintainability** | Scattered across codebase | Centralized in Profile |
| **Error Prone** | High (typos, missing fields) | Low (compile-time checks) |
| **Refactoring** | Update multiple places | Update once in Profile |
| **New Property** | Update all mapping locations | Automatic if names match |
| **Learning Curve** | None | Minimal |
| **Performance** | Slightly faster | Negligible overhead |
| **Best For** | Simple projects | Medium-to-large projects |

**Verdict:** AutoMapper is highly recommended for projects with multiple DTOs and complex mapping requirements.

---

---

## Conclusion

This EmployeeCrud project demonstrates professional-level ASP.NET Core Web API development with modern best practices. You've learned:

✅ Complete CRUD operations with all HTTP verbs  
✅ AutoMapper for clean, maintainable object mapping  
✅ DTOs pattern for separating concerns  
✅ Entity Framework Core with async operations  
✅ Dependency injection and service registration  
✅ RESTful API design principles  
✅ Swagger documentation and testing  
✅ Proper HTTP status codes and error handling  

This project builds upon the ContactsAPI foundations and introduces production-ready patterns that scale well for enterprise applications.

---

## Resources

- [ASP.NET Core Documentation](https://learn.microsoft.com/en-us/aspnet/core/)
- [Entity Framework Core Documentation](https://learn.microsoft.com/en-us/ef/core/)
- [AutoMapper Documentation](https://docs.automapper.org/)
- [RESTful API Design](https://learn.microsoft.com/en-us/azure/architecture/best-practices/api-design)
- [C# Async/Await](https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/)
- [Dependency Injection in .NET](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection)

---

**Project Status:** ✅ Complete CRUD Implementation | ✅ AutoMapper Integrated | 📝 In-Memory Database

**Last Updated:** January 30, 2026

---

Made with ❤️ while mastering ASP.NET Core Web API with AutoMapper

---