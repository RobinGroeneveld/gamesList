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
            Console.WriteLine("Wil je ook een genre toevoegen?");
            string genre_input = Console.ReadLine();
            if (genre_input == "ja")
            {
                Console.WriteLine("welke genre wil je toevoegen?");
                string genre_input2 = Console.ReadLine();

            }
            else if (genre_input == "nee")
            {
                Console.WriteLine("druk op ENTER om door te gaan");
                Console.ReadLine();
                
            }

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
                        Console.WriteLine($"{game_toegevoegd}\n");
                    }
                }
                else if (choice == "ja")
                {
                    Console.WriteLine("Oke welke game wil je nog toevoegen?");
                    string user_input_game = Console.ReadLine();
                    games_user.Add(user_input_game);
                    Console.WriteLine("Druk op enter om door te gaan");
                    Console.ReadLine();

                }
            }
            else if (user_input == "2")
            {
                Console.WriteLine("Hier zijn de games die je hebt toegevoegd:");
                foreach (string game in games_user)
                {
                    Console.WriteLine(game);
                }
                Console.WriteLine("Druk op enter om door te gaan");
                Console.ReadLine();
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
                int game_delete_user = int.Parse(Console.ReadLine()) - 1;
                games_user.RemoveAt(game_delete_user);
                Console.WriteLine($"Deze game is verwijderd uit je libary {games_user}");

            }
            else if (user_input == "x")
            {
                Console.WriteLine("Houdoe! Tot de volgende keer");
                break;
            }
        }
    }
}