using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K205_CarAPP.Methods
{
    public class Go
    {
        public void HereketeBasla(decimal benzin)
        {
            Console.WriteLine("Nece km yol gedeceksiniz?");

            string yol = Console.ReadLine();

            decimal netice = (Convert.ToDecimal(yol) * 10) / 100;

            decimal qalanBenzin = benzin - netice;

            if (qalanBenzin < 0)
            {
                Console.WriteLine("Kifayet qeder benzin yoxdur.");
            }
            else
            {
                Console.WriteLine("Sizin" + " " + qalanBenzin + " litr benzininiz qaldi.");
            }

        }


        public void BenzinDoldur(decimal benzin)
        {
            Console.WriteLine("Nece litr benzin doldurmaq isteyirsiniz?");

            string benzinDoldur = Console.ReadLine();


            Console.WriteLine(benzinDoldur + " litr benzin doldurdunuz.");

        }
    }
}
