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




            // Testlauf Ausgabe Ninjas und Bösewichte

            Console.WriteLine("Alle Ninjas:");
            Console.WriteLine(Kai);       
            Console.WriteLine(Jay);       
            Console.WriteLine(Zane);      
            Console.WriteLine(Cole);

            Console.WriteLine();

            Console.WriteLine("Alle Bösewichte:");
            Console.WriteLine(LordGarmadon);  
            Console.WriteLine(Pythor); 
            Console.WriteLine(Chen);          
        }
    }
}
