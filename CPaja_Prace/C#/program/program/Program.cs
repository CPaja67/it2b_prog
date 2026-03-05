class Program
{
    static void Main()
    {
        double[] teploty = new double[10];
        Console.WriteLine("zadej 10 teplot (desetiny) po sobe:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"teplota {i + 1}: ");
            teploty[i] = double.Parse(Console.ReadLine());
            Console.WriteLine("");
        }
        Console.WriteLine("---------------------");
        Array.Sort(teploty);
        Console.WriteLine($"maximum je {teploty.Max()}");
        Console.WriteLine($"rozdil mezi maximem a minimem je {teploty.Max() - teploty.Min()}");
        Console.WriteLine("nejnizsi 3 hodnoty jsou: ");
        for (int x = 0; x <3; x++) Console.WriteLine($" --> {teploty[x]}");
        Console.WriteLine("");
        Console.WriteLine($"Median je: {(teploty[4] + teploty[5]) / 2}");
    }
}