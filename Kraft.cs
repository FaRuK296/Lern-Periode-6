using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninjago_LA_6
{
    public class Kraft
    {

        // Eigenschaften Kraft
        public string Element { get; set; }
        public int Bonus { get; set; }



        public Kraft (string name, int bonus)
        {
            Element = name;
            Bonus = bonus;
        }

        // Ausgabe der Kraft
        public override string ToString()
        {
            return $"{Element} Bonusschaden: {Bonus}";
        }

    }
    }

