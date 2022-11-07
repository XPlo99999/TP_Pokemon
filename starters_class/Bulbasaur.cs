using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercice_Pokemon
{
    internal class Bulbasaur : Pokemons
    {
        public Bulbasaur()
        {
            Name = "Bulbasaur";
            Pv = 45;
            Atk = 49;
            Def = 49;
            Spd = 45;
            Exp = 0;
            PvMax = 45;
        }
    }
}
