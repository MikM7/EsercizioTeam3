using System;

class Esercizio
{
    public static void Main(string[] args)
    {
        double totale = 0;
        string riepilogo = "\n--- RIEPILOGO ORDINE ---\n";
        bool continua = true;

        while (continua)
        {
            StampaMenu();

            int scelta;
            Console.Write("Inserisci il numero del gusto (1-5): ");
        
            while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 1 || scelta > 5)
            {
                Console.WriteLine("Errore! Inserisci un numero valido tra 1 e 5:");
            }

            int quantita;
            Console.Write("Quante palline vuoi di questo gusto? ");
            while (!int.TryParse(Console.ReadLine(), out quantita) || quantita <= 0)
            {
                Console.WriteLine("Inserisci un numero valido (maggiore di 0):");
            }

            string nomeGusto = "";
            double prezzoPalla = 1.50;

            switch (scelta)
            {
                case 1: nomeGusto = "Cioccolato"; break;
                case 2: nomeGusto = "Vaniglia"; break;
                case 3: nomeGusto = "Fragola"; break;
                case 4: nomeGusto = "Pistacchio"; break;
                case 5: nomeGusto = "Limone"; break;
            }

            double costoParziale = prezzoPalla * quantita;
            totale += costoParziale;
            riepilogo += $"{quantita}x {nomeGusto} - {costoParziale:F2}€\n";

            Console.WriteLine($"Aggiunto: {quantita} palline di {nomeGusto}.");
            
            Console.Write("\nVuoi aggiungere un altro gusto? (s/n): ");
            if (Console.ReadLine().ToLower() != "s")
            {
                continua = false;
            }
        }

    
        Console.WriteLine(riepilogo);
        Console.WriteLine("------------------------");
        Console.WriteLine($"TOTALE FINALE: {totale:F2}€");
        Console.WriteLine("Grazie e a presto!");
    }
    public static void StampaMenu()
    {
        Console.WriteLine("\n--- GUSTI DISPONIBILI ---");
        Console.WriteLine("1. Cioccolato");
        Console.WriteLine("2. Vaniglia");
        Console.WriteLine("3. Fragola");
        Console.WriteLine("4. Pistacchio");
        Console.WriteLine("5. Limone");
        Console.WriteLine("-------------------------");
    }

    /*public static float CalcolaTotale(int prezzoGusto, int quantita)
    {
        float prezzoTotale = 0;

        prezzoTotale = prezzoGusto * quantita;
        return prezzoTotale;
    }

    public static void StampaMenu(string[] gusti, double[] prezzi)
    {
        Console.WriteLine("--- Gelateria 2026**TEAM3** di Marco.Matteo.Michele ---");
        Console.WriteLine("--- GUSTI DISPONIBILI ---");
        for (int i = 0; i < gusti.Length; i++)
        {
            Console.WriteLine(i + ") " + gusti[i] + " - " + prezzi[i] + " Euro");
        }
        Console.WriteLine("-------------------------");
    }*/
}