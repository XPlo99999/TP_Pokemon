using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercice_Pokemon
{
    internal class Pokemons
    {
        public string Name {get; set;}
        public int Pv {get; set;}
        public int Atk {get; set;}
        public int Def {get; set;}
        public int Spd {get; set;}
        public int Exp {get; set;}
        public int PvMax {get; set;}


        public Pokemons()
        {
        }

        public Pokemons(string name, int pv, int atk, int def, int speed, int xp, int pvmax)
        {
            Name = name;
            Pv = pv;
            Atk = atk;
            Def = def;
            Spd = speed;
            Exp = xp;
            PvMax = pvmax;
        }



        /* Méthode pour soigner en combat */
        public void HealPotion()
        {
            if (Pv < PvMax)
            {
                var BasicPotion = 20;
                Pv = Pv + BasicPotion;

                if (Pv > PvMax)
                {
                    Pv = PvMax;

                    Console.WriteLine("Votre pokemon a été soigné de " + BasicPotion + "PV. Il a maintenant " + Pv + "/" + PvMax + " Pv.");
                }

            }
            else
            {
                Console.WriteLine("Votre pokemon a déjà tout ses PV !");
            }

        }



        /* Méthode pour achever une partie suite à un échec */
        public void GameOver()
        {
            Pv = 0;
            Console.WriteLine("GAME OVER : Votre pokemon n'a plus de PV, il est mis hors combat !");
            bool game = false;
        }



        /* Méthode pour recevoir des dégats */
        public void ReceiveDmg(int Atk)
        {
            var ChocAbsorbtion = Atk / 3; /* Ne sachant pas comment les calcules sont fait dans pokemon */
            Pv = Pv - ChocAbsorbtion;
            Console.WriteLine("Votre pokemon reçoit " + ChocAbsorbtion + " points de dégâts !");

            if (Pv <= 0)
            {
                GameOver();
            }
            else
            {
                Console.WriteLine("Il lui reste " + Pv + " PV.");
            }
        }



        /* Méthode pour le gain d'xp */
        public void GetExperiences()
        {
            Exp++;

            if (Exp == 4)
            {
                Pv = Pv + 2;
                Atk = Atk + 2;
                Def = Def + 2;
                Spd = Spd + 2;
                PvMax = PvMax + 2;
                Console.WriteLine("Votre pokémon a gagné un niveau !");

            } else
            {
                Console.WriteLine("Votre pokémon ne peut pas encore gagner un niveau !");
            }
        }



        /* Méthode pour la capture de pokemon sauvage */

        public void Catch(int Pv, int PvMax)
        {
            /* Pour simuler le calcul du combat, il suffit de modifier la valeur des Pv de la classe Pikachu */
            int percentage = (int)Math.Round(((double)Pv / (double)PvMax) * 100);
            Console.WriteLine(percentage + " % de PV restants");
            Console.WriteLine("Vous lancer une pokeball ! Capture en cours...");

            var random = new Random();
            var intList = new List<int> { 1, 2, 3 };
            int intIndex = random.Next(intList.Count);
            var intRandomChoice = intList[intIndex];

            if (percentage >= 85)
            {
                Console.WriteLine("Ah ! Le pokemon est sorti de la pokeball !!");

            } else if (percentage >= 50 && percentage < 85)
            {
                if (intRandomChoice == 2)
                {
                    Console.WriteLine("Vous avez réussi à capturer le pokemon sauvage, Félicitation !");

                } else
                {
                    Console.WriteLine("Ah ! Le pokemon est sorti de la pokeball !!");
                }

            } else if (percentage >= 20 && percentage < 50)
            {
                if (intRandomChoice == 1 || intRandomChoice == 2)
                {
                    Console.WriteLine("Vous avez réussi à capturer le pokemon sauvage, Félicitation !");
                }
                else
                {
                    Console.WriteLine("Ah ! Le pokemon est sorti de la pokeball !!");
                }
            }
            else if (percentage < 20)
            {
                Console.WriteLine("Vous avez réussi à capturer le pokemon sauvage, Félicitation !");
            }
            else
            {
                Console.WriteLine("La capture à échouée !");
            }
        }

    }
}
