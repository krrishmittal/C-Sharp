# Day 14 - Implementing CRUD Operations in ASP.NET Core Web API

## Topics Covered

### 1. **What is CRUD?**
   - **C**reate - Add new records (POST)
   - **R**ead - Retrieve records (GET)
   - **U**pdate - Modify existing records (PUT/PATCH)
   - **D**elete - Remove records (DELETE)
   - CRUD operations are the foundation of any data-driven application

### 2. **HTTP Methods for CRUD Operations**
   | Operation | HTTP Method | Description | Status Code |
   |-----------|-------------|-------------|-------------|
   | Create | POST | Add new resource | 201 Created |
   | Read All | GET | Retrieve all resources | 200 OK |
   | Read One | GET | Retrieve single resource | 200 OK / 404 Not Found |
   | Update | PUT | Replace entire resource | 200 OK / 204 No Content |
   | Partial Update | PATCH | Update specific fields | 200 OK |
   | Delete | DELETE | Remove resource | 204 No Content |

### 3. **Project Structure**
   ```
   WebApiCRUD/
   ├── Controllers/
   │   └── StudentAPIController.cs  # CRUD API Controller
   ├── Models/
   │   ├── StudentInfo.cs           # Entity Model
   │   └── StudentsContext.cs       # DbContext
   ├── Program.cs                   # Main entry point
   ├── WebApiCRUD.csproj            # Project file
   ├── appsettings.json             # Connection string config
   └── Properties/
       └── launchSettings.json      # Launch profiles
   ```

### 4. **Model Class (StudentInfo.cs)**
   ```csharp
   using System;
   using System.Collections.Generic;

   namespace WebApiCRUD.Models;

   public partial class StudentInfo
   {
       public int StudentId { get; set; }
       public string? Fname { get; set; }
   }
   ```

### 5. **Complete CRUD Controller (StudentAPIController.cs)**
   ```csharp
   using Microsoft.AspNetCore.Mvc;
   using Microsoft.AspNetCore.Http;
   using WebApiCRUD.Models;

   namespace WebApiCRUD.Controllers;

   [ApiController]
   [Route("[controller]")]
   public class StudentAPIController : ControllerBase
   {
       private readonly StudentsContext db;

       public StudentAPIController(StudentsContext db)
       {
           this.db = db;
       }

       // CRUD operations here...
   }
   ```
### 6. **PUT vs PATCH**
   | PUT | PATCH |
   |-----|-------|
   | Replaces entire resource | Updates partial resource |
   | All fields required | Only changed fields required |
   | Idempotent | Idempotent |
   | `db.Entry(entity).State = Modified` | `db.Entry(existing).CurrentValues.SetValues(new)` |

### 7. **Common Action Results**
   | Method | Status Code | Usage |
   |--------|-------------|-------|
   | `Ok()` | 200 | Successful GET/PUT/PATCH |
   | `Created()` | 201 | Successful POST |
   | `CreatedAtAction()` | 201 | POST with location header |
   | `NoContent()` | 204 | Successful DELETE |
   | `BadRequest()` | 400 | Invalid input |
   | `NotFound()` | 404 | Resource not found |
   | `Conflict()` | 409 | Duplicate/conflict |

### 8. **Entity Framework Core Methods Used**
   ```csharp
   // Find by primary key
   db.StudentInfos.Find(id);

   // Get all records
   db.StudentInfos.ToList();

   // Add new record
   db.StudentInfos.Add(student);

   // Remove record
   db.StudentInfos.Remove(student);

   // Update existing record
   db.Entry(existingStudent).CurrentValues.SetValues(newStudent);

   // Save changes to database
   db.SaveChanges();
   ```


### 9. **Route Attribute Patterns**
   ```csharp
   [Route("[controller]")]        // Uses controller name: /StudentAPI
   [Route("api/[controller]")]    // Prefixed: /api/StudentAPI
   [Route("api/students")]        // Custom: /api/students
   
   [HttpGet]                      // GET /StudentAPI
   [HttpGet("{id}")]              // GET /StudentAPI/5
   [HttpGet("search/{name}")]     // GET /StudentAPI/search/John
   ```


### 10. **Key Points to Remember**
   - Use appropriate HTTP methods for each CRUD operation
   - Always validate input data before processing
   - Return appropriate HTTP status codes
   - Use `Find()` for retrieving by primary key
   - Use `SaveChanges()` to persist changes to database
   - Handle null checks to prevent exceptions
   - Use `CreatedAtAction()` for POST to return location header
   - Use `NoContent()` for successful DELETE operations
   - Constructor injection provides DbContext instance

### 11. **Next Steps**
   - Add Data Annotations for validation
   - Implement async/await operations
   - Add DTOs (Data Transfer Objects)
   - Implement Repository Pattern
   - Add error handling middleware
   - Implement logging
   - Add authentication and authorization
   - Learn about API versioning
