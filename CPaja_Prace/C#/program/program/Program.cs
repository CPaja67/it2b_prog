class Program
{

    static void GrafickeZnazorneni(int[] indexy, int vyska)
    {
        for (int i = 0; i < vyska; i++)
        {
            for (int j = 0; j < indexy.Length; j++)
            {
                if (indexy[i] == j)
                {
                    Console.Write("O");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine("");
        }
    }
        static void Vykreslit(int[] hodnoty)
        {

            int[] indexy = new int[hodnoty.Length];
            int[] serazeno = new int[hodnoty.Length];
            Array.Copy(hodnoty, serazeno, hodnoty.Length);
            Array.Sort(serazeno);
            Array.Reverse(serazeno);

            for (int i = 0; i < hodnoty.Length; i++)
            {
                for (int j = 0; j < serazeno.Length; j++)
                {
                    if (serazeno[i] == hodnoty[j])
                    {
                        if (!indexy.Contains(hodnoty[i])) indexy[i] = j;
                    }
                }
            }
            GrafickeZnazorneni(indexy, hodnoty.Max());
        }

        static void Main()
        {
            int[] hodnoty = { 0, 1, 2, 3, 4, 5, 6, 7 ,8 ,9, 10};
            Vykreslit(hodnoty);

        }
    
}