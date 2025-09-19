# Lern-Periode 6

22.8 bis 19.9.2024

## Grob-Planung

1. Für welches der drei Projekte haben Sie sich entschieden?
   LEGO NINJAGO Spiel

2. Wie passen Sie dieses Projekt gem. Ihrer Vorlieben an?
   Es ist eine Vorliebe, da ich als Kind oft Lego Ninjago gespielt oder geschaut habe.
   
3. Erklären Sie Ihre Projekt-Idee in einem Satz, als müssen Sie einem Satz, als müssen Sie einen Investor davon überzeugen.
   Ein Ninjago Spiel, indem man verschiedene Ninjas mit verschiedenen Waffen und Kräften auswählen kann um gegen Verschiedene Gegner zu kämpfen.

## 22.8

- [x] Erstellen Sie ein Projekt im VS und beginnen Sie mir ersten Code-Skizzen. Das ist wichtig, Sie müssen heute bereits schon C#-Code hochladen!
- [x] Schreiben Sie eine Liste, welche Klassen und Objekte es braucht, und wie diese miteinander interagieren. Das Format ist Ihnen freigestellt, aber Sie müssen es auch bereits heute auf github laden.

![WhatsApp Bild 2025-08-22 um 11 39 14_4501d9a8](https://github.com/user-attachments/assets/95df0192-dee7-46d5-a6a8-fbed3edd25d8)



- [x] Arbeitspaket 3 (Falls Sie den maker space besuchen, dann dürfen Sie diesen Punkt löschen. Ansonsten können Sie hier mit dem Coden beginnen, nachdem Sie sich ganz klar überlegt haben, was Ihr erster Schritt ist und den hier als AP festgehalten haben.)

Heute habe Ich einen Plan mit Stift und Papier erstellt. In diesem Plan habe ich mir notiert, welche Klassen und Objekte mein Programm haben soll und was deren Beziehungen sind. Danach habe ich angefangen die Klassen in Visual Studio zu erstellen.


## 29.8

- [x] Alle Klassen erstellen
- [x] Objekte erstellen
- [x] Notitzen machen was ganz genau im Spiel passieren soll (offline)

![WhatsApp Bild 2025-08-29 um 10 18 05_a683e70f](https://github.com/user-attachments/assets/82cd3e3f-9ae8-4f3f-9580-81a7590c1bf3)


Heute habe ich begonnen, die Klassen fuer mein Ninjago-Spiel in C# zu erstellen. Ich habe die Ninja-Klasse programmiert und dabei die wichtigsten Eigenschaften (Name, HP, Waffe, Kraft) hinzugefuegt. Ausserdem habe ich mir überlegt, wie die Attacke-Methode aussehen soll, damit ein Ninja gegen einen Gegner kämpfen kann. Die anderen Klassen (Waffe, Kraft, Boesewicht, Arena) habe ich zwar schon als Dateien angelegt, aber noch nicht mit Inhalt gefüllt. Somit konnte ich heute die erste funktionsfähige Klasse (Ninja.cs) fertigstellen.

## 5.9

- [x] Waffe.cs und Kraft.cs mit Inhalt füllen
- [x] Boesewicht.cs erstellen, Bösewichte klarer definieren
- [x] Test Kampf programmieren, Ninja gegen Bösewicht kämpfen lassen
- [x] OFFLINE: Klassendiagramm auf Papier skizzieren (mit Beziehungen zwischen Ninja, Waffe, Kraft, Boesewicht, Arena)

Heute habe ich meine Klassen fertig gemacht. Ich habe Waffe.cs und Kraft.cs mit Inhalt gefüllt und Boesewicht.cs erstellt. Auf Papier habe ich eine Skizze ertsellt auf der man die Beziehungen der 4 Klassen ablesen kann. Ich habe als Beispiel einen Ninja genommen (Kai). Als Bösewicht Gamadon. Ich habe die Klasse Arena gelöscht, weil sie für mein Projekt nicht unbedingt gepasst hat. Den Testkampf habe ich nicht programmiert, weil ich gemerkt habe dass es im Moment noch nicht so viel Sinn macht. Danach war ich Fertig und habe ich angefangen im Programm.cs, mehrere Ninjas, Waffen, Kräfte und Bösewichte zu erstellen, damit ich später richtige Kämpfe machen kann. Ich konnte bis jetzt die Waffen und eine Kraft erstellen.

![WhatsApp Bild 2025-09-05 um 12 20 56_d17c96ae](https://github.com/user-attachments/assets/0fe04027-4861-4918-8250-76a662f07454)


## 12.9

- [x] Die reslichen Objekte: Ninjas, Krafte, Bösewichte in Programm.cs erstellen
- [x] ToString Methoden verbessern: Alle Klassen so erweitern, dass sie sich schön in der Konsole ausgeben (z. B. Name, HP, Schaden).
- [x] Kurzen Testlauf machen: Einmal alle Ninjas und Bösewichte ausgeben, um zu prüfen ob alles richtig erstellt wurde
- [x] Projekt aufräumen: Kommentare hinzufügen und unnötigen Code löschen, damit alles übersichtlich ist

Heute habe ich zuerst alle Objekte fertig erstellt. Danach habe ich die ToString Methoden überprüft damit eine saubere Ausgabe erscheint.  Ausserdem habe ich den Code besser kommentiert, für eine bessere Übersicht und Verständnis. Danach habe ich im Program.cs einen kurzen Testlauf eingebaut, bei dem alle Ninjas und Bösewichte in der Konsole ausgegeben werden. So konnte ich überprüfen, ob sie richtig erstellt wurden und ob die ToString Methoden richtig waren. Ich habe noch ein Screenshot von der Ausgabe gemacht um es hier hochzuladen.

<img width="1745" height="382" alt="Screenshot 2025-09-12 120223" src="https://github.com/user-attachments/assets/b66a99dc-d6b2-42d1-9bcd-245e901d6bff" />


## 19.9

- [x] While Schleife einbauen, damit der Kampf so lange läuft, bis einer 0 HP hat
- [x] Ein Auswahl Menü erstellen: Benutzer kann Ninja und Bösewicht selbst auswählen
- [x] Ausgabe schöner machen: Nach jedem Angriff eine kurze Pause (z. B. Console.ReadKey()), damit man den Kampf Schritt für Schritt verfolgen kann
- [x] Siegernachrichten eingbauen: Zum Beispiel Kai hat seinen Gegner gedemütigt! usw.

Heute habe ich ein kleines Auswahlmenü gemacht, wo man zuerst einen Ninja und dann einen Bösewicht auswählen kann. Danach kämpfen die beiden so lange, bis einer kein HP mehr hat. Am Ende zeigt das Programm wer gewonnen hat. So ist es jetzt mehr wie ein kleines Spiel. Ich möchte es auf nächstes mal erweitern damit es anschaulicher wird.

## 19.10

- [ ] Das Spiel erweitern: mehr Möglichkeiten unf Spielvariationen ertsellen z.B Heiltränke
- [ ] Code aufräumen: Kommentare in allen Klassen ergänzen (z. B. was macht Attack, was macht ToString)
- [ ] Ausgabe verbessern: Nach jedem Angriff die HP schön anzeigen (übersichtlich)





