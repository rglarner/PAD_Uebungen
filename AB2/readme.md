# AB2 
# Übung 1 – Zahlen: Robuste Eingabe mit Bereichsprüfung
Projektname: AB2_Zahlen1
## Ziel
Diese Übung behandelt Eingabeschleifen, Validierung, `if/else` sowie Methoden mit Parametern und Rückgabewert.

## Auftrag
Implementieren Sie eine Methode mit folgender Signatur:

```csharp
static int ReadIntInRange(string prompt, int min, int max)
```

Die Methode soll:

- den Text `prompt` ausgeben
- eine Benutzereingabe lesen
- prüfen, ob eine ganze Zahl eingegeben wurde
- prüfen, ob die Zahl im Bereich `[min..max]` liegt
- bei Fehlern eine passende Meldung ausgeben
- erst dann zurückkehren, wenn eine gültige Eingabe erfolgt ist

## Vorgaben
- Verwenden Sie eine Schleife (`while` oder `do-while`)
- Verwenden Sie `if / else` für die Fallunterscheidungen
- Die Methode gibt ausschliesslich eine gültige Zahl zurück

## Beispiel
```csharp
int age = ReadIntInRange("Bitte Alter eingeben: ", 0, 120);
```

## Erweiterung (optional)
- Unterscheiden Sie zwischen „keine Zahl“, „zu klein“ und „zu gross“

# Übung 2 – Zahlen: Mini-Rechner mit Menü
Projektname: AB2_Zahlen2
## Ziel
Diese Übung kombiniert Menüstrukturen (`switch`), Schleifen und Methoden.

## Auftrag
Schreiben Sie ein Konsolenprogramm mit folgendem Menü:

- 1) Addieren
- 2) Subtrahieren
- 3) Multiplizieren
- 4) Dividieren
- 0) Ende

Der Benutzer wählt eine Option und gibt danach zwei Zahlen ein.

## Vorgaben
- Das Menü läuft in einer Schleife, bis `0` gewählt wird
- Jede Operation ist eine eigene Methode:

```csharp
static double Add(double a, double b)
static double Sub(double a, double b)
static double Mul(double a, double b)
static double Div(double a, double b)
```

- Division durch 0 ist nicht erlaubt

## Erweiterung (optional)
- Letztes Resultat zwischenspeichern

# Übung 3 – Zahlen: Rekursion (Quersumme oder Potenz)
Projektname: AB2_Zahlen3
## Ziel
Einführung in die Rekursion (Selbstaufruf einer Methode).

## Variante A – Quersumme
```csharp
static int DigitSum(int n)
```

### Regeln
- Basisfall: `n < 10`
- Rekursiv: letzte Ziffer + Quersumme des Rests

### Beispiele
- DigitSum(7) → 7
- DigitSum(1234) → 10

## Variante B – Potenz
```csharp
static int Power(int basis, int exponent)
```

### Regeln
- Basisfall: `exponent == 0`
- Rekursiv: `basis * Power(basis, exponent - 1)`

## Vorgaben
- Wählen Sie eine Variante
- Rekursion muss klar sichtbar sein

# Übung 4 – Strings: Vokale zählen
Projektname: AB2_Strings1
## Ziel
Schleifen über Zeichenketten und Methoden mit Rückgabewert.

## Auftrag
```csharp
static int ZähleVokale(string text)
```

Zählt die Vokale `a e i o u` (Gross- und Kleinbuchstaben).

## Beispiele
- CountVowels("Hallo") -> 2
- CountVowels("Programmieren") -> 4

## Erweiterung (optional)
- ZähleZiffern
- Zähle Leerschläge

# Übung 5 – Strings: Passwortprüfung
Projektname: AB2_Strings2
## Ziel
Validierungsschleifen und kombinierte Bedingungen.

## Auftrag
```csharp
static bool IsValidPassword(string password)
```

Ein Passwort ist gültig, wenn:

- mindestens 8 Zeichen
- mindestens eine Ziffer
- mindestens ein Grossbuchstabe

Das Hauptprogramm fragt so lange, bis das Passwort gültig ist.

## Erweiterung (optional)
- Maximal 3 Versuche erlauben
- Spezielle Zeichen erforderlich
- Ausgabe der Fehlerursachen

# Übung 6 – Strings: Rekursion – Palindrom
Projektname: AB2_Strings3
## Ziel
Rekursion mit Zeichenketten.

## Auftrag
```csharp
static bool IsPalindrome(string text)
```

## Regeln
- Basisfall: Länge 0 oder 1 → true
- Ungleiches erstes/letztes Zeichen → false
- Sonst rekursiv inneren Teil prüfen

## Beispiele
- lagerregal → true
- otto → true
- hello → false
