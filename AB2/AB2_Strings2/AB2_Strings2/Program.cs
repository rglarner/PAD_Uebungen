using System;

namespace AB2_Strings2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Übung 5 – Passwortprüfung");

            string password;
            do
            {
                Console.Write("Passwort eingeben: ");
                password = Console.ReadLine();

                if (!IsValidPassword(password))
                {
                    Console.WriteLine("Ungültiges Passwort. Es muss mindestens 8 Zeichen, eine Ziffer und einen Grossbuchstaben enthalten.");
                }
            }
            while (!IsValidPassword(password));

            Console.WriteLine("Passwort ist gültig.");
        }

        static bool IsValidPassword(string password)
        {
            // Eingabe auf null/leer und Mindestlänge prüfen
            if (string.IsNullOrEmpty(password) || password.Length < 8)
                return false;

            // Flags für die benötigten Bedingungen
            bool hasDigit = false;   // mindestens eine Ziffer
            bool hasUpper = false;   // mindestens ein Großbuchstabe

            // Durch jedes Zeichen iterieren und Bedingungen prüfen
            foreach (char c in password)
            {
                // Ziffer gefunden?
                if (char.IsDigit(c))
                    hasDigit = true;
                // Großbuchstabe gefunden?
                else if (char.IsUpper(c))
                    hasUpper = true;

                // Wenn beide Bedingungen erfüllt sind, kann sofort true zurückgegeben werden
                if (hasDigit && hasUpper)
                    return true;
            }

            // Falls am Ende nicht beide Bedingungen erfüllt wurden, ist das Passwort ungültig
            return false;
        }
    }
}
