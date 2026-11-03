using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using EntitiesLayer;
using static DataAccessLayer.Database;

namespace DataAccessLayer
{
    public static class DataProcess
    {
        private static User MapUser(SqlDataReader r) => new User
        {
            Id = (int)r["Id"],
            Username = (string)r["Username"],
            PasswordHash = (string)r["PasswordHash"],
            IsAdmin = (bool)r["IsAdmin"]
        };

        public static List<User> GetUsers() =>
            Query("SELECT * FROM Users ORDER BY Id", MapUser);

        public static User FindUser(string username) =>
            Query("SELECT * FROM Users WHERE Username = @username", MapUser, Param("@username", username)).FirstOrDefault();

        public static void AddUser(User user) =>
            Execute("INSERT INTO Users (Username, PasswordHash, IsAdmin) VALUES (@username, @hash, @isAdmin)",
                Param("@username", user.Username), Param("@hash", user.PasswordHash), Param("@isAdmin", user.IsAdmin));

        public static void UpdateUser(User user) =>
            Execute("UPDATE Users SET Username = @username, PasswordHash = @hash, IsAdmin = @isAdmin WHERE Id = @id",
                Param("@id", user.Id), Param("@username", user.Username), Param("@hash", user.PasswordHash), Param("@isAdmin", user.IsAdmin));

        public static void DeleteUser(int id) =>
            Execute("DELETE FROM Users WHERE Id = @id", Param("@id", id));

        public static List<Unit> GetUnits() =>
            Query("SELECT * FROM Units ORDER BY Id", r => new Unit { Id = (int)r["Id"], Name = (string)r["Name"] });

        public static void AddUnit(Unit unit) =>
            Execute("INSERT INTO Units (Name) VALUES (@name)", Param("@name", unit.Name));

        public static void UpdateUnit(Unit unit) =>
            Execute("UPDATE Units SET Name = @name WHERE Id = @id", Param("@id", unit.Id), Param("@name", unit.Name));

        public static void DeleteUnit(int id) =>
            Execute("DELETE FROM Units WHERE Id = @id", Param("@id", id));

        public static List<Category> GetCategories() =>
            Query("SELECT * FROM Categories ORDER BY Id", r => new Category { Id = (int)r["Id"], Name = (string)r["Name"], VatRate = (int)r["VatRate"] });

        public static void AddCategory(Category category) =>
            Execute("INSERT INTO Categories (Name, VatRate) VALUES (@name, @vat)", Param("@name", category.Name), Param("@vat", category.VatRate));

        public static void UpdateCategory(Category category) =>
            Execute("UPDATE Categories SET Name = @name, VatRate = @vat WHERE Id = @id",
                Param("@id", category.Id), Param("@name", category.Name), Param("@vat", category.VatRate));

        public static void DeleteCategory(int id) =>
            Execute("DELETE FROM Categories WHERE Id = @id", Param("@id", id));

        public static List<Brand> GetBrands() =>
            Query("SELECT * FROM Brands ORDER BY Id", r => new Brand { Id = (int)r["Id"], Name = (string)r["Name"] });

        public static void AddBrand(Brand brand) =>
            Execute("INSERT INTO Brands (Name) VALUES (@name)", Param("@name", brand.Name));

        public static void UpdateBrand(Brand brand) =>
            Execute("UPDATE Brands SET Name = @name WHERE Id = @id", Param("@id", brand.Id), Param("@name", brand.Name));

        public static void DeleteBrand(int id) =>
            Execute("DELETE FROM Brands WHERE Id = @id", Param("@id", id));

        public static List<Supplier> GetSuppliers() =>
            Query("SELECT * FROM Suppliers ORDER BY Id", r => new Supplier
            {
                Id = (int)r["Id"],
                Name = (string)r["Name"],
                Address = r["Address"] as string,
                Phone = r["Phone"] as string
            });

