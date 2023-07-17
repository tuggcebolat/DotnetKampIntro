using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        public void BasvuruYap(ICreditManager creditManager)
        {
            //başvuran bilgileri değerlendirme
            //
            HousingCreditManager housingCreditManager = new HousingCreditManager();
            housingCreditManager.Hesapla();
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
