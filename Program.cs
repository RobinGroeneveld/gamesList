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
                games_user.Append(game);
                Console.WriteLine($"Oke {game} hij is toegevoegd aan de lijst!");
                Console.WriteLine("wil je nog een game toevoegen?");
                string game_input = Console.ReadLine();
                games_user.Add(game);
                
                Thread.Sleep(2000);
                Console.Clear();


            }
            else if (user_input == "2")
            {
                Console.WriteLine("Hier zijn de games die je hebt toegevoegd");
                Console.WriteLine(games_user);
                Thread.Sleep(2000);
                Console.Clear();

            }
            else if (user_input == "3")
            {
                
                Console.WriteLine("Welke game wil je verwijderen");

                int verwijderen = Console.Read();
                foreach ( verwijderen in games_user)
                {
                    Console.WriteLine(verwijderen);
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