class Program
{


    static int CenaVykon(int Cena, int Vykon)
    {
        return Cena / Vykon;
    }


    static void Main()
    {
        List<string> nazvy = new List<string>();
        List<int> ceny = new List<int>();
        List<int> vykony = new List<int>();
        List<int> pomer = new List<int>();


        int vstup = 0;
        bool chcepokracovat = true;
        while (chcepokracovat)
        {
            Console.Clear();
            Console.Write("chces pridat auto (1) nebo vypsat auto s nejlepsim pomerem cena/vykon(2),vypsat vsechny (3), nebo zkoncit(4): ");
            vstup = int.Parse(Console.ReadLine());


            if (vstup == 0) Console.WriteLine("napis validni vstup prosim");


            if (vstup == 1)
            {
                Console.Write("napis nazev tohoto fara: ");
                nazvy.Add(Console.ReadLine());
                Console.Write("napis cenu tohoto fara: ");
                ceny.Add(int.Parse(Console.ReadLine()));
                Console.Write("a napis vykon tohoto fara: ");
                vykony.Add(int.Parse(Console.ReadLine()));
                pomer.Add(CenaVykon(ceny.Last(), vykony.Last()));
            }


            if (vstup == 2)
            {
                int best = 1000000000;
                for (int i = 0; i < nazvy.Count; i++)
                {
                    if (pomer[i] < best)  best = CenaVykon(ceny[i], vykony[i]);

                }
                for (int i = 0;i < nazvy.Count; i++)
                {
                    if (pomer[i] == best)
                    {
                        Console.WriteLine("nejlepsi auto cena/vykon je: " + nazvy[i]);
                        Console.Write("(Enter == zpatky)");
                        Console.ReadLine();
                    }
                }
               
            }

            if (vstup == 3)
            {
                foreach (string c in nazvy)
                {
                    Console.WriteLine(c);
                }
                Console.Write("(Enter == zpatky)");
                Console.ReadLine();
            }

            if (vstup == 4) chcepokracovat = false;
        }


    }
    
}