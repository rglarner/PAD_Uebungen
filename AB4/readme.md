# AB4 
# Übung 7 – 2D-Array: Zeichenfläche mit Figuren

## Ziel
Es soll eine Zeichenfläche (Spielfläche) als **2D-Array** aufgebaut werden. Auf die Fläche können Figuren gezeichnet werden, indem bestimmte Zellen mit einem Zeichen überschrieben werden.

## Anforderungen

### 1) Spielfläche
- Verwende ein fixes `char[,]` als Spielfläche (z. B. Breite 40, Höhe 15).
- Initialisiere die gesamte Fläche mit einem Hintergrundzeichen (z. B. `'.'`).

### 2) Methoden
Implementiere folgende Methoden:

#### `Clear(...)`
- setzt jede Zelle der Fläche auf das Hintergrundzeichen.

#### `Print(...)`
- gibt die Fläche zeilenweise in der Konsole aus.

#### `DrawRectangle(...)`
Zeichnet ein gefülltes Rechteck.
Parameter:
- `char[,] field`
- `int startX`, `int startY`
- `int width`, `int height`
- `char symbol`

Regeln:
- Das Rechteck wird **gefüllt** gezeichnet (alle Zellen innerhalb).
- Die Methode gibt `bool` zurück:
  - `true`, wenn das Rechteck **vollständig** innerhalb der Fläche liegt
  - `false`, wenn mindestens ein Teil ausserhalb liegt  
  (Trotz `false` soll alles, was innerhalb liegt, gezeichnet werden.)
- Die Fläche wird immer überschrieben (kein “Kollisionstest”).

#### `DrawSquare(...)`
- Zeichnet ein Quadrat, indem intern `DrawRectangle(...)` verwendet wird.
- Parameter:
  - `char[,] field`
  - `int startX`, `int startY`
  - `int size`
  - `char symbol`
- Rückgabewert `bool` analog zu `DrawRectangle(...)`.

### 3) Demo im `Main`
Erstelle eine Demo, die:
- die Fläche leert
- mehrere Rechtecke und Quadrate zeichnet (mind. 4 Figuren, teils überlappend)
- mindestens eine Figur teilweise ausserhalb startet (so dass `false` zurückkommt)
- am Ende die Fläche ausgibt

# Übung 8 – List<T>: Chatlog

## Ziel
Ein Chat wird als **Liste von Strings** gespeichert. Jede Nachricht wird in folgendem Format abgelegt:

`User: Nachricht`

## Anforderungen

### Datenstruktur
- Verwende `List<string> chat`.

### Funktion 1: Neue Nachricht
Implementiere eine Methode:

`NeueNachricht(List<string> chat, string user, string nachricht)`

- speichert eine neue Nachricht im Format `User: Nachricht` in der Liste.

### Funktion 2: Chat ausgeben
Implementiere:

`PrintAll(List<string> chat)`

- gibt alle Nachrichten in der Reihenfolge aus.

### Funktion 3: Nur Nachrichten von Benutzer X
Implementiere:

`PrintFromUser(List<string> chat, string user)`

- gibt nur Nachrichten aus, die zu diesem Benutzer gehören.
- Erkennung über `StartsWith(user + ":")`.

### Funktion 4: Nachrichten von Benutzer X löschen
Implementiere:

`DeleteFromUser(List<string> chat, string user)`

- löscht alle Nachrichten dieses Benutzers.
- Erkennung über `StartsWith(user + ":")`.
- Hinweis: Beim Löschen während des Durchlaufs ist eine `for`-Schleife (rückwärts) sinnvoll.

### Funktion 5: Letzte N Nachrichten anzeigen
Implementiere:

`PrintLast(List<string> chat, int n)`

- gibt die letzten `n` Nachrichten aus (oder alle, wenn weniger vorhanden).

## Demo im Main
- Erzeuge einen Chat.
- Füge mindestens 8 Nachrichten von mind. 3 Benutzern hinzu.
- Gib den gesamten Chat aus.
- Gib nur Nachrichten eines Benutzers aus.
- Lösche alle Nachrichten eines Benutzers.
- Gib den Chat erneut aus.
- Gib die letzten 3 Nachrichten aus.

## Optional (als zusätzliche Übung, Lösungscode nicht vorhanden)
- Suche nach Stichwort (enthält Text)
- Benutzer umbenennen (alle Nachrichten anpassen)
- Doppelte Nachrichten entfernen (Spam)
- Maximale Chatlänge (älteste entfernen, wenn > X)

