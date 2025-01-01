using System.Xml.Linq;

namespace world_of_typing
{
    internal class titleScreen
    {
        public static string name = "";
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\n\n\n\n");
            Console.WriteLine("                                                ██╗    ██╗ ██████╗ ██████╗ ██╗     ██████╗      ██████╗ ███████╗    ████████╗██╗   ██╗██████╗ ██╗███╗   ██╗ ██████╗     \r\n                                                 ██║    ██║██╔═══██╗██╔══██╗██║     ██╔══██╗    ██╔═══██╗██╔════╝    ╚══██╔══╝╚██╗ ██╔╝██╔══██╗██║████╗  ██║██╔════╝     \r\n                                                 ██║ █╗ ██║██║   ██║██████╔╝██║     ██║  ██║    ██║   ██║█████╗         ██║    ╚████╔╝ ██████╔╝██║██╔██╗ ██║██║  ███╗    \r\n                                                 ██║███╗██║██║   ██║██╔══██╗██║     ██║  ██║    ██║   ██║██╔══╝         ██║     ╚██╔╝  ██╔═══╝ ██║██║╚██╗██║██║   ██║    \r\n                                                 ╚███╔███╔╝╚██████╔╝██║  ██║███████╗██████╔╝    ╚██████╔╝██║            ██║      ██║   ██║     ██║██║ ╚████║╚██████╔╝    \r\n                                                  ╚══╝╚══╝  ╚═════╝ ╚═╝  ╚═╝╚══════╝╚═════╝      ╚═════╝ ╚═╝            ╚═╝      ╚═╝   ╚═╝     ╚═╝╚═╝  ╚═══╝ ╚═════╝");



            Console.ResetColor();
            Console.WriteLine("\n");

            Console.WriteLine(@"                                                                BOOST YOUR TYPING ABILITIES WITH EASY, ENJOYABLE, AND HIGHLY PRODUCTIVE TYPING EXERCISES. 
          
                                                        START A THRILLING ADVENTURE WHERE EVERY KEYSTROKE MATTERS, WHETHER YOU'RE COMPETING OR JUST PRACTICING.

                                                                                           ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;


            while (string.IsNullOrEmpty(name)) // force input the name
            {
                Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\tName: ");
                name = Console.ReadLine();
                Console.Clear();
                titleScreen.Main();
            }


            Database.GenerateDb(); // to save 
            Database.GenerateUser(name);




            Console.WriteLine("                                                                                                 (Press ENTER to PROCEED)");

            Console.ResetColor();
            bool titleRepit = true;

            while (titleRepit) 
            {
                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                    {
                        instruction.Options(titleRepit);
                        titleRepit = false;
                    }
                }
            }
        }
    }
}