using System.Linq.Expressions;
using 

class Program
{


    static void Main()
    {
        string jmeno, heslo;
        Console.WriteLine("                          Epstein Banking Association");
        Console.WriteLine("");
        Console.WriteLine("Dobry den, chcete si u nas vytvorit ucet?");
        Console.WriteLine("napis jmeno uctu: ");
        jmeno = Console.ReadLine();
        Console.WriteLine("nais heslo k uctu: ");
        heslo = Console.ReadLine();
        BeznyUcet ucet = new BeznyUcet(jmeno, heslo);

        while (true)
        {
            int choice = 0;
            double kolik = 0;
            Console.Clear();
            Console.WriteLine("                          Epstein Banking Association");
            Console.WriteLine("");
            ucet.ZobrazitZustatek();
            Console.WriteLine("co chcete udelat? (2 = vlozit penize, 3 = platba penez)");
            choice = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine("");
            switch (choice)
            {
                case 2:
                    Console.WriteLine("zadejte kolik chcete vlozit: ");
                    kolik = double.Parse(Console.ReadLine());
                    Console.WriteLine("zadejte heslo: ");
                    ucet.VlozeniPenez(kolik, Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("zadejte kolik chcete zaplatit: ");
                    kolik = double.Parse(Console.ReadLine());
                    Console.WriteLine("zadejte heslo: ");
                    ucet.Platba(kolik ,Console.ReadLine());
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine("");
            Console.WriteLine("Entrem se vratis");
            Console.ReadLine();
        }

    }
    
}