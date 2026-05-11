class BeznyUcet
{
    public double Zustatek { get; set; }
    

    public BeznyUcet(double zustatek)
    {
        Zustatek = zustatek;
    }

    public void VlozeniPenez(double kolko)
    {
        if (kolko <= 0) return;
        Console.WriteLine("bylo vlozeno: " + kolko);
        Console.WriteLine("zustatek před: " + Zustatek);
        Zustatek += kolko;
        Console.WriteLine("zustatek po: " + Zustatek);
    }

    public void Platba(double kolko)
    {
        if (kolko <= 0 || kolko > Zustatek) return;
        Console.WriteLine("bylo zaplaceno: " + kolko);
        Console.WriteLine("zustatek před: " + Zustatek);
        Zustatek -= kolko;
        Console.WriteLine("zustatek po: " + Zustatek);
    }

    public void ZobrazitZustatek()
    {
        if (Zustatek <= 0) Console.WriteLine("jste bankrotovali!");
        Console.WriteLine("Zustatek je: " + Zustatek);
    }

}