        public static void AddSupplier(Supplier supplier) =>
            Execute("INSERT INTO Suppliers (Name, Address, Phone) VALUES (@name, @address, @phone)",
                Param("@name", supplier.Name), Param("@address", supplier.Address), Param("@phone", supplier.Phone));

        public static void UpdateSupplier(Supplier supplier) =>
            Execute("UPDATE Suppliers SET Name = @name, Address = @address, Phone = @phone WHERE Id = @id",
                Param("@id", supplier.Id), Param("@name", supplier.Name), Param("@address", supplier.Address), Param("@phone", supplier.Phone));

        public static void DeleteSupplier(int id) =>
            Execute("DELETE FROM Suppliers WHERE Id = @id", Param("@id", id));

        private static Customer MapCustomer(SqlDataReader r) => new Customer
        {
            Id = (int)r["Id"],
            NationalId = r["NationalId"] as string,
            Name = (string)r["Name"],
            Address = r["Address"] as string,
            Phone = r["Phone"] as string
        };

        public static List<Customer> GetCustomers() =>
            Query("SELECT * FROM Customers ORDER BY Id", MapCustomer);

        public static List<Customer> SearchCustomersByName(string name) =>
            Query("SELECT * FROM Customers WHERE Name LIKE @name ORDER BY Id", MapCustomer, Param("@name", "%" + name + "%"));

        public static List<Customer> SearchCustomersByPhone(string phone) =>
            Query("SELECT * FROM Customers WHERE Phone LIKE @phone ORDER BY Id", MapCustomer, Param("@phone", "%" + phone + "%"));

        public static void AddCustomer(Customer customer) =>
            Execute("INSERT INTO Customers (NationalId, Name, Address, Phone) VALUES (@nationalId, @name, @address, @phone)",
                Param("@nationalId", customer.NationalId), Param("@name", customer.Name), Param("@address", customer.Address), Param("@phone", customer.Phone));

        public static void UpdateCustomer(Customer customer) =>
            Execute("UPDATE Customers SET NationalId = @nationalId, Name = @name, Address = @address, Phone = @phone WHERE Id = @id",
                Param("@id", customer.Id), Param("@nationalId", customer.NationalId), Param("@name", customer.Name),
                Param("@address", customer.Address), Param("@phone", customer.Phone));

        public static void DeleteCustomer(int id) =>
            Execute("DELETE FROM Customers WHERE Id = @id", Param("@id", id));

        private const string ProductSelect = @"
            SELECT p.*, u.Name AS UnitName, c.Name AS CategoryName, b.Name AS BrandName, s.Name AS SupplierName
            FROM Products p
            JOIN Units u ON u.Id = p.UnitId
            JOIN Categories c ON c.Id = p.CategoryId
            JOIN Brands b ON b.Id = p.BrandId
            JOIN Suppliers s ON s.Id = p.SupplierId";

        private static Product MapProduct(SqlDataReader r) => new Product
        {
            Id = (int)r["Id"],
            Code = (string)r["Code"],
            Description = (string)r["Description"],
            SalePrice = (decimal)r["SalePrice"],
            PurchasePrice = (decimal)r["PurchasePrice"],
            Stock = (int)r["Stock"],
            UnitId = (int)r["UnitId"],
            CategoryId = (int)r["CategoryId"],
            BrandId = (int)r["BrandId"],
            SupplierId = (int)r["SupplierId"],
            UnitName = (string)r["UnitName"],
            CategoryName = (string)r["CategoryName"],
            BrandName = (string)r["BrandName"],
            SupplierName = (string)r["SupplierName"]
        };

        public static List<Product> GetProducts() =>
            Query(ProductSelect + " ORDER BY p.Id", MapProduct);

        public static List<Product> SearchProductsByCode(string code) =>
            Query(ProductSelect + " WHERE p.Code = @code ORDER BY p.Id", MapProduct, Param("@code", code));

