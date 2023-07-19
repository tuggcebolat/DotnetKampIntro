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

            ICreditManager consumerCreditManager=new ConsumerCreditManager();
            ICreditManager vehicleLoanManager=new VehicleLoanManager();
            ICreditManager housingCreditManagerr=new HousingCreditManager();

            ILoggerService databaseloggerService = new DataBaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() { new SmsLoggerService(), new FileLoggerService()};
            ApplicationManager applicationManager=new ApplicationManager();
            applicationManager.BasvuruYap(new BusinessLoanManager(), loggers);

            List<ICreditManager> credits=new List<ICreditManager>() { consumerCreditManager, vehicleLoanManager};
           // applicationManager.KrediOnBilgilendirmesiYap(credits);


        }
    }
}