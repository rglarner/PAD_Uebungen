# AB4 
# Übung 1 – 2D-Array: Zeichenfläche mit Figuren

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

