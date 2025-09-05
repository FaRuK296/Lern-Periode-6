using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ninjago_LA_6
{
    public class Waffe
    {


        public string Name { get; set; }
        public int Damage { get; set; }

        public Waffe(string name, int damage)
        {

            Name = name;
            Damage = damage;
        }

        public override string ToString()
        {

            return $"{Name} (Schaden: {Damage})";


        }
    }
}


