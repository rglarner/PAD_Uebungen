namespace AB1_StringsUndZahlen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Übung 1 – Begrüssungsnachricht formatieren
            Console.Write("Bitte Vornamen eingeben: ");
            string vorname = Console.ReadLine();

            Console.Write("Bitte Nachnamen eingeben: ");
            string nachname = Console.ReadLine();

            string begruessung = "Hallo " + vorname + " " + nachname + ", willkommen im Modul PAD!";

            Console.WriteLine(begruessung);
            Console.ReadLine();

            // Übung 2 – Länge einer Zeichenkette bestimmen
            Console.Write("Bitte einen Text eingeben: ");
            string text2 = Console.ReadLine();

            int anzahlZeichen = text2.Length;

            Console.WriteLine("Der Text hat " + anzahlZeichen + " Zeichen.");
            Console.ReadLine();

            // Übung 3 – Die ersten drei Zeichen ausgeben
            Console.Write("Bitte einen Text mit mindestens 3 Zeichen eingeben: ");
            string text3 = Console.ReadLine();

            char erstesZeichen = text3[0];
            char zweitesZeichen = text3[1];
            char drittesZeichen = text3[2];

            Console.WriteLine("1: " + erstesZeichen + ", 2: " + zweitesZeichen + ", 3: " + drittesZeichen);
            Console.ReadLine();

            // Übung 4 – Durchschnitt von drei Zahlen
            Console.Write("Bitte erste Zahl eingeben: ");
            double zahl1 = double.Parse(Console.ReadLine());

            Console.Write("Bitte zweite Zahl eingeben: ");
            double zahl2 = double.Parse(Console.ReadLine());

            Console.Write("Bitte dritte Zahl eingeben: ");
            double zahl3 = double.Parse(Console.ReadLine());

            double summe = zahl1 + zahl2 + zahl3;

            double durchschnittDouble = summe / 3.0;

            int durchschnittInt = (int)durchschnittDouble;

            Console.WriteLine("Summe: " + summe);
            Console.WriteLine("Durchschnitt (double): " + durchschnittDouble);
            Console.WriteLine("Durchschnitt (int): " + durchschnittInt);

            Console.ReadLine();
        }
    }
}
