class Program
{


    static void Main()
    {
        Console.WriteLine("Epstein Banking Association");
        Console.WriteLine("Dobry den, chcete si u nas vytvorit ucet? staci napsat, kolik penez chcete vlozit a máte ucet u nas!");
        BeznyUcet ucet = new BeznyUcet(double.Parse(Console.ReadLine()));

        while (true)
        {
            Console.Clear();
            Console.WriteLine("co chcete udelat? (1 = zobrazit zustatek, 2 = vlozit penize, 3 = platba penez)");
            
        }

    }
    
}