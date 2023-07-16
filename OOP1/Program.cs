namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Product product1 = new Product(); 
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";  
            product1.UnitPrice = 500;  
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 1, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem",UnitPrice=35};

            //
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            //productManager.Topla2(3, 6);
            var result = productManager.Topla(50,45);
            

            productManager.Topla2(50, 45);


        }
    }
}