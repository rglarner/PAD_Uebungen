namespace AB4_FIFO_Helpdesk
{
    internal class Program
    {
        // record für einen Helpdesk-Fall
        // Enthält Beschreibung des Problems und geschätzten Aufwand in Minuten
        public record Fall(string Beschreibung, int AufwandMinuten);

        static void Main(string[] args)
        {
            // Warteschlange (FIFO) für offene Helpdesk-Fälle
            Queue<Fall> backlog = new Queue<Fall>();

            // Minimaler Ablauf (Demo): einige Fälle erfassen
            NeuenFallErfassen(backlog, "Passwort zurücksetzen", 10);
            NeuenFallErfassen(backlog, "VPN Verbindung funktioniert nicht", 25);
            NeuenFallErfassen(backlog, "Drucker druckt nur leere Seiten", 30);
            NeuenFallErfassen(backlog, "Software-Update installieren", 15);
            NeuenFallErfassen(backlog, "Zugriffsrechte auf Ordner fehlen", 20);

            Console.WriteLine("=== Status nach Erfassen ===");
            OffeneFaelleAnzeigen(backlog);
            GesamtaufwandAnzeigen(backlog);

            Console.WriteLine("\n=== TOP 3 ===");
            TopFaelleAnzeigen(backlog, 3);

            Console.WriteLine("\n=== Bearbeitung ===");
            // Nächsten Fall aus der Queue entnehmen und bearbeiten
            NaechstenFallBearbeiten(backlog);
            NaechstenFallBearbeiten(backlog);

            Console.WriteLine("\n=== Status nach 2 Fällen ===");
            OffeneFaelleAnzeigen(backlog);
            GesamtaufwandAnzeigen(backlog);

            Console.WriteLine("\n=== TOP 3 (neu) ===");
            TopFaelleAnzeigen(backlog, 3);
        }

        // Fügt einen neuen Fall an das Ende der Queue an
        public static void NeuenFallErfassen(Queue<Fall> backlog, string beschreibung, int aufwandMinuten)
        {
            // Validierung: Aufwand muss positiv sein
            if (aufwandMinuten <= 0)
            {
                Console.WriteLine("Fehler: Aufwand muss grösser als 0 sein.");
                return;
            }

            // Neuer Fall wird in die Warteschlange eingefügt (Enqueue)
            backlog.Enqueue(new Fall(beschreibung, aufwandMinuten));
        }

        // Bearbeitet (entfernt) den nächsten Fall aus der Queue
        public static void NaechstenFallBearbeiten(Queue<Fall> backlog)
        {
            // Wenn keine offenen Fälle vorhanden sind, informieren
            if (backlog.Count == 0)
            {
                Console.WriteLine("Keine offenen Fälle.");
                return;
            }

            // Erster Eintrag wird entfernt und bearbeitet (FIFO-Verhalten)
            Fall next = backlog.Dequeue();
            Console.WriteLine($"Bearbeitet: {next.Beschreibung} ({next.AufwandMinuten} min)");
        }

        // Zeigt die Anzahl der offenen Fälle an
        public static void OffeneFaelleAnzeigen(Queue<Fall> backlog)
        {
            Console.WriteLine($"Offene Fälle: {backlog.Count}");
        }

        // Berechnet und gibt den Gesamtaufwand aller offenen Fälle aus
        public static void GesamtaufwandAnzeigen(Queue<Fall> backlog)
        {
            int total = 0;

            // Summe der Aufwände aller Fälle in der Queue
            foreach (Fall f in backlog)
            {
                total += f.AufwandMinuten;
            }

            Console.WriteLine($"Gesamtaufwand offen: {total} min");
        }

        // Zeigt die ersten 'anzahl' Fälle aus der Queue an (ohne sie zu entfernen)
        public static void TopFaelleAnzeigen(Queue<Fall> backlog, int anzahl)
        {
            // Validierung der Eingabe
            if (anzahl <= 0)
            {
                Console.WriteLine("Anzahl muss grösser als 0 sein.");
                return;
            }

            int i = 0;
            // Durch die Warteschlange iterieren und die obersten Einträge anzeigen
            foreach (Fall f in backlog)
            {
                Console.WriteLine($"{i + 1}. {f.Beschreibung} ({f.AufwandMinuten} min)");
                i++;

                // Sobald die gewünschte Anzahl erreicht ist, abbrechen
                if (i >= anzahl)
                    break;
            }

            // Falls die Queue leer ist, gesonderte Meldung
            if (backlog.Count == 0)
            {
                Console.WriteLine("Keine offenen Fälle.");
            }
        }
    }
}
