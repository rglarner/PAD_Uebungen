namespace AB4_ChatList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> chat = new List<string>();

            // Demo-Daten
            NeueNachricht(chat, "Anna", "Hallo zusammen!");
            NeueNachricht(chat, "Ben", "Hi Anna!");
            NeueNachricht(chat, "Clara", "Guten Morgen!");
            NeueNachricht(chat, "Anna", "Wie läuft's?");
            NeueNachricht(chat, "Ben", "Alles gut. Und bei dir?");
            NeueNachricht(chat, "Anna", "Top, danke!");
            NeueNachricht(chat, "Clara", "Meeting um 10?");
            NeueNachricht(chat, "Ben", "Ja, passt.");

            Console.WriteLine("=== Chat (alle) ===");
            PrintAll(chat);

            Console.WriteLine("\n=== Nur Ben ===");
            PrintFromUser(chat, "Ben");

            Console.WriteLine("\n=== Lösche Anna ===");
            DeleteFromUser(chat, "Anna");
            PrintAll(chat);

            Console.WriteLine("\n=== Letzte 3 Nachrichten ===");
            PrintLast(chat, 3);
        }
        public static void NeueNachricht(List<string> chat, string user, string nachricht)
        {
            chat.Add(user + ": " + nachricht);
        }

        public static void PrintAll(List<string> chat)
        {
            foreach (string msg in chat)
            {
                Console.WriteLine(msg);
            }
        }

        public static void PrintFromUser(List<string> chat, string user)
        {
            string prefix = user + ":";

            foreach (string msg in chat)
            {
                if (msg.StartsWith(prefix))
                {
                    Console.WriteLine(msg);
                }
            }
        }

        public static void DeleteFromUser(List<string> chat, string user)
        {
            string prefix = user + ":";

            // rückwärts laufen, damit RemoveAt sicher funktioniert
            for (int i = chat.Count - 1; i >= 0; i--)
            {
                if (chat[i].StartsWith(prefix))
                {
                    chat.RemoveAt(i);
                }
            }
        }

        public static void PrintLast(List<string> chat, int n)
        {
            if (n <= 0)
            {
                return;
            }

            int start = chat.Count - n;
            if (start < 0) start = 0;

            for (int i = start; i < chat.Count; i++)
            {
                Console.WriteLine(chat[i]);
            }
        }
    }
}
