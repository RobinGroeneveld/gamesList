using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Xml.Serialization;
using gameslist;

internal class Program
{
    private static void Main(string[] args)
    {
        var games_user = new List<string>();
        string choice = null;
        

        while (true)
        {
            Console.WriteLine("Welkom bij de games library!");
            Console.WriteLine("Hierin kan je games toevoegen, games verwijderen");
            Console.WriteLine("Kies een optie\n");

            // Laat menu zien
            Opties_game_list.opties();
            string user_input = Console.ReadLine();

            
            switch (user_input)
            {
                // Toevoegen
                case "1":
                    do
                    {
                        Console.WriteLine("welke game wil je toevoegen?");
                        string game = Console.ReadLine();
                        games_user.Add(game);
                        Console.WriteLine($"Oke {game} hij is toegevoegd aan de lijst!");
                        Console.WriteLine("wil je nog een game toevoegen?");
                        choice = Console.ReadLine();
                    } while (choice == "ja");

                    Console.WriteLine("Oke deze games zijn er toegevoegd:");
                    foreach (string game_toegevoegd in games_user)
                    {
                        Console.WriteLine($"{game_toegevoegd}");
                    }
                break;

                // games lijst inzien
                case "2":

                    Console.WriteLine("Hier zijn de games die je hebt toegevoegd:");
                    foreach (string game in games_user)
                    {
                        Console.WriteLine(game);
                    }
                    Console.WriteLine("Druk op enter om door te gaan");
                    Console.ReadLine();
                    Console.Clear();
                break;

                // verwijderen
                case "3":
                    int count = 0;
                    Console.WriteLine("Welke game wil je verwijderen?");
                    foreach (string game in games_user)
                    {
                        count++;
                        Console.WriteLine($"{count}: {game}");
                    }

                    // De list index begint bij 0 
                    // de gebruiker begint bij 1
                    // dus daarom staat -1 erbij

                    int game_delete_user = int.Parse(Console.ReadLine()) - 1;
                    games_user.RemoveAt(game_delete_user);
                    Console.WriteLine($"Deze game is verwijderd uit je libary.");
                    
                break;
                case "4":
                    Console.WriteLine("Welke games wil je bewerken?");
                    int count2 = 0;
                    foreach (string game_change in games_user)
                    {
                        count2++;
                        Console.WriteLine($"{count2}: {game_change}");
                    }
                    int games_nieuw = int.Parse(Console.ReadLine()) - 1;
                    games_change_user = games_user.IndexOf

                    break;

                // exit
                case "x":

                    Console.WriteLine("Houdoe! Tot de volgende keer");
                    System.Environment.Exit(1);


                break;


                default:

                    Console.WriteLine("ongeldige keuze");
                    
                break;
            }
        }
    }
}