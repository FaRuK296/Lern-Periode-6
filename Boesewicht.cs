using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ninjago_LA_6
{
    public class Boesewicht
    {
        public string Name { get; set; }
        public int Hp {  get; set; }
        public int AttackPower  { get; set; }

        public Boesewicht(string name, int hp, int attackPower)
        {
            Name = name;
            Hp = hp;
            AttackPower = attackPower; }

        public void Attack(Ninja ninja)
        {
            ninja.Hp -= AttackPower;
            Console.WriteLine($"{Name} greift {ninja.Name} an und macht {AttackPower} Schaden");
        }


        public override string ToString()
        {
            return $"{Name} (HP: {Hp}, Angriff: {AttackPower})";
        }
       
       }
    }
