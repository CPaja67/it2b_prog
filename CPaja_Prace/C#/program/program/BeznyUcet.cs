class BeznyUcet
{
    private double Zustatek { get; set; }
    public string Jmeno { get; set; }
    private string Heslo { get; set; }

    public BeznyUcet(string jmeno, string heslo)
    {
        Jmeno = jmeno;
        Heslo = heslo;
        Zustatek = 0;
    }

    public void VlozeniPenez(double kolko, string heslo)
    {
        if (kolko <= 0) return;
        if (heslo != Heslo){Console.WriteLine("spatne heslo!"); return;}
        Console.WriteLine("bylo vlozeno: " + kolko);
        Console.WriteLine("zustatek před: " + Zustatek);
        Zustatek += kolko;
        Console.WriteLine("zustatek po: " + Zustatek);
    }

    public void Platba(double kolko, string heslo)
    {
        if (kolko <= 0 || kolko > Zustatek) return;
        if (heslo != Heslo) { Console.WriteLine("spatne heslo!"); return; }
        Console.WriteLine("bylo zaplaceno: " + kolko);
        Console.WriteLine("zustatek před: " + Zustatek);
        Zustatek -= kolko;
        Console.WriteLine("zustatek po: " + Zustatek);
    }

    public double ZobrazitZustatek()
    {
        if (Zustatek <= 0) Console.WriteLine("jste bankrotovali!");
        Console.WriteLine("na ucte " + Jmeno + " je: " + Zustatek);
        return Zustatek;
    }

}