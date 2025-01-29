using System.Linq.Expressions;
using gameslist;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true) 
        { 
            Console.WriteLine("Welkom bij de games library!");
            Console.WriteLine("Hierin kan je games toevoegen, games verwijderen");
            Console.WriteLine("Welke genre wil je games toevoegen? ");
            string user_genre = Console.ReadLine();
            Console.WriteLine("Je hebt gekozen voor " + user_genre);
            Console.WriteLine("Kies een optie\n");
            Opties_game_list.opties();
            string user_input = Console.ReadLine();
      
            if (user_input == "1") 
            {
                UserGames_game_list.user_games();
                Console.WriteLine("Oke hij is toegevoegd aan de lijst!");
                Thread.Sleep(1000);
                Console.Clear();


            }
            if (user_input == "2")
            {

            }
                
                    
           

            



        }

    }
}