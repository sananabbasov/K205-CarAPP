using K205_CarAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K205_CarAPP.Methods
{
    public class CarManager
    {
        public void HereketeBasla(Car car)
        {
            Console.WriteLine("Nece km yol gedeceksiniz?");
            string yol = Console.ReadLine();
            decimal netice = (Convert.ToDecimal(yol) * 10) / 100; // 100 - 10 | 200*10/100 = 20 | 300 * 10 / 100 = 30
            decimal benzinYoxla =  car.Benzin - netice; // 100 - 20 = 80 | 80 - 30 = 50
            if (benzinYoxla < 0) // 80 < 0 = false | 50 < 0 = false
            {
                Console.WriteLine("Kifayet qeder benzin yoxdur.");
            }
            else // true
            {
                decimal odenis = car.GedisHaqqi * Convert.ToDecimal(yol) / 100;
                car.Yurus += (Convert.ToDecimal(yol)); // 0 + 200 = 200 | 200 + 300 = 500
                car.Benzin -= netice; // 100 - 20 = 80 | 80 - 30 = 50 
                car.Qazanc += odenis;
                Console.WriteLine("Sizin" + " " + car.Benzin + " litr benzininiz qaldi.");
                Console.WriteLine("Odenilecek mebleg: " + odenis + " AZN");


            }

        }


        public void BenzinDoldur(Car car)
        {
            Console.WriteLine("Nece litr benzin doldurmaq isteyirsiniz?");
            string benzinDoldur = Console.ReadLine();

            


            decimal netice = car.Benzin + Convert.ToDecimal(benzinDoldur); // 100 + 200



            if (car.BenzinTutumu <= netice) // 200 < 300
            {
                Console.WriteLine("Bu qeder benzin doldura bilmezsiniz.");
            }
            else
            {
                car.Benzin += Convert.ToDecimal(benzinDoldur);
                Console.WriteLine(benzinDoldur + " litr benzin doldurdunuz.");

            }

        }

        public void OdenisHesablama(Car car)
        {
            Console.WriteLine("100Km-ya odenis teyin edin.");
            string odenisTeyini = Console.ReadLine();

            car.GedisHaqqi = Convert.ToDecimal(odenisTeyini);
            
        }

        public void MasinInfo(Car car)
        {
            Console.WriteLine("Masin adi: " + car.Name);
            Console.WriteLine("Benzin: " + car.Benzin + " litr");
            Console.WriteLine("Benzin tutumu: " + car.BenzinTutumu + " litr");
            Console.WriteLine("Qazanilan mebleg: " + car.Qazanc + " AZN");
            Console.WriteLine("Yurus: " + car.Yurus + " km | " + car.Yurus / 1.6M + " mil");
        }
    }
}
