namespace ValueType_ReferenceType
{
    internal class Program
    {
        static void Main(string[] args)
        {    //VALUE TYPE (int,decimal, float, double, bool...)
            int x = 30;
            int y = 10;
            x = y;
            Console.WriteLine(x);  //10

            //REFERENCE TYPE (array,class,interface...)
            int[] count1 = { 10, 4, 6};
            int[] count2 = { 1, 2, 3 };

            count1 = count2;
            count2[0] = 99;
            Console.WriteLine(count1[0]);  //99

        }
    }
}