namespace Linque01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1
            ////        var seafoodProducts = products
            ////.Where(p => p.Category == "Seafood")
            ////.Select(p => new
            ////{
            ////    Name = p.ProductName,
            ////    Price = p.UnitPrice
            ////});

            ////        foreach (var product in seafoodProducts)
            ////        {
            ////            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            ////        }
            #endregion
            #region question2
            ////        var productNames = ProductList
            ////.Select(p => p.ProductName);

            ////        foreach (var name in productNames)
            ////        {
            ////            Console.WriteLine(name);
            ////        }
            #endregion
            #region question3
            ////    var sortedProducts = ProductList
            ////.OrderBy(p => p.UnitPrice)
            ////.Select(p => new
            ////{
            ////    Name = p.ProductName,
            ////    Price = p.UnitPrice
            ////});

            ////    foreach (var product in sortedProducts)
            ////    {
            ////        Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            ////    }

            #endregion
            #region question4
            //        var filteredProducts = ProductList
            //.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30)
            //.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Price = p.UnitPrice
            //});

            //        foreach (var product in filteredProducts)
            //        {
            //            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            //        }
            #endregion
            #region question5
            //        var availableCondiments = ProductList
            //.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments")
            //.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Stock = p.UnitsInStock
            //});

            //        foreach (var product in availableCondiments)
            //        {
            //            Console.WriteLine($"Name: {product.Name}, Stock: {product.Stock}");
            //        }
            #endregion
            #region question6
            //        var result = ProductList
            //.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Price = p.UnitPrice,
            //    StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //});

            //        foreach (var item in result)
            //        {
            //            Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Status: {item.StockStatus}");
            //        }
            #endregion
            #region question7
            //        var result = ProductList
            //.Select((p, index) => new
            //{
            //    Position = index + 1,
            //    Name = p.ProductName
            //});

            //        foreach (var item in result)
            //        {
            //            Console.WriteLine($"{item.Position}. {item.Name}");
            //        }
            #endregion
            #region question8
            //        var sortedProducts = ProductList
            //.OrderBy(p => p.Category)              
            //.ThenByDescending(p => p.UnitPrice)  
            //.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Category = p.Category,
            //    Price = p.UnitPrice
            //});

            //        foreach (var product in sortedProducts)
            //        {
            //            Console.WriteLine($"Category: {product.Category}, Name: {product.Name}, Price: {product.Price}");
            //        }
            #endregion
            #region question9
            //        var result = ProductList
            //.Where(p => p.Category == "Beverages")          
            //.OrderByDescending(p => p.UnitsInStock)     
            //.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Stock = p.UnitsInStock
            //});

            //        foreach (var item in result)
            //        {
            //            Console.WriteLine($"Name: {item.Name}, Stock: {item.Stock}");
            //        }
            #endregion
            #region question10
            //var result = from c in Customers
            //             from o in c.Orders
            //             where o.OrderDate.Year >= 1997
            //             select new
            //             {
            //                 CustomerID = c.CustomerID,
            //                 OrderDate = o.OrderDate
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"CustomerID: {item.CustomerID}, OrderDate: {item.OrderDate}");
            //}
            #endregion
            #region question11
            //        var result = ProductList
            //.Select((p, index) => new
            //{
            //    Position = index + 1,    
            //    Name = p.ProductName
            //});

            //        foreach (var item in result)
            //        {
            //            Console.WriteLine($"{item.Position}. {item.Name}");
            //        }
            #endregion
            #region question12
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sorted = Arr
            //    .OrderBy(w => w.Length)                   
            //    .ThenBy(w => w, StringComparer.OrdinalIgnoreCase);  

            //foreach (var word in sorted)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion
        }
    }
}
