using System;

namespace AB2_Strings1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Beispiele
            Console.WriteLine($"\"Hallo\" -> {ZähleVokale("Hallo")}");
            Console.WriteLine($"\"Programmieren\" -> {ZähleVokale("Programmieren")}");
        }

        static int ZähleVokale(string text)
        {
            int zähler = 0;
            foreach (char c in text) // Alternative: for (int i = 0; i < text.Length; i++)
            {
                switch (char.ToLowerInvariant(c))
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        zähler++;
                        break;
                }
            }

            return zähler;
        }
    }
}
