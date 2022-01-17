using K205_CarAPP.Methods;
using K205_CarAPP.Models;

CarManager carManager = new();


Car bmw = new Car() { 
    Id = 1,
    Name = "BMW M5",
    Benzin = 100,
    BenzinTutumu = 200,
    Yurus = 0,
    GedisHaqqi = 1

};


//Car nissan = new Car() { 
//    Benzin = 200
//};

// Benzin - 100 ; Bezin - 10 = 90 | Benzin - 90

Evvele:
Console.WriteLine("1. Yola cix");
Console.WriteLine("2. Benzin doldur");
Console.WriteLine("3. Odenis miqdari");
Console.WriteLine("4. Yurus");
Console.WriteLine("5. Masin info");

string daxilEdilenReqem = Console.ReadLine();





switch (Convert.ToInt32(daxilEdilenReqem))
{
    case 1:
        carManager.HereketeBasla(bmw);
        goto Evvele;
        break;
    case 2:
        carManager.BenzinDoldur(bmw);
        goto Evvele;
        break;
    case 3:
        Console.WriteLine("3. Yanacaq miqdari");
        break;
    case 4:
        Console.WriteLine("4. Yurus");
        break;
    case 5:
        carManager.MasinInfo(bmw);
        goto Evvele;
        break;
    default:
        Console.WriteLine("Dogru reqem daxil edin.");
        break;
}
