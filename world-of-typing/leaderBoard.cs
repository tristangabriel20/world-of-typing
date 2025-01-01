using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace world_of_typing
{
    internal class leaderboard
    {
        public static int score = 0;
        public static WaveOutEvent waveOutEvent;
        public static Mp3FileReader mp3FileReader;

        public static void showLeaderBoard()
        {
            // store all score who played
            int highScore = 0;
            string name = "";
            List<string> names = [];
            List<int> scores = [];

            foreach (var user in Database.GetAllUsers())
            {
                if (user.Value.name == titleScreen.name)
                {
                    name = user.Value.name ?? "";
                    highScore = user.Value.score ?? 0;
                }

                names.Add(user.Value.name ?? "");
                scores.Add(user.Value.score ?? 0);
            }

            Console.WriteLine("\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("LEADERBOARD");
            Console.ResetColor();
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine("Rank " + (i + 1) + ". " + names[i] + " - " + scores[i]);
            }
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press ESC. To back to the MENU");
            Console.ResetColor();

            bool condition = true;
            while (condition)
            {
                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        difficultiesSelection.Option1();
                    }
                }
            }
        }
    }
}