# PAD Übungen
Dieses Repository enthält Übungen zum Modul PAD in C#. Es ist als Zusatzmaterial für die Vorlesung gedacht. Ich empfehle, die Übungen selbständig und ohne KI Hilfe zu lösen.

# AB1 (Projektname: StringsUndZahlen)
## Übung 1 – Begrüssungsnachricht formatieren
**Thema:** Zeichenketten (Strings), Verkettung, einfache Variablen

### Aufgabe
Schreiben Sie ein Konsolenprogramm in C#, das

1. den Vornamen einer Person einliest,
2. den Nachnamen einer Person einliest,
3. eine Begrüssungsnachricht in der folgenden Form ausgibt:

> Hallo <Vorname> <Nachname>, willkommen im Modul PAD!

#### Anforderungen
- Verwenden Sie sinnvolle, gut lesbare Variablennamen (Clean Code).
- Nutzen Sie zur Zusammensetzung der Ausgabezeichenkette die String-Verkettung mit `+`.
- Es werden keine Kontrollstrukturen (z. B. `if`, `for`, `while`, `switch`) verwendet.

#### Beispiel
**Eingabe:**
- Vorname: `Anna`
- Nachname: `Meier`

**Ausgabe:**
`Hallo Anna Meier, willkommen im Modul PAD!`

## Übung 2 – Länge einer Zeichenkette bestimmen
**Thema:** Strings, Eigenschaft `Length`, einfache Variablen

### Aufgabe
Schreiben Sie ein Konsolenprogramm in C#, das

1. einen beliebigen Text (Zeichenkette) von der Konsole einliest,
2. die Anzahl Zeichen in diesem Text bestimmt,
3. das Resultat in folgendem Format ausgibt:

> Der Text hat X Zeichen.

#### Anforderungen
- Verwenden Sie die Eigenschaft `Length` des String-Datentyps.
- Verwenden Sie sinnvolle Variablennamen.
- Es werden keine Kontrollstrukturen verwendet.

#### Beispiel
**Eingabe:**
`Hallo Welt`

**Ausgabe:**
`Der Text hat 10 Zeichen.`

## Übung 3 – Die ersten drei Zeichen ausgeben
**Thema:** Strings, Indexzugriff, Eigenschaft `Length`

### Aufgabe
Schreiben Sie ein Konsolenprogramm in C#, das

1. einen Text von der Konsole einliest,
2. die ersten drei Zeichen dieses Textes ausliest,
3. diese Zeichen in einer Zeile wie folgt ausgibt:

> 1: <erstes Zeichen>, 2: <zweites Zeichen>, 3: <drittes Zeichen>

#### Vereinfachende Annahme
- Sie dürfen davon ausgehen, dass der eingegebene Text **mindestens 3 Zeichen** lang ist.
- Es sind **keine** Prüfungen oder Fehlermeldungen nötig.

#### Anforderungen
- Greifen Sie über den Indexoperator `[]` auf einzelne Zeichen zu (`text[0]`, `text[1]`, `text[2]`).
- Verwenden Sie sinnvolle Variablennamen.
- Es werden keine Kontrollstrukturen verwendet.

#### Beispiel
**Eingabe:**
`Hallo`

**Ausgabe:**
`1: H, 2: a, 3: l`

## Übung 4 – Durchschnitt von drei Zahlen
**Thema:** numerische Datentypen, arithmetische Operatoren, implizite und explizite Konvertierung

### Aufgabe
Schreiben Sie ein Konsolenprogramm in C#, das

1. drei Zahlen von der Konsole einliest,
2. die Summe dieser drei Zahlen berechnet,
3. den Durchschnitt
   - einmal als `double`
   - und einmal als `int` (mit expliziter Konvertierung) berechnet,
4. alle Resultate verständlich ausgibt.

#### Anforderungen
- Verwenden Sie geeignete Datentypen, z. B. `double` für die Eingaben und die Durchschnittsberechnung.
- Bilden Sie den Durchschnitt als `double` mit normaler Division.
- Wandeln Sie den Durchschnitt anschliessend **explizit** in einen `int` um (Casting).
- Es werden keine Kontrollstrukturen verwendet.

#### Beispiel (mögliche Ausgabe)
Bei Eingaben `3`, `4`, `5`:

- Summe: `12`
- Durchschnitt (double): `4`
- Durchschnitt (int): `4`
