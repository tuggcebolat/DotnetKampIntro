using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class SepetManager
    {
        public void Add(Product urun)
        {
            Console.WriteLine(" Tebrikler sepete eklendi : " + urun.Name);  
        
        }   
        public void Add2(string urunAdi,string description, double prize)
        {
            Console.WriteLine(" Tebrikler sepete eklendi : " + urunAdi);


        }
    }
}
