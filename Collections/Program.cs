namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler2 = new List<string> { "muhammed","inan","engin","demiroğ"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Tuğçe");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}