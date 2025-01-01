using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace world_of_typing
{
    internal class instruction
    {
        public static void Options(bool titleRepit)
        {
            /*instruction*/
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\n\n\t\t\t\t\t\t\t\t\t\t         ----------------- MENU -----------------");
            Console.WriteLine("\n\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t       Instructions:\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t        !Choose a Difficulty Level:\r\n\r\n\t\t\t\t\t\t\t\t\tDifferent difficulty levels will be displayed to challenge and help you practice.\r\n\t\t\t\t\t\t\t\t\t\t\t\t\n\t\t\t\t\t\t\t\t\t\t\t           !Type the Sentences:\r\n\r\n\t\t\t\t\t\t\t\t       Type the sentences shown on your screen based on the difficulty level you selected.\r\n\t\t\t\t\t\t\t\t\t\t\t\t\n\t\t\t\t\t\t\t\t\t\t\t\t!Follow Correct Letter Order:\r\n\r\n\t\t\t\t\t\t\t\t        Make sure to type each word accurately, following the correct sequence of letters.      ");
            Console.WriteLine("\n\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t     You ONLY have 1:30 minutes to type the shown stories. 30 SECONDS is = +30 points. 1:30 MINUTES = +15");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n\t\t\t\t\t\t\t\t\t              PRESS 'SPACE BAR' TO PROCEED IN THE PURE TYPING MODE     ");
            Console.WriteLine("\n\n\t\t\t\t\t\t\t\t\t\t\t\t    Press 'ESC'  to  Exit");
            Console.ResetColor();
            bool condition = true;
            while (titleRepit) //  indicate for exiting and continue
            {
                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                    {
                        Console.Clear();
                        difficultiesSelection.Option1();
                    }
                    else if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        titleScreen.Main();
                    }
                }
            }
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  ----------------------------------------------------");
        }
    }
}
