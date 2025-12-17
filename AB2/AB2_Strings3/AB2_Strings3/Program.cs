using System;

namespace AB2_Strings3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Übung – Palindromprüfung");

            // Beispiele
            Console.WriteLine($"\"lagerregal\" -> {IsPalindrome("lagerregal")}");
            Console.WriteLine($"\"otto\" -> {IsPalindrome("otto")}");
            Console.WriteLine($"\"hello\" -> {IsPalindrome("hello")}");
        }

        static bool IsPalindrome(string text)
        {
            // Null-Eingabe behandeln (optional: hier als true betrachtet)
            if (text == null)
                return true;

            // Basisfall: leere Zeichenkette oder ein Zeichen ist immer ein Palindrom
            if (text.Length <= 1)
                return true;

            // Ungleiches erstes/letztes Zeichen -> kein Palindrom
            if (text[0] != text[text.Length - 1])
                return false;

            // Sonst rekursiv den inneren Teil prüfen (erste und letzte Zeichen entfernen)
            return IsPalindrome(text.Substring(1, text.Length - 2));
        }
    }
}