        public static List<Product> SearchProductsByDescription(string description) =>
            Query(ProductSelect + " WHERE p.Description LIKE @description ORDER BY p.Id", MapProduct, Param("@description", "%" + description + "%"));

        private static SqlParameter[] ProductParams(Product p) => new[]
        {
            Param("@code", p.Code), Param("@description", p.Description), Param("@salePrice", p.SalePrice),
            Param("@purchasePrice", p.PurchasePrice), Param("@stock", p.Stock), Param("@unitId", p.UnitId),
            Param("@categoryId", p.CategoryId), Param("@brandId", p.BrandId), Param("@supplierId", p.SupplierId)
        };

        public static void AddProduct(Product product) =>
            Execute(@"INSERT INTO Products (Code, Description, SalePrice, PurchasePrice, Stock, UnitId, CategoryId, BrandId, SupplierId)
                      VALUES (@code, @description, @salePrice, @purchasePrice, @stock, @unitId, @categoryId, @brandId, @supplierId)",
                ProductParams(product));

        public static void UpdateProduct(Product product) =>
            Execute(@"UPDATE Products SET Code = @code, Description = @description, SalePrice = @salePrice, PurchasePrice = @purchasePrice,
                      Stock = @stock, UnitId = @unitId, CategoryId = @categoryId, BrandId = @brandId, SupplierId = @supplierId
                      WHERE Id = @id",
                ProductParams(product).Append(Param("@id", product.Id)).ToArray());

        public static void DeleteProduct(int id) =>
            Execute("DELETE FROM Products WHERE Id = @id", Param("@id", id));

        public static bool DecreaseStock(Dictionary<int, int> quantities)
        {
            using (var connection = Open())
            using (var transaction = connection.BeginTransaction())
            {
                foreach (var item in quantities)
                {
                    var command = new SqlCommand("UPDATE Products SET Stock = Stock - @quantity WHERE Id = @id AND Stock >= @quantity", connection, transaction);
                    command.Parameters.AddRange(new[] { Param("@id", item.Key), Param("@quantity", item.Value) });
                    if (command.ExecuteNonQuery() == 0)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
                transaction.Commit();
                return true;
            }
        }

        public static List<DailyReport> GetDailyReports() =>
            Query("SELECT * FROM DailyReports ORDER BY ReportDate DESC", r => new DailyReport
            {
                Id = (int)r["Id"],
                ReportDate = (DateTime)r["ReportDate"],
                CardTotal = (decimal)r["CardTotal"],
                CashTotal = (decimal)r["CashTotal"],
                CheckTotal = (decimal)r["CheckTotal"],
                Revenue = (decimal)r["Revenue"]
            });

        public static bool DailyReportExists(DateTime date) =>
            Query("SELECT Id FROM DailyReports WHERE ReportDate = @date", r => (int)r["Id"], Param("@date", date.Date)).Any();

        private static SqlParameter[] ReportParams(DailyReport report) => new[]
        {
            Param("@date", report.ReportDate.Date), Param("@card", report.CardTotal), Param("@cash", report.CashTotal),
            Param("@check", report.CheckTotal), Param("@revenue", report.Revenue)
        };

        public static void AddDailyReport(DailyReport report) =>
            Execute("INSERT INTO DailyReports (ReportDate, CardTotal, CashTotal, CheckTotal, Revenue) VALUES (@date, @card, @cash, @check, @revenue)",
                ReportParams(report));

        public static void UpdateDailyReport(DailyReport report) =>
            Execute("UPDATE DailyReports SET ReportDate = @date, CardTotal = @card, CashTotal = @cash, CheckTotal = @check, Revenue = @revenue WHERE Id = @id",
                ReportParams(report).Append(Param("@id", report.Id)).ToArray());

        public static void DeleteDailyReport(int id) =>
            Execute("DELETE FROM DailyReports WHERE Id = @id", Param("@id", id));
    }
}
