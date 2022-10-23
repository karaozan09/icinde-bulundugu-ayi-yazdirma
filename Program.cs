using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Haftaucüçüncükısım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime bugün = DateTime.Today;
            //Console.WriteLine(bugün);

            Console.WriteLine("1'den 7'ye kadar bir gün giriniz:");
           int date = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1'den 12'ye kadar bir ay giriniz: ");
            int ay=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("yıl giriniz:");
            int yıl=Convert.ToInt32(Console.ReadLine());

            if (ay == 1)
            {
                Console.WriteLine("ocak ayındasınız");
            }
            else if (ay == 2)
            {
                Console.WriteLine("şubat ayındasınız");
            }
            else if (ay == 3)
            {
                Console.WriteLine("mart ayındasınız");
            }
            else if (ay == 4)
            {
                Console.WriteLine("nisan ayındasınız");
            }
            else if(ay == 5)
            {
                Console.WriteLine("mayıs ayındasınız");
            }else if(ay == 6)
            {
                Console.WriteLine("haziran ayındasınız");
            }else if(ay==7)
            {
                Console.WriteLine("temmuz ayındasınız");
            }else if(ay==8)
            {
                Console.WriteLine("ağustos ayındasınız");
            }else if (ay == 9)
            {
                Console.WriteLine("Eylül ayındasınız");

            }else if(ay==10)
            {
                Console.WriteLine("ekim ayındasınınz");
            }else if (ay == 11)
            {
                Console.WriteLine("kasım ayındasınız");
            }else if(ay==12)
            {
                Console.WriteLine("aralık ayındasınız");
            }
            else
            {
                Console.WriteLine("öyle bir ay yok");  
            }
         

            Console.ReadLine();
        }
    }
}
