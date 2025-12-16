using System;

namespace AB2_Zahlen2
{
    internal class Program
    {
        // Einfacher Konsolen-Mini-Rechner mit Menü für Anfänger.
        // Das Programm läuft in einer Schleife, bis der Benutzer '0' wählt.

        static void Main(string[] args)
        {
            int choice = -1;

            // Haupt-Schleife des Menüs
            while (choice != 0) // Solange nicht 'Ende' gewählt wurde
            {
                ShowMenu();

                // Auswahl vom Benutzer einlesen
                Console.Write("Auswahl (0-4): ");
                string? input = Console.ReadLine();

                // Versuch, die Eingabe in eine ganze Zahl zu konvertieren
                // Keine Verwendung von 'continue' — stattdessen if/else, damit Anfänger den Ablauf leichter verstehen.
                if (!int.TryParse(input, out choice))
                {
                    Console.WriteLine("Bitte eine Zahl von 0 bis 4 eingeben.");
                }
                else
                {
                    // Auswahl auswerten und passende Aktion ausführen
                    switch (choice)
                    {
                        case 0:
                            Console.WriteLine("Programm beendet.");
                            break;
                        case 1:
                            DoAdd(); // Addieren
                            break;
                        case 2:
                            DoSub(); // Subtrahieren
                            break;
                        case 3:
                            DoMul(); // Multiplizieren
                            break;
                        case 4:
                            DoDiv(); // Dividieren
                            break;
                        default:
                            Console.WriteLine("Ungültige Auswahl, bitte erneut versuchen.");
                            break;
                    }

                    Console.WriteLine(); // Leerzeile zur besseren Lesbarkeit
                }
            }
        }

        // Menü-Anzeige
        static void ShowMenu()
        {
            Console.WriteLine("Menü:");
            Console.WriteLine("1) Addieren");
            Console.WriteLine("2) Subtrahieren");
            Console.WriteLine("3) Multiplizieren");
            Console.WriteLine("4) Dividieren");
            Console.WriteLine("0) Ende");
        }

        // Liest eine Fließkommazahl ein und wiederholt bei ungültiger Eingabe.
        static double ReadDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();

                // TryParse verhindert Ausnahmen bei ungültiger Eingabe
                if (double.TryParse(input, out double value))
                    return value;

                Console.WriteLine("Ungültige Zahl, bitte erneut eingeben.");
            }
        }

        // Hilfsmethode: fragt zwei Zahlen ab und zeigt das Ergebnis der Addition
        static void DoAdd()
        {
            Console.WriteLine("Addieren");
            double a = ReadDouble("Erste Zahl: ");
            double b = ReadDouble("Zweite Zahl: ");
            Console.WriteLine("Ergebnis: " + Add(a, b));
        }

        // Hilfsmethode: fragt zwei Zahlen ab und zeigt das Ergebnis der Subtraktion
        static void DoSub()
        {
            Console.WriteLine("Subtrahieren");
            double a = ReadDouble("Erste Zahl: ");
            double b = ReadDouble("Zweite Zahl: ");
            Console.WriteLine("Ergebnis: " + Sub(a, b));
        }

        // Hilfsmethode: fragt zwei Zahlen ab und zeigt das Ergebnis der Multiplikation
        static void DoMul()
        {
            Console.WriteLine("Multiplizieren");
            double a = ReadDouble("Erste Zahl: ");
            double b = ReadDouble("Zweite Zahl: ");
            Console.WriteLine("Ergebnis: " + Mul(a, b));
        }

        // Hilfsmethode: fragt zwei Zahlen ab und behandelt Division durch 0
        static void DoDiv()
        {
            Console.WriteLine("Dividieren");
            double a = ReadDouble("Erste Zahl: ");
            double b = ReadDouble("Zweite Zahl: ");

            // Division durch 0 vermeiden
            if (b == 0)
            {
                Console.WriteLine("Fehler: Division durch 0 ist nicht erlaubt.");
                return;
            }

            Console.WriteLine("Ergebnis: " + Div(a, b));
        }

        // Rechenoperationen: jede Operation ist eine eigene Methode (wie gefordert)

        // Addiert zwei Zahlen
        static double Add(double a, double b) => a + b;

        // Subtrahiert b von a
        static double Sub(double a, double b) => a - b;

        // Multipliziert zwei Zahlen
        static double Mul(double a, double b) => a * b;

        // Teilt a durch b (vorausgesetzt b != 0)
        static double Div(double a, double b) => a / b;
    }
}
