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
                car.Yurus += (Convert.ToDecimal(yol)); // 0 + 200 = 200 | 200 + 300 = 500
                car.Benzin -= netice; // 100 - 20 = 80 | 80 - 30 = 50 
                Console.WriteLine("Sizin" + " " + car.Benzin + " litr benzininiz qaldi.");
                

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



        public void MasinInfo(Car car)
        {
            Console.WriteLine("Masin adi: " + car.Name);
            Console.WriteLine("Benzin: " + car.Benzin + " litr");
            Console.WriteLine("Benzin tutumu: " + car.BenzinTutumu + " litr");
            Console.WriteLine("Yurus: " + car.Yurus + " km | " + car.Yurus / 1.6M + " mil");
        }
    }
}
