ProductInventoryAPI 🛍️
A robust .NET Web API project built using Database First approach with SQL Server for managing product inventory operations.

🚀 Features
Database First Approach: EF Core scaffolding from existing SQL Server database
RESTful API: Complete CRUD operations for product management
Clean Architecture: Separated concerns with Controllers, Services, and DTOs
SQL Server Integration: Full SSMS compatibility with optimized queries
Entity Framework Core: Latest EF Core with database migrations support
Swagger Documentation: Interactive API documentation and testing
🛠️ Tech Stack
.NET 6/7/8 - Web API Framework
Entity Framework Core - ORM for database operations
SQL Server - Primary database
AutoMapper - Object-to-object mapping
Swagger/OpenAPI - API documentation
Dependency Injection - Built-in DI container
📁 Project Structure
ProductInventoryAPI/
├── Controllers/
│   └── ProductController.cs          # API endpoints
├── Models/
│   ├── Product.cs                    # EF generated entity
│   └── ProductDbContext.cs           # Database context
├── Services/
│   ├── IProductService.cs            # Service interface
│   └── ProductService.cs             # Business logic
├── DTOs/
│   └── ProductDTO.cs                 # Data transfer objects
├── Migrations/                       # EF migrations (if needed)
├── appsettings.json                  # Configuration
├── Program.cs                        # Application entry point
└── Startup.cs                        # Service configuration
🔧 Setup Instructions
Prerequisites
Visual Studio 2022 or VS Code
.NET 6+ SDK
SQL Server (LocalDB/Express/Full)
SQL Server Management Studio (SSMS)
1. Database Setup
Run the following SQL script in SSMS:

CREATE DATABASE ProductInventory;
USE ProductInventory;

CREATE TABLE Products (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100) NOT NULL,
    Description NVARCHAR(500),
    Price DECIMAL(10, 2) NOT NULL,
    Quantity INT NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE()
);

-- Insert sample data
INSERT INTO Products (Name, Description, Price, Quantity) VALUES
('Laptop', 'High-performance laptop', 55000.00, 10),
('Mouse', 'Wireless optical mouse', 1200.00, 50),
('Keyboard', 'Mechanical keyboard', 3500.00, 25);
2. Clone & Install
git clone https://github.com/yourusername/ProductInventoryAPI.git
cd ProductInventoryAPI
dotnet restore
3. Configure Connection String
Update appsettings.json:

{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=ProductInventory;Trusted_Connection=True;"
  }
}
4. Database First Scaffolding
Install EF Core tools:

dotnet tool install --global dotnet-ef
Generate models from database:

dotnet ef dbcontext scaffold "Server=localhost;Database=ProductInventory;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models -f
5. Run the Application
dotnet build
dotnet run
Visit: https://localhost:7xxx/swagger for API documentation

📚 API Endpoints
Method	Endpoint	Description
GET	/api/product	Get all products
GET	/api/product/{id}	Get product by ID
POST	/api/product	Create new product
PUT	/api/product/{id}	Update product
DELETE	/api/product/{id}	Delete product
Sample Request/Response
POST /api/product

{
  "name": "Smartphone",
  "description": "Latest Android smartphone",
  "price": 25000.00,
  "quantity": 15
}
Response

{
  "id": 4,
  "name": "Smartphone",
  "description": "Latest Android smartphone",
  "price": 25000.00,
  "quantity": 15,
  "createdAt": "2025-01-15T10:30:00"
}
🎯 Key Features Implemented
Repository Pattern: Clean separation of data access logic
Service Layer: Business logic encapsulation
DTO Pattern: Data transfer optimization
Error Handling: Comprehensive exception management
Validation: Input validation with Data Annotations
Logging: Structured logging with ILogger
Dependency Injection: Loosely coupled architecture
🧪 Testing
Run unit tests:

dotnet test
Test with Postman or use the integrated Swagger UI.

📝 Database First Benefits
Existing Database: Works with pre-existing SQL Server databases
DBA Friendly: Database changes managed by DBAs
Performance: Optimized queries and stored procedures
Enterprise Ready: Suitable for large-scale applications
🤝 Contributing
Fork the repository
Create a feature branch (git checkout -b feature/amazing-feature)
Commit changes (git commit -m 'Add amazing feature')
Push to branch (git push origin feature/amazing-feature)
Open a Pull Request
📄 License
This project is licensed under the MIT License - see the LICENSE file for details.

📞 Support
For support and queries:

Create an issue in the repository
Email: ritwiksinghkkc@gmail.com
Happy Coding! 🚀
