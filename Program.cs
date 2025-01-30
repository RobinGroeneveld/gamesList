using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using gameslist;

internal class Program
{
    private static void Main(string[] args)
    {
        var games_user = new List<string>();

        while (true)
        {
            Console.WriteLine("Welkom bij de games library!");
            Console.WriteLine("Hierin kan je games toevoegen, games verwijderen");

            Console.WriteLine("Kies een optie\n");
            Opties_game_list.opties();
            string user_input = Console.ReadLine();

            if (user_input == "1")
            {
                Console.WriteLine("welke game wil je toevoegen?");
                string game = Console.ReadLine();
                games_user.Add(game);
                Console.WriteLine($"Oke {game} hij is toegevoegd aan de lijst!");
                Console.WriteLine("wil je nog een game toevoegen?");
                string choice = Console.ReadLine();

                if (choice == "nee")
                {
                    Console.WriteLine("Oke deze games zijn er toegevoegd:");
                    foreach (string game_toegevoegd in games_user)
                    {
                        Console.WriteLine(game_toegevoegd);
                    }
                }
                else if (choice == "ja")
                {
                    Console.WriteLine("Oke welke game wil je nog toevoegen?");
                    Thread.Sleep(2000);
                    string user_input_game = Console.ReadLine();
                    games_user.Add(user_input_game);
                }
            }
            else if (user_input == "2")
            {
                Console.WriteLine("Hier zijn de games die je hebt toegevoegd:");
                foreach (string game in games_user)
                {
                    Console.WriteLine(game);
                }
                Thread.Sleep(2000);
                Console.Clear();
            }
            else if (user_input == "3")
            {
                int count = 0;
                Console.WriteLine("Welke game wil je verwijderen?");
                foreach (string game in games_user)
                {
                    count++;
                    Console.WriteLine($"{count}: {game}");
                }
                string game_delete_user = Console.ReadLine();
                if (game_delete_user == "1")
                {
                    games_user.Remove(game_delete_user);
                    Console.WriteLine($"Deze game is verwijderd uit je libary {game_delete_user}");
                }
            }
            else if (user_input == "x")
            {
                Console.WriteLine("Houdoe! Tot de volgende keer");
                break;
            }
        }
    }
}