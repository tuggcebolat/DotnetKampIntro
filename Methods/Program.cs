namespace Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Name = "Apple";
            urun1.Price = 100;
            urun1.Description = "Amasya";

            Product urun2 = new Product();
            urun2.Name = "Waterlemon";
            urun2.Price = 100;
            urun2.Description = "Diyarbakır";

            Product[] urunler = new Product[] { urun1, urun2 };

            foreach (Product urun in urunler)
            {

                Console.WriteLine(urun.Name);
                Console.WriteLine(urun.Price);  
                Console.WriteLine(urun.Description);    
                Console.WriteLine("------------------");    

            }

            Console.WriteLine("-----------Metotlar---------");

            //instance
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(urun1);
            sepetManager.Add(urun2);


        }
    }
}