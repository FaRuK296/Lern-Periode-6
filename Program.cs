using Ninjago_LA_6;
using System.Diagnostics.Metrics;


namespace Ninjago_LA_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Waffen erstellen
            Waffe Schwert = new Waffe("Schwert", 30);
            Waffe Nunchaku = new Waffe("Nunchaku", 15);
            Waffe Shuriken = new Waffe("Shuriken", 20);
            Waffe Sense = new Waffe("Sense", 25);

            // Kräfte erstellen
            Kraft Feuer = new Kraft("Feuer", 7);
            Kraft Blitz = new Kraft("Blitz", 6);
            Kraft Eis = new Kraft("Eis", 5);
            Kraft Erde = new Kraft("Erde", 4);

            // Bösewichte erstellen
            Boesewicht LordGarmadon = new Boesewicht("Lord Garmadon", 100, 35);
            Boesewicht Pythor = new Boesewicht("Pythor", 100, 40);
            Boesewicht Chen = new Boesewicht("Chen", 100, 30);

            // Ninjas erstellen
            Ninja Kai = new Ninja("Kai", 100, Schwert, Feuer);
            Ninja Jay = new Ninja("Jay", 100, Nunchaku, Blitz);
            Ninja Zane = new Ninja("Zane", 100, Shuriken, Eis);
            Ninja Cole = new Ninja("Cole", 100, Sense, Erde);




            // Listen für Auswahl
            List<Ninja> ninjas = new List<Ninja> { Kai, Jay, Zane, Cole };
            List<Boesewicht> boesewichte = new List<Boesewicht> { LordGarmadon, Pythor, Chen };

            // Auswahl
            Ninja spieler = Waehle(ninjas, "Wähle deinen Ninja:");
            Boesewicht gegner = Waehle(boesewichte, "Wähle den Bösewicht:");

            // Kampf
            Console.Clear();
            Console.WriteLine($"Kampf: {spieler.Name} vs. {gegner.Name}\n");

            int runde = 1;
            while (spieler.Hp > 0 && gegner.Hp > 0)
            {
                Console.WriteLine($"-- Runde {runde} --");
                Console.Write("Enter = Angriff, q = beenden: ");
                var key = Console.ReadKey(); Console.WriteLine();
                if (key.KeyChar == 'q' || key.KeyChar == 'Q') break;

                spieler.Attack(gegner);
                if (gegner.Hp > 0) gegner.Attack(spieler);

                Console.WriteLine($"{spieler.Name} HP: {spieler.Hp} | {gegner.Name} HP: {gegner.Hp}\n");
                runde++;
            }

            // Sieger
            if (spieler.Hp <= 0 && gegner.Hp <= 0) Console.WriteLine("Unentschieden!");
            else Console.WriteLine(spieler.Hp > 0 ? $"{spieler.Name} gewinnt!" : $"{gegner.Name} gewinnt!");
            Console.ReadLine();
        }

        // Hilfsmethode für Auswahl
        static T Waehle<T>(List<T> liste, string titel)
        {
            while (true)
            {
                Console.WriteLine(titel);
                for (int i = 0; i < liste.Count; i++)
                    Console.WriteLine($"{i + 1}) {liste[i]}");
                Console.Write("Nummer: ");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int n) && n >= 1 && n <= liste.Count)
                    return liste[n - 1];
                Console.WriteLine("Ungültig. Nochmal.\n");





            }
        }
    }
}

