using System;

class Esercizio
{
    public static void Main(string[] args)
    {
    
        static void StampaMenu(string[] gusti, double[] prezzi)
        {
            Console.WriteLine("--- Gelateria 2026**TEAM3** di Marco.Matteo.Michele ---");
            Console.WriteLine("--- GUSTI DISPONIBILI ---");
            for (int i = 0; i < gusti.Length; i++)
            {
                Console.WriteLine(i + ") " + gusti[i] + " - " + prezzi[i] + " Euro");
            }
            Console.WriteLine("-------------------------");
        }
    }
}