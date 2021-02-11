using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriAdı = "kategoriler";
            bool sistemeGirisYaptiMi=true;
            double dolardun = 7.35;
            double dolarbugün = 7.45;

            if (dolardun>dolarbugün)
            {
                Console.WriteLine("azalış butonu");
            }
            else if (dolardun < dolarbugün)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu"); 
            }




            if (sistemeGirisYaptiMi == true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }


            Console.WriteLine(kategoriAdı);

            Console.ReadKey();
        }
    }
}
