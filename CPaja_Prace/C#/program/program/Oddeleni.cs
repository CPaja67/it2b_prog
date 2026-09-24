using System.Linq.Expressions;

class Oddeleni
{

    public string Nazev {  get; set; }
    public Sestricka Sestricks { get; set; }
    public List<Pokoj> Pokoje;
    public int VolnychPosteli {  get; set; }


    public Oddeleni(string nazev, Sestricka sestricka)
    {
        Nazev = nazev;
        Sestricks = sestricka;
        Pokoje = new List<Pokoj>();
    }

    public void PridatPokoj(Pokoj pokoj)
    {
        Pokoje.Add(pokoj);
        VolnychPosteli += pokoj.VolnyPostele;
    }
    
    public int VolnyPostele()
    {
        return VolnychPosteli;
    }

}