using System;

class Esercizio
{
    public static void Main(string[] args)
    {
        float totale = 0, totaleScontato = 0;
        string riepilogo = "\n--- RIEPILOGO ORDINE ---\n";
        bool continua = true;

        string[] gusti = { "Cioccolato", "Vaniglia", "Fragola", "Pistacchio", "Limone"};
        float[] prezzi = { 2, 3, 4, 5, 2};
        
        int quantita;
        string nomeGusto = "";
        float prezzoPalla = 0;

        while (continua)
        {
            
            StampaMenu(gusti, prezzi);

            int scelta;
            Console.Write("Inserisci il numero del gusto (1-5): ");
        
            while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 1 || scelta > 5)
            {
                Console.WriteLine("Errore! Inserisci un numero valido tra 1 e 5:");
            }

            Console.Write("Quante palline vuoi di questo gusto? ");
            while (!int.TryParse(Console.ReadLine(), out quantita) || quantita <= 0)
            {
                Console.WriteLine("Inserisci un numero valido (maggiore di 0):");
            }

            switch (scelta)
            {
                case 1: 
                    nomeGusto = gusti[scelta-1]; 
                    prezzoPalla = prezzi[scelta-1];
                    break;
                case 2:
                    nomeGusto = gusti[scelta-1]; 
                    prezzoPalla = prezzi[scelta-1];
                    break;
                case 3:
                    nomeGusto = gusti[scelta-1]; 
                    prezzoPalla = prezzi[scelta-1];
                    break;
                case 4:
                    nomeGusto = gusti[scelta-1]; 
                    prezzoPalla = prezzi[scelta-1];
                    break;
                case 5:
                    nomeGusto = gusti[scelta-1]; 
                    prezzoPalla = prezzi[scelta-1];
                    break;
            }

            float costoParziale = CalcolaTotale(prezzoPalla, quantita);
            totale += costoParziale;
            
            riepilogo += $"Palline: {quantita}x - Gusto: {nomeGusto} - Costo: {costoParziale:F2}€\n";

            Console.WriteLine($"Aggiunto: {quantita} palline di {nomeGusto}.");
            
            Console.Write("\nVuoi aggiungere un altro gusto? (s/n): ");
            if (Console.ReadLine().ToLower() != "s")
            {
                continua = false;
            }
        }

    
        Console.WriteLine(riepilogo);
        Console.WriteLine("------------------------");

        //if(totaleScontato > 0){Console.WriteLine($"TOTALE FINALE: {totaleScontato:F2}€ (SCONTATO)");}
        Console.WriteLine($"TOTALE FINALE: {totale:F2}€");
        
        Console.WriteLine("Grazie e a presto!");
    }

    public static float CalcolaTotale(float prezzoGusto, int quantita)
    {
        float prezzoTotale = 0;

        prezzoTotale = prezzoGusto * quantita;

        if(prezzoTotale > 10)
        {
            prezzoTotale *= 0.9f;
        }
        return prezzoTotale;       
    }

    public static void StampaMenu(string[] gusti, float[] prezzi)
    {
        Console.WriteLine("--- Gelateria 2026**TEAM3** di Marco.Matteo.Michele ---");
        Console.WriteLine("--- GUSTI DISPONIBILI ---");
        for (int i = 0; i < gusti.Length; i++)
        {
            Console.WriteLine(i+1 + ") " + gusti[i] + " - " + prezzi[i] + " Euro");
        }
        Console.WriteLine("-------------------------");
    }
}