
using Exercice_Pokemon;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;


Console.WriteLine("Bonjour et bienvenu dans le monde des Pokémons ! Quel starter choisirez-vous pour débuter votre aventure ?");
Console.WriteLine(" ");
Console.WriteLine("     - Salamèche");
Console.WriteLine("     - Carapuce");
Console.WriteLine("     - Bulbizarre");
Console.WriteLine(" ");
var ChoiceOne = Console.ReadLine();


switch (ChoiceOne)
{
	case "Salamèche":
        Charmander charmander = new Charmander();
		Console.WriteLine("Vous avez choisi Salamèche, pokemon de type feu !");
        Console.WriteLine(" ");
        Console.WriteLine("----------------------------------------------------------------------------------------------");
        Console.WriteLine(" ");
        break;

    case "Carapuce":
        Squirtle squirtle = new Squirtle();
        Console.WriteLine("Vous avez choisi Carapuce, pokemon de type eau !");
        Console.WriteLine(" ");
        Console.WriteLine("----------------------------------------------------------------------------------------------");
        Console.WriteLine(" ");
        break;

    case "Bulbizarre":
        Bulbasaur bulbasaur = new Bulbasaur();
        Console.WriteLine("Vous avez choisi Bulbizarre, pokemon de type plante !");
        Console.WriteLine(" ");
        Console.WriteLine("----------------------------------------------------------------------------------------------");
        Console.WriteLine(" ");
        break;

    default:
		Console.WriteLine("Vous n'avez pas choisi de starter, l'aventure ne peut pas commencer ...");
        Console.WriteLine(" ");
        break;

}

/* Pour initialiser l'interface des actions */

