using System.Linq.Expressions;

class Pokoj
{
    public string Nazev {  get; set; }

    public int VolnyPostele {  get; set; }
    public const int Postele = 10;


    public Pokoj(string nazev) 
    {
        Nazev = nazev;
        VolnyPostele = Postele;
    }

    public void PridejPacienta()
    {
        if (VolnyPostele >= 1)
        {
            VolnyPostele -= 1;
        }
    }
    
}