using System.Linq.Expressions;
using gameslist;


internal class Program
{
    private static void Main(string[] args)
    {
        string game = string.Empty;
        

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
                game = Console.ReadLine();
                Console.WriteLine($"Oke {game} hij is toegevoegd aan de lijst!");
                Thread.Sleep(2000);
                Console.Clear();


            }
            else if (user_input == "2")
            {
                Console.WriteLine("Hier zijn de games die je hebt toegevoegd");
                Console.WriteLine(game);
                Thread.Sleep(2000);
                Console.Clear();

            }
            else if (user_input == "3")
            {
                Console.WriteLine("Welke game wil je verwijderen?");
                string game_verwijderen = Console.ReadLine();
                game = game.Replace(game_verwijderen, "");
                Console.WriteLine($"Oke {game_verwijderen} is verwijderd uit de lijst!");
                Thread.Sleep(3000);
                Console.Clear();
            }
            else if (user_input == "x")
            {
                Console.WriteLine("Houdoe! Tot de volgende keer");
                break;
            }


        }

    }
}