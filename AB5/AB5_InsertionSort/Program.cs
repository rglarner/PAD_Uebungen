using System;
using System.Diagnostics;

namespace AB5_InsertionSort
{
    internal class Program
    {
        // Hinweis: Die Zeitmessungen sind nicht repräsentativ, da die Arrays zu klein sind und sie durch die aktuelle Systemauslastung beeinflusst werden können.
        static void Main(string[] args)
        {
            int[] zufaellig = { 42, 7, 89, 23, 56, 91, 14, 68, 35, 77, 4, 60, 28, 83, 19, 50, 95, 31, 11, 72 };
            int[] aufsteigend = { 4, 7, 11, 14, 19, 23, 28, 31, 35, 42, 50, 56, 60, 68, 72, 77, 83, 89, 91, 95 };
            int[] absteigend = { 95, 91, 89, 83, 77, 72, 68, 60, 56, 50, 42, 35, 31, 28, 23, 19, 14, 11, 7, 4 };
            InsertionSort(zufaellig);
            InsertionSort(aufsteigend);
            InsertionSort(absteigend);
        }
        static void InsertionSort(int[] values)
        {
            // Startzeit merken
            Stopwatch sw = Stopwatch.StartNew();

            Console.WriteLine($"Startwerte: {ArrayToString(values)}");
            // i startet bei 1, weil ein einzelnes Element (Index 0) bereits als "sortiert" gilt
            for (int i = 1; i < values.Length; i++)
            {
                int current = values[i];   // Element, das eingefügt werden soll
                int j = i - 1;             // Start im sortierten Bereich links von i

                // solange links ein grösseres Element steht, schieben wir es nach rechts
                while (j >= 0 && values[j] > current)
                {
                    values[j + 1] = values[j];
                    j--;
                }

                // Einfügen an der gefundenen Stelle
                values[j + 1] = current;
                Console.WriteLine($"Schritt {i:D2}: {ArrayToString(values)}");
            }

            // Zeit stoppen und ausgeben
            sw.Stop();
            Console.WriteLine($"Dauer der Sortierung: {sw.Elapsed.TotalMilliseconds} ms ({sw.Elapsed})");
        }
        static string ArrayToString(int[] values)
        {
            string result = "";
            // Ausgabe zu Kontrolle
            for (int i = 0; i < values.Length; i++)
            {
                result += " " + values[i].ToString();
            }
            return result;
        }
    }
}
