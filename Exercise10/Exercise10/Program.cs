namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************");
            Console.WriteLine("Menu: ");
            Console.WriteLine("1 - New Game ");
            Console.WriteLine("2 - Load Game ");
            Console.WriteLine("3 - Options ");
            Console.WriteLine("4 - Quit ");
            Console.WriteLine("**************");
            int gameMenu = int.Parse(Console.ReadLine());

            while (gameMenu >= 1 || gameMenu <= 4)
            {
                if (gameMenu == 1)
                {
                    Console.WriteLine("Starting new game ");
                }
                if (gameMenu == 2)
                {
                    Console.WriteLine("Loading game ");
                }
                if (gameMenu == 3)
                {
                    Console.WriteLine("Audio");
                    Console.WriteLine("Hud");
                    Console.WriteLine("Controles");
                }
                if (gameMenu == 4)
                {
                    // quitting the game  
                }
                Console.WriteLine("**************");
                Console.WriteLine("Menu: ");
                Console.WriteLine("1 - New Game ");
                Console.WriteLine("2 - Load Game ");
                Console.WriteLine("3 - Options ");
                Console.WriteLine("4 - Quit ");
                Console.WriteLine("**************");
                int gameMenu2 = int.Parse(Console.ReadLine());
            } // end of while
        }
    }
}