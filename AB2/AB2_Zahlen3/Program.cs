using System;

namespace AB2_Zahlen3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Übersicht: Benutzer wählt Variante A (Quersumme) oder B (Potenz)
            Console.WriteLine("Übung 3 – Rekursion");
            Console.WriteLine("1) Quersumme (DigitSum)");
            Console.WriteLine("2) Potenz (Power)");
            Console.Write("Auswahl (1-2): ");
            string choiceInput = Console.ReadLine();

            if (choiceInput == "1")
            {
                // Variante A: Quersumme (Input wird nicht validiert -> unstabiler Code)
                Console.Write("Bitte eine ganze, nicht-negative Zahl eingeben: ");
                int n = int.Parse(Console.ReadLine());
                
                int sum = DigitSum(n); // Aufruf rekursiver Methode
                Console.WriteLine($"Quersumme von {n} ist {sum}.");
            }
            else if (choiceInput == "2")
            {
                // Variante B: Potenz (Input wird validiert mit TryParse und Schleife -> stabiler Code)
                Console.Write("Basis (ganze Zahl): ");
                string baseInput = Console.ReadLine();
                int basis;
                while (!int.TryParse(baseInput, out basis))
                {
                    Console.WriteLine("Ungültige Eingabe. Geben Sie eine ganze Zahl als Basis ein.");
                    Console.Write("Basis: ");
                    baseInput = Console.ReadLine();
                }

                Console.Write("Exponent (ganzzahlig, >= 0): ");
                string expInput = Console.ReadLine();
                int exponent;
                while (!int.TryParse(expInput, out exponent) || exponent < 0)
                {
                    Console.WriteLine("Ungültige Eingabe. Der Exponent muss eine ganze Zahl >= 0 sein.");
                    Console.Write("Exponent: ");
                    expInput = Console.ReadLine();
                }

                int result = Power(basis, exponent); // Aufruf rekursiver Methode
                Console.WriteLine($"{basis} hoch {exponent} = {result}");
            } else { 
                Console.WriteLine("Ungültige Auswahl. Programmende");
            }
        }

        // Variante A: Quersumme (rekursiv)
        // Basisfall: n < 10 -> Quersumme ist n selbst.
        // Rekursiv: letzte Ziffer + Quersumme des Rests.
        static int DigitSum(int n)
        {
            if (n < 10) // Basisfall
                return n;

            int lastDigit = n % 10;   // letzte Ziffer (Modulo 10, Restwert)
            int remaining = n / 10;   // Rest ohne letzte Ziffer (Ganzzahldivision 10)
            return lastDigit + DigitSum(remaining); // Rekursiver Aufruf
        }

        // Variante B: Potenz (rekursiv)
        // Signatur: static int Power(int basis, int exponent)
        // Basisfall: exponent == 0 -> Ergebnis ist 1.
        // Rekursiv: basis * Power(basis, exponent - 1)
        static int Power(int basis, int exponent)
        {
            if (exponent == 0) // Basisfall
                return 1;

            return basis * Power(basis, exponent - 1); // Rekursiver Aufruf
        }
    }
}
