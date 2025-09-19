using Ninjago_LA_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ninjago_LA_6
{
    public class Ninja
    {


        // Eigenschaften Ninja
        public string Name { get; set; }
        public int Hp { get; set; }
        public Waffe Waffe { get; set; }
        public Kraft Kraft { get; set; }

        public Ninja(string name, int hp, Waffe waffe, Kraft kraft)
        {
            Name = name;
            Hp = hp;
            Waffe = waffe;
            Kraft = kraft;
        }



        public void Attack(Boesewicht enemy)
        {
            int damage = Waffe.Damage + Kraft.Bonus;
            enemy.Hp -= damage;
            Console.WriteLine($"{Name} greift {enemy.Name} an und macht {damage} Schaden!");
        }


        // Ausgabe des Ninjas
        public override string ToString()
        {
            return $"{Name} (HP: {Hp}, Waffe: {Waffe.Name}, Kraft: {Kraft.Element})";
        }


    }
}


