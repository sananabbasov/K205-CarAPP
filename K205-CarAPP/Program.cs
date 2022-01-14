using K205_CarAPP.Methods;

Evvele:
Console.WriteLine("1. Yola cix");
Console.WriteLine("2. Benzin doldur");
Console.WriteLine("3. Yanacaq miqdari");
Console.WriteLine("4. Yurus");
Console.WriteLine("5. Cixis");

string daxilEdilenReqem = Console.ReadLine();



Go start = new Go();


decimal benzin = 100M;


switch (Convert.ToInt32(daxilEdilenReqem))
{
    case 1:
        start.HereketeBasla(benzin);
        goto Evvele;
        break;
    case 2:
        start.BenzinDoldur(benzin);
        goto Evvele;
        break;
    case 3:
        Console.WriteLine("3. Yanacaq miqdari");
        break;
    case 4:
        Console.WriteLine("4. Yurus");
        break;
    case 5:
        Console.WriteLine("5. Cixis");
        break;
    default:
        Console.WriteLine("Dogru reqem daxil edin.");
        break;
}
