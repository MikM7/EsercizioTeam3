using System;

class Esercizio
{
    public static void Main(string[] args)
    {
        
    }

    public static float CalcolaTotale(int prezzoGusto, int quantita)
    {
        float prezzoTotale = 0;

        prezzoTotale = prezzoGusto * quantita;
        return prezzoTotale;
    }
}