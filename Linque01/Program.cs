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
        }
    }
}
