namespace BloodBowlGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  
            *   Blood Bowl action generator that generates a random sequence of actions you can take for your player.
            *
            *   Version 1 - randomly generates an action for the user to carry out, and a new action is generated when the user hits a key (preferably enter). 
            *   The user will determine which player (if eligible) carries out the action.
            *
            */

            Welcome();
            StartGame();

        }

        static void StartGame()
        {
            bool play = true;
            int counter = 0;
            
            while (play)
            {
                Random rng = new Random();
                int num = rng.Next(1, 5);
                
                counter++;

                switch (num)
                {
                    case 1:
                        Console.WriteLine("{0}. Move", counter);
                        break;
                    case 2:
                        Console.WriteLine("{0}. Block", counter);
                        break;
                    case 3:
                        Console.WriteLine("{0}. Blitz / Get Up", counter);
                        break;
                    case 4:
                        Console.WriteLine("{0}. Pass / Throw Team mate", counter);
                        break;
                }
                Console.ReadKey();
            }

        }

        static void Welcome()
        {
            Console.WriteLine(" ************************************************************\n");

            Console.WriteLine("   Welcome to the Blood Bowl Action Generator Version 1.0.0.");

            Console.WriteLine("\n ************************************************************");

        }
    }
}