using Ninjago_LA_6;


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






            // Ninjas erstelle
            Ninja Kai = new Ninja("Kai", 100, Schwert, Feuer);



        }
    }
}


