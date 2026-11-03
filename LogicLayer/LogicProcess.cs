using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLayer;
using EntitiesLayer;

namespace LogicLayer
{
    public static class LogicProcess
    {
        private static bool HasText(string value, int minLength = 2) =>
            !string.IsNullOrWhiteSpace(value) && value.Trim().Length >= minLength;

        public static User Login(string username, string password)
        {
            var user = DataProcess.FindUser(username);
            return user != null && PasswordHasher.Verify(password, user.PasswordHash) ? user : null;
        }

        public static List<User> GetUsers() => DataProcess.GetUsers();

        public static bool AddUser(string username, string password, bool isAdmin)
        {
            if (!HasText(username, 3) || !HasText(password, 4)) return false;
            DataProcess.AddUser(new User { Username = username, PasswordHash = PasswordHasher.Hash(password), IsAdmin = isAdmin });
            return true;
        }

        public static bool UpdateUser(int id, string username, string password, bool isAdmin)
        {
            if (!HasText(username, 3) || !HasText(password, 4)) return false;
            DataProcess.UpdateUser(new User { Id = id, Username = username, PasswordHash = PasswordHasher.Hash(password), IsAdmin = isAdmin });
            return true;
        }

        public static void DeleteUser(int id) => DataProcess.DeleteUser(id);

        public static List<Unit> GetUnits() => DataProcess.GetUnits();

        public static bool AddUnit(Unit unit)
        {
            if (!HasText(unit.Name)) return false;
            DataProcess.AddUnit(unit);
            return true;
        }

        public static bool UpdateUnit(Unit unit)
        {
            if (!HasText(unit.Name)) return false;
            DataProcess.UpdateUnit(unit);
            return true;
        }

        public static void DeleteUnit(int id) => DataProcess.DeleteUnit(id);

        public static List<Category> GetCategories() => DataProcess.GetCategories();

        public static bool AddCategory(Category category)
        {
            if (!HasText(category.Name) || category.VatRate < 0) return false;
            DataProcess.AddCategory(category);
            return true;
        }

        public static bool UpdateCategory(Category category)
        {
            if (!HasText(category.Name) || category.VatRate < 0) return false;
            DataProcess.UpdateCategory(category);
            return true;
        }

        public static void DeleteCategory(int id) => DataProcess.DeleteCategory(id);

        public static List<Brand> GetBrands() => DataProcess.GetBrands();

        public static bool AddBrand(Brand brand)
        {
            if (!HasText(brand.Name)) return false;
            DataProcess.AddBrand(brand);
            return true;
        }

        public static bool UpdateBrand(Brand brand)
        {
            if (!HasText(brand.Name)) return false;
            DataProcess.UpdateBrand(brand);
            return true;
        }

        public static void DeleteBrand(int id) => DataProcess.DeleteBrand(id);

        public static List<Supplier> GetSuppliers() => DataProcess.GetSuppliers();

        public static bool AddSupplier(Supplier supplier)
        {
            if (!HasText(supplier.Name)) return false;
            DataProcess.AddSupplier(supplier);
            return true;
        }

        public static bool UpdateSupplier(Supplier supplier)
        {
            if (!HasText(supplier.Name)) return false;
            DataProcess.UpdateSupplier(supplier);
            return true;
        }

        public static void DeleteSupplier(int id) => DataProcess.DeleteSupplier(id);

        public static List<Customer> GetCustomers() => DataProcess.GetCustomers();

        public static List<Customer> SearchCustomersByName(string name) => DataProcess.SearchCustomersByName(name.Trim());

        public static List<Customer> SearchCustomersByPhone(string phone) => DataProcess.SearchCustomersByPhone(phone.Trim());

        public static bool AddCustomer(Customer customer)
        {
            if (!HasText(customer.Name)) return false;
            DataProcess.AddCustomer(customer);
            return true;
        }

        public static bool UpdateCustomer(Customer customer)
        {
            if (!HasText(customer.Name)) return false;
            DataProcess.UpdateCustomer(customer);
            return true;
        }

        public static void DeleteCustomer(int id) => DataProcess.DeleteCustomer(id);

        public static List<Product> GetProducts() => DataProcess.GetProducts();

        public static List<Product> SearchProductsByCode(string code) => DataProcess.SearchProductsByCode(code.Trim());

        public static List<Product> SearchProductsByDescription(string description) => DataProcess.SearchProductsByDescription(description.Trim());

        private static bool IsValid(Product product) =>
            HasText(product.Code, 1) && HasText(product.Description, 3) &&
            product.SalePrice >= 0 && product.PurchasePrice >= 0 && product.Stock >= 0;

        public static bool AddProduct(Product product)
        {
            if (!IsValid(product)) return false;
            DataProcess.AddProduct(product);
            return true;
        }

        public static bool UpdateProduct(Product product)
        {
            if (!IsValid(product)) return false;
            DataProcess.UpdateProduct(product);
            return true;
        }

        public static void DeleteProduct(int id) => DataProcess.DeleteProduct(id);

        public static bool CompleteSale(IEnumerable<Product> cart)
        {
            var quantities = cart.GroupBy(p => p.Id).ToDictionary(g => g.Key, g => g.Count());
            return DataProcess.DecreaseStock(quantities);
        }

        public static List<DailyReport> GetDailyReports() => DataProcess.GetDailyReports();

        public static bool DailyReportExists(DateTime date) => DataProcess.DailyReportExists(date);

        public static void AddDailyReport(DailyReport report) => DataProcess.AddDailyReport(report);

        public static void UpdateDailyReport(DailyReport report) => DataProcess.UpdateDailyReport(report);

        public static void DeleteDailyReport(int id) => DataProcess.DeleteDailyReport(id);
    }
}
