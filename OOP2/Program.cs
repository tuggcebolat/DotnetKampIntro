namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerNo = "12646468";
            customer1.FirstName = "Tuğçe";
            customer1.LastName = "Bolat";
            customer1.TcNo = "13419879876871";

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "12886";
            customer2.CompanyName = "Leon";
            customer2.TaxId = "2548";

           CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

           

           
        }
    }
}