bool game = true;
while (game)
{
    Console.WriteLine("Plusieurs options s'offrent désormais à vous, dresseur !");
    Console.WriteLine(" ");
    Console.WriteLine("Vous avez le choix entre :");
    Console.WriteLine("     - Combattre");
    Console.WriteLine("     - Soigner");
    Console.WriteLine("     - Statistiques");
    Console.WriteLine("     - Quitter");
    Console.WriteLine(" ");
    var ChoiceTwo = Console.ReadLine();


    /* Choix d'un pokemon sauvage aléatoire */

    var random = new Random();
    var list = new List<object> {new Pikachu(), new Vulpix(), new Oddish()};
    int index = random.Next(list.Count);
    var randomizerChoice = list[index];



    switch (ChoiceTwo)
    {

        /* La section "Combattre" n'est PAS fonctionnelle, 
         * cependant je laisse quand même ci-dessous quelques exemples de code que j'aurai inséré en cas de bon fonctionnement,
         * afin de montrer que j'aurai sû le faire. */

        /* En choisissant Salamèche comme Pokemon de départ : */
        /* FONCTIONNEL Pour le heal en combat, exemple : new Charmander().HealPotion(); */
        /* FONCTIONNEL Pour recevoir des dégats en combat, exemple : new Charmander().ReceiveDmg(new Pikachu().Atk); */
        /* FONCTIONNEL Pour l'xp en combat, exemple : new Charmander().GetExperiences(); */
        /* FONCTIONNEL Pour capturer le pokemon sauvage en combat, exemple : new Charmander().Catch(new Pikachu().Pv, new Pikachu().PvMax); */

        /* Choix pour lancer un combat */

        case "Combattre":

            bool fight = true;
            while (fight)
            {

                if (randomizerChoice == new Pikachu())
                {
                    Console.WriteLine("Un Pikachu sauvage vous attaque !");
                    Console.WriteLine(" ");

                    if (ChoiceOne == "Salamèche")
                    {
                        Console.WriteLine("Vous envoyez Salamèche au combat !");
                        Console.WriteLine(" ");

                    }
                    else if (ChoiceOne == "Carapuce")
                    {
                        Console.WriteLine("Vous envoyez Carapuce au combat !");
                        Console.WriteLine(" ");
                    }
                    else if (ChoiceOne == "Bulbizarre")
                    {
                        Console.WriteLine("Vous envoyez Bulbizarre au combat !");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("Vous n'avez pas de pokemon apte au combat.");
                        break;
                    }

                }
                else if (randomizerChoice == new Vulpix())
                {
                    Console.WriteLine("Un Goupix sauvage vous attaque !");
                    Console.WriteLine(" ");

                    if (ChoiceOne == "Salamèche")
                    {
                        Console.WriteLine("Vous envoyez Salamèche au combat !");
                        Console.WriteLine(" ");

                    }
                    else if (ChoiceOne == "Carapuce")
                    {
                        Console.WriteLine("Vous envoyez Carapuce au combat !");
                        Console.WriteLine(" ");
                    }
                    else if (ChoiceOne == "Bulbizarre")
                    {
                        Console.WriteLine("Vous envoyez Bulbizarre au combat !");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("Vous n'avez pas de pokemon apte au combat.");
                        break;
                    }

                }
                else if (randomizerChoice == new Oddish())
                {
                    Console.WriteLine("Un Mystherbe sauvage vous attaque !");
                    Console.WriteLine(" ");

                    if (ChoiceOne == "Salamèche")
                    {
                        Console.WriteLine("Vous envoyez Salamèche au combat !");
                        Console.WriteLine(" ");

                    }
                    else if (ChoiceOne == "Carapuce")
                    {
                        Console.WriteLine("Vous envoyez Carapuce au combat !");
                        Console.WriteLine(" ");
                    }
                    else if (ChoiceOne == "Bulbizarre")
                    {
                        Console.WriteLine("Vous envoyez Bulbizarre au combat !");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("Vous n'avez pas de pokemon apte au combat.");
                        break;
                    }
                    break;

                }
                else
                {
                    Console.WriteLine("Erreur System.");
                    fight = false;
                    break;
                }
                
            }
            break;



        /* Choix pour soigner le starter hors combat */

        case "Soigner":
            if (ChoiceOne == "Salamèche" && new Charmander().Pv < new Charmander().PvMax)
            {
                new Charmander().Pv = new Charmander().PvMax;
                Console.WriteLine("Votre Pokémon est maintenant en pleine forme !");
                Console.WriteLine(" ");

            }
            else if (ChoiceOne == "Carapuce" && new Squirtle().Pv < new Squirtle().PvMax)
            {
                new Squirtle().Pv = new Squirtle().PvMax;
                Console.WriteLine("Votre Pokémon est maintenant en pleine forme !");
                Console.WriteLine(" ");

            }
            else if (ChoiceOne == "Bulbizarre" && new Bulbasaur().Pv < new Bulbasaur().PvMax)
            {
                new Bulbasaur().Pv = new Bulbasaur().PvMax;
                Console.WriteLine("Votre Pokémon est maintenant en pleine forme !");
                Console.WriteLine(" ");

            }
            else
            {
                Console.WriteLine("Il n'est pas nécessaire de soigner votre Pokémon !");
                Console.WriteLine(" ");
                break;
            }
            break;



        /* Choix pour voir les stats */

        case "Statistiques":
            if (ChoiceOne == "Salamèche")
            {
                Console.WriteLine("PV Max : " + new Charmander().PvMax);
                Console.WriteLine("PV Actuels : " + new Charmander().Pv);
                Console.WriteLine("Attaque : " + new Charmander().Atk);
                Console.WriteLine("Défense : " + new Charmander().Def);
                Console.WriteLine("Vitesse : " + new Charmander().Spd);
                Console.WriteLine(" ");

            } else if (ChoiceOne == "Carapuce")
            {
                Console.WriteLine("PV Max : " + new Squirtle().PvMax);
                Console.WriteLine("PV Actuels : " + new Squirtle().Pv);
                Console.WriteLine("Attaque : " + new Squirtle().Atk);
                Console.WriteLine("Défense : " + new Squirtle().Def);
                Console.WriteLine("Vitesse : " + new Squirtle().Spd);
                Console.WriteLine(" ");

            } else if (ChoiceOne == "Bulbizarre")
            {
                Console.WriteLine("PV Max : " + new Bulbasaur().PvMax);
                Console.WriteLine("PV Actuels : " + new Bulbasaur().Pv);
                Console.WriteLine("Attaque : " + new Bulbasaur().Atk);
                Console.WriteLine("Défense : " + new Bulbasaur().Def);
                Console.WriteLine("Vitesse : " + new Bulbasaur().Spd);
                Console.WriteLine(" ");
            } else
            {
                break;
            }
            break;



        /* Choix pour quitter l'interface */

        case "Quitter":
            Console.WriteLine("Vous décidez de quitter la partie : Sauvegarde en cours ... Merci d'avoir joué !");
            Console.WriteLine(" ");
            break;



        /* Default pour quitter l'interface si mauvaise saisie */

        default:
            Console.WriteLine("Vous n'avez pas sélectionner une action à effectuer, la partie se termine ...");
            Console.WriteLine(" ");
            break;
    }


    Console.WriteLine("Voulez-vous continuer la partie (Oui ou Non) ?");
    Console.WriteLine(" ");
    var ChoiceThree = Console.ReadLine();

    switch (ChoiceThree)
    {

        /* Choix pour continuer et revenir à l'interface des actions */

        case "Oui":
            Console.WriteLine("Dans ce cas, retour à l'interface des actions.");
            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine(" ");
            break;

        /* Choix pour arrêter et quitter le jeu */

        case "Non":
            Console.WriteLine("Le jeu s'arrête ...");
            game = !game;
            break;

        /* Default pour boucler tant que la saisie est incorrecte */

        default:
            Console.WriteLine("Saisie incorrecte !");
            Console.WriteLine(" ");
            break;
    }

}