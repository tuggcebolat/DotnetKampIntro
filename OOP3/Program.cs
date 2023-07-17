namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //ConsumerCreditManager consumerCreditManager=new ConsumerCreditManager();
         //  consumerCreditManager.Hesapla();
            
          // VehicleLoanManager vehicleLoanManager=new VehicleLoanManager();
          // vehicleLoanManager.Hesapla();

          // HousingCreditManager housingCreditManager=new HousingCreditManager();
          //  housingCreditManager.Hesapla();

            ICreditManager consumerCreditManagerr=new ConsumerCreditManager();
            ICreditManager vehicleLoanManager=new VehicleLoanManager();
            ICreditManager housingCreditManagerr=new HousingCreditManager();

            ApplicationManager applicationManager=new ApplicationManager();
            applicationManager.BasvuruYap(consumerCreditManagerr);

        }
    }
}