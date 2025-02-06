using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Xml.Serialization;
using gameslist;

internal class Program
{
    private static void Main(string[] args)
    {
        var gamesUser = new List<string>();
        string choice = null;
        

        while (true)
        {
            Console.WriteLine("Welkom bij de game library!");
            Console.WriteLine("Hierin kan je games toevoegen, games inzien, games verwijderen en games bewerken");
            Console.WriteLine("Kies een optie\n");

            // Laat menu zien
            Opties_game_list.opties();
            string userInput = Console.ReadLine();

            
            switch (userInput)
            {
                // Toevoegen
                case "1":
                    do
                    {
                        Console.WriteLine("Welke game wil je toevoegen?");
                        string game = Console.ReadLine();
                        gamesUser.Add(game);
                        Console.WriteLine($"Oke {game} is toegevoegd aan de lijst!");
                        Console.WriteLine("Wil je nog een game toevoegen? (ja/nee)");
                        choice = Console.ReadLine().ToLower();
                    } while (choice == "ja");

                    Console.WriteLine("Oke deze games zijn er toegevoegd:");

                    foreach (string gameToegevoegd in gamesUser)
                    {
                        Console.WriteLine($"{gameToegevoegd}");
                    }
                    Console.WriteLine("Druk op ENTER om door te gaan");
                    Console.ReadLine();
                    Console.Clear();
                break;

                // Games lijst inzien
                case "2":

                    Console.WriteLine("Deze games heb je toegevoegd aan jou libary:");
                    foreach (string game in gamesUser)
                    {
                        Console.WriteLine(game);
                    }
                    Console.WriteLine("Druk op ENTER om door te gaan");
                    Console.ReadLine();
                    Console.Clear();
                break;

                // Verwijderen
                case "3":
                    int count = 0;
                    Console.WriteLine("Welke game wil je verwijderen?");
                 
                    foreach (string game in gamesUser)
                    {
                        count++;
                        Console.WriteLine($"{count}: {game}");
                    }

                    // De list index begint bij 0 
                    // De gebruiker begint bij 1
                    // Dus daarom staat -1 erbij

                    int gameDeleteUser = int.Parse(Console.ReadLine()) - 1;
                    gamesUser.RemoveAt(gameDeleteUser);
                    //String gamesPrint = gamesUser[gameDeleteUser];

                    Console.WriteLine($"Oke deze game is verwijderd uit je libary.");
                    Console.WriteLine("Druk op ENTER om door te gaan");
                    Console.ReadLine();
                    Console.Clear();

                break;

                //Bewerken
                case "4":
                    Console.WriteLine("Welke games wil je bewerken?");
                    int countChange = 0;
                    foreach (string gameChange in gamesUser)
                    {
                        countChange++;
                        Console.WriteLine($"{countChange}: {gameChange}");
                    }

                    //De gebruiker begint bij 1
                    //Hij verwijdert de game wat hij wilt aanpassen
                    int gamesIndex = int.Parse(Console.ReadLine()) - 1;

                    //Hij vraagt de gebruiker om input
                    //Hij verandert de gamesIndex naar gamesNewInput
                    Console.WriteLine("Voer in wat je wilt veranderen");
                    string gamesNewInput = Console.ReadLine();
                    gamesUser[gamesIndex] = gamesNewInput;

                    Console.WriteLine($"Je hebt het verandert naar: {gamesNewInput}");
                    Console.WriteLine("Druk op ENTER om door te gaan");
                    Console.ReadLine();
                    Console.Clear();
                    

                break;

                // exit
                case "x":

                    Console.WriteLine("Houdoe! Tot de volgende keer");
                    System.Environment.Exit(1);


                break;


                default:

                    Console.WriteLine("ongeldige keuze");
                    Console.WriteLine("Druk op ENTER om door te gaan");
                    Console.ReadLine();
                    Console.Clear();

                break;
            }
        }
    }
}