using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using Task_010.Data;
namespace Task_010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext _context = new ApplicationDbContext();
            #region 1 - List all customers' first and last names along with their email addresses.
            //var customers = _context.Customers.Select(c => new
            //{
            //    c.FirstName,
            //    c.LastName,
            //    c.Email
            //});
            //foreach(var i in customers)
            //    Console.WriteLine($"{i.FirstName}    {i.LastName}    {i.Email}"); 
            #endregion



            #region 2- Retrieve all orders processed by a specific staff member (e.g., staff_id = 3).
            //var orders = _context.Orders.Where(o => o.StaffId == 3);
            //foreach (var i in orders)
            //    Console.WriteLine($"{i.StaffId}      {i.OrderId}"); 
            #endregion



            #region 3- Get all products that belong to a category named "Mountain Bikes". 
            //var products = _context.Products.Where(p => p.Category.CategoryName == "Mountain Bikes").Select(p => new
            //{
            //    p.ProductId,
            //    p.Category.CategoryName
            //});
            //foreach(var i in products)
            //    Console.WriteLine($"{i.ProductId}       {i.CategoryName}"); 
            #endregion



            #region 4-Count the total number of orders per store. 
            //var orders = _context.Orders.GroupBy(o => o.StoreId).OrderBy(o => o.Key).Select(o => new
            //{
            //    o.Key,
            //    NumberOfOrders=o.Count()
            //});
            //foreach(var i in orders)
            //    Console.WriteLine($"{i.Key}      {i.NumberOfOrders}"); 
            #endregion



            #region 5- List all orders that have not been shipped yet (shipped_date is null). 
            //var orders = _context.Orders.Where(o => o.ShippedDate == null);
            //foreach(var i in orders)
            //    Console.WriteLine($"{i.OrderId}      {i.ShippedDate}"); 
            #endregion



            #region 6 - Display each customer’s full name and the number of orders they have placed.
            //var customers = _context.Customers.Select(c => new
            //{
            //    FullName = $"{c.FirstName} {c.LastName}",
            //    NumberOfOrders = c.Orders.Count()
            //});
            //foreach(var i in customers)
            //    Console.WriteLine($"{i.FullName}            {i.NumberOfOrders}"); 
            #endregion



            #region 7- List all products that have never been ordered (not found in order_items).
            //var products = _context.Products.Where(p => !p.OrderItems.Any());
            //foreach(var i in products)
            //    Console.WriteLine($"{i.ProductId}      {i.ProductName}"); 
            #endregion



            #region 8 - Display products that have a quantity of less than 5 in any store stock.
            //var LowerQuantityProducts = _context.Stocks.Join(
            //    _context.Products,
            //    s => s.ProductId,
            //    p => p.ProductId,
            //    (s, o) => new
            //    {
            //        o.ProductName,
            //        s.Quantity
            //    }
            //    ).Where(s => s.Quantity < 5);
            //foreach(var i in LowerQuantityProducts)
            //    Console.WriteLine($"{i.ProductName}      {i.Quantity}"); 
            #endregion



            #region 9- Retrieve the first product from the products table. 
            //var product = _context.Products.FirstOrDefault();
            //Console.WriteLine($"{product.ProductName}       {product.Quantity}"); 
            #endregion



            #region 10 - Retrieve all products from the products table with a certain model year.
            //var products = _context.Products.Where(p=>p.ModelYear==2018);
            //foreach(var i in products)
            //    Console.WriteLine($"{i.ProductId}      {i.ProductName}      {i.ModelYear}"); 
            #endregion



            #region 11 - Display each product with the number of times it was ordered.
            //var products = _context.Products.Where(p=>p.OrderItems.Count==0).Select(p => new
            //{
            //    p.ProductId,
            //    NumberOfOrdring = p.OrderItems.Count()
            //});
            //foreach(var i in products)
            //    Console.WriteLine($"{i.ProductId}      {i.NumberOfOrdring}"); 
            #endregion



            #region 12- Count the number of products in a specific category.
            //var ProductsInACategory = _context.Categories.Where(c => c.CategoryId == 7).Select(c => new
            //{
            //    c.CategoryName,
            //    NumberOfProducts = c.Products.Count()
            //});
            //foreach(var i in ProductsInACategory)
            //    Console.WriteLine($"{i.CategoryName}      {i.NumberOfProducts}"); 
            #endregion



            #region 13 - Calculate the average list price of products.
            //var AveragePrice = _context.Products.Select(p => p.ListPrice).Average();
            //Console.WriteLine(AveragePrice); 
            #endregion



            #region 14 - Retrieve a specific product from the products table by ID.
            //var product = _context.Products.FirstOrDefault(p => p.ProductId == 5);
            //Console.WriteLine($"{product.ProductId}      {product.ProductName}      {product.ListPrice}"); 
            #endregion



            #region 15 - List all products that were ordered with a quantity greater than 3 in any order.
            //var ProductsGraeterThan3AtOnce = _context.OrderItems.Where(oi => oi.Quantity > 3).Include(oi => oi.Product)
            //    .Select(oi => new
            //    {
            //        oi.Product.ProductName,
            //        oi.Quantity
            //    });
            //foreach(var i in ProductsGraeterThan3AtOnce)
            //    Console.WriteLine($"{i.ProductName}      {i.Quantity}"); 
            #endregion



            #region 16 - Display each staff member’s name and how many orders they processed.
            //var Staff = _context.Staffs.Where(s=>s.ManagerId!=null).Select(s => new
            //{
            //    FullName = $"{s.FirstName} {s.LastName}",
            //    NumberPfOrders = s.Orders.Count()

            //});
            //foreach(var i in Staff)
            //    Console.WriteLine($"{i.FullName}      {i.NumberPfOrders}");

            #endregion



            #region 17 - List active staff members only(active = true) along with their phone numbers.
            //var ActiveStaff = _context.Staffs.Where(s => s.Active == 1);
            //foreach(var i in ActiveStaff)
            //    Console.WriteLine($"{i.StaffId}      {i.FirstName}      {i.Active}      {i.Phone}"); 
            #endregion



            #region 18 - List all products with their brand name and category name.
            //var products = _context.Products.Select(p => new
            //{
            //    p.ProductId,
            //    p.ProductName,
            //    p.Category.CategoryName,
            //    p.Brand.BrandName
            //});
            //foreach(var i in products)
            //    Console.WriteLine($"{i.ProductId}      {i.ProductName}      {i.CategoryName}      {i.BrandName}"); 
            #endregion



            #region 19 - Retrieve orders that are completed.
            //var CompletedOrders = _context.Orders.Where(o => o.OrderStatus == 4);
            //foreach(var i in CompletedOrders)
            //    Console.WriteLine($"{i.OrderId}     {i.OrderStatus}"); 
            #endregion



            #region 20 - List each product with the total quantity sold(sum of quantity from order_items).
            //var Products = _context.Products.Select(p => new
            //{
            //    p.ProductId,
            //    p.ProductName,
            //    TotalQuantitySold = p.OrderItems.Sum(oi => oi.Quantity)
            //});
            //foreach(var i in Products)
            //    Console.WriteLine($"{i.ProductId}      {i.ProductName}      {i.TotalQuantitySold}"); 
            #endregion
        }
    }
}
