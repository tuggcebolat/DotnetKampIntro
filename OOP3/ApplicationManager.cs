using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {   
        //method injection
        public void BasvuruYap(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            //başvuran bilgileri değerlendirme
            //
            // HousingCreditManager housingCreditManager = new HousingCreditManager();
            //housingCreditManager.Hesapla();
            creditManager.Hesapla();
            // loggerService.Log(); // birden fazla yollanacağı için komut satırına alındı.
            foreach (var loggerServive in loggerServices)
            {
                loggerServive.Log() ;
            }

        }
        public void KrediOnBilgilendirmesiYap(List<ICreditManager>credits)
        {
            foreach (var credit in credits)
            {
                credit.Hesapla(); 
            }

        }
    }
}
