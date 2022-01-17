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

            decimal netice = (Convert.ToDecimal(yol) * 10) / 100;

            car.Benzin -= netice;

            if (car.Benzin < 0)
            {
                Console.WriteLine("Kifayet qeder benzin yoxdur.");
            }
            else
            {
                Console.WriteLine("Sizin" + " " + car.Benzin + " litr benzininiz qaldi.");
               
            }

        }


        public void BenzinDoldur(Car car)
        {
            Console.WriteLine("Nece litr benzin doldurmaq isteyirsiniz?");
            string benzinDoldur = Console.ReadLine();
            Console.WriteLine(benzinDoldur + " litr benzin doldurdunuz.");


            

            if (car.BenzinTutumu > (car.Benzin += Convert.ToDecimal(benzinDoldur)))
            {
                Console.WriteLine("Bu qeder benzin doldura bilmezsiniz.");
            }
            else
            {
                car.Benzin += Convert.ToDecimal(benzinDoldur);
            }

        }


        public decimal BenzinMiqdari(decimal movcudBenzin)
        {
           

            return 100;
        }
    }
}
