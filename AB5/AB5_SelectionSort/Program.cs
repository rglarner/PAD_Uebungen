using System.Diagnostics;

namespace AB5_SelectionSort
{
    internal class Program
    {
        // Hinweis: Die Zeitmessungen sind nicht repräsentativ, da die Arrays zu klein sind und sie durch die aktuelle Systemauslastung beeinflusst werden können.
        static void Main(string[] args)
        {
            int[] zufaellig = { 42, 7, 89, 23, 56, 91, 14, 68, 35, 77, 4, 60, 28, 83, 19, 50, 95, 31, 11, 72 };
            int[] aufsteigend = { 4, 7, 11, 14, 19, 23, 28, 31, 35, 42, 50, 56, 60, 68, 72, 77, 83, 89, 91, 95 };
            int[] absteigend = { 95, 91, 89, 83, 77, 72, 68, 60, 56, 50, 42, 35, 31, 28, 23, 19, 14, 11, 7, 4 };
            SelectionSort(zufaellig);
            SelectionSort(aufsteigend);
            SelectionSort(absteigend);
        }
        static void SelectionSort(int[] values)
        {
            // Startzeit merken
            Stopwatch sw = Stopwatch.StartNew();

            Console.WriteLine($"Startwerte: {ArrayToString(values)}");

            // i markiert die aktuelle Zielposition im sortierten Bereich
            for (int i = 0; i < values.Length - 1; i++)
            {
                int minIndex = i;

                // Suche das kleinste Element im unsortierten Bereich
                for (int j = i + 1; j < values.Length; j++)
                {
                    if (values[j] < values[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Tauschen, falls ein kleineres Element gefunden wurde
                if (minIndex != i)
                {
                    int temp = values[i];
                    values[i] = values[minIndex];
                    values[minIndex] = temp;
                }

                Console.WriteLine($"Schritt {i + 1:D2}: {ArrayToString(values)}");
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
