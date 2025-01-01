using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace world_of_typing
{
    internal class difficultiesSelection
    {
        public static int score = 0; // for score
        public static WaveOutEvent waveOutEvent; // for music
        public static Mp3FileReader mp3FileReader; 
        public static void Option1()
        {
            waveOutEvent = new WaveOutEvent();
            mp3FileReader = new Mp3FileReader(@"./music/Envici_November.mp3");
            waveOutEvent.Init(mp3FileReader);
            waveOutEvent.Play();
            int highScore = 0;
            string name = "";
            List<string> names = [];
            List<int> scores = [];


            foreach (var user in Database.GetAllUsers()) // to store all names
            {
                if (user.Value.name == titleScreen.name)
                {
                    name = user.Value.name ?? "";
                    highScore = user.Value.score ?? 0;
                }

                names.Add(user.Value.name ?? "");
                scores.Add(user.Value.score ?? 0);
            }

                try // check if their is a error 
                {

                Console.Clear();
                Console.WriteLine("\n\n\n\n\n\n\n\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t\t\t\t\t\t\t\t██████╗ ██╗   ██╗██████╗ ███████╗    ████████╗██╗   ██╗██████╗ ██╗███╗   ██╗ ██████╗ \r\n\t\t\t\t\t\t\t\t\t██╔══██╗██║   ██║██╔══██╗██╔════╝    ╚══██╔══╝╚██╗ ██╔╝██╔══██╗██║████╗  ██║██╔════╝ \r\n\t\t\t\t\t\t\t\t\t██████╔╝██║   ██║██████╔╝█████╗         ██║    ╚████╔╝ ██████╔╝██║██╔██╗ ██║██║  ███╗\r\n\t\t\t\t\t\t\t\t\t██╔═══╝ ██║   ██║██╔══██╗██╔══╝         ██║     ╚██╔╝  ██╔═══╝ ██║██║╚██╗██║██║   ██║\r\n\t\t\t\t\t\t\t\t\t██║     ╚██████╔╝██║  ██║███████╗       ██║      ██║   ██║     ██║██║ ╚████║╚██████╔╝\r\n\t\t\t\t\t\t\t\t\t╚═╝      ╚═════╝ ╚═╝  ╚═╝╚══════╝       ╚═╝      ╚═╝   ╚═╝     ╚═╝╚═╝  ╚═══╝ ╚═════╝");
                Console.ResetColor();
                Console.WriteLine("\n");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\tCurrent Score: " + score);
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t    High Score: " + highScore + " " + name);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\t\t\t\t\t\t\t\t        Choose any number you prefer from the difficulties list below. ( Ex: 1 or 123 or 312)");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n\n\t\t\t\t\t\t\t\t\t\t\t\t   0. No Difficulties ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t1. Numbers");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t      2. Punctuation");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t      3. Upper Cases");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t      4. Hard Words");
                Console.ResetColor();
                Console.WriteLine("\n");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t5. Exit");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t    6. Leader Board");
                Console.Write("\n\n\t\t\t\t\t\t\t\t\t\t\t\t         CHOOSE: ");

                int input = Convert.ToInt32(Console.ReadLine());

                    string finalchoise = Convert.ToString(input); // Convert the input number to a string
                    if (finalchoise.Contains('7') || finalchoise.Contains('8') || finalchoise.Contains('9'))
                    {
                        Console.Clear();
                        difficultiesSelection.Option1(); //option1 is where the user choose what type of difficulties desire
                    }

                    string[] punctuation = { "", "", "", "", "", "", "" };
                    // storing the all words 
                    string[] number = { "seven thirty", "five", };
                    string[] number1 = { "eighteen", "ten", "three", "five" };
                    string[] upper = { "at", "am", "jake", "wait", "the", "no", "but", "hurry", "success", "just", "with" };
                    string[] upper1 = { "i", "emily", "time", "her", "they", "this", "best", "let" };
                    string[] number2 = { "nine", "five", "one", "three" };
                    string[] upper2 = { "at", "pm", "lily", "next", "by" };
                    string[] number3 = { "one hundred", "five", "nine eight", "three" };
                    string[] upper3 = { "i", "tom", "he", "found", "wait", "where", "the" };
                    
                    string[] upper4 = { "only", "mike", "his", "with", "swish", "yes", "we won" };
                    string[] number4 = { "five", "three", "two" };

                    string[] number6 = { "two thousand twenty four", "one" };
                    string[] upper6 = { "in", "john", "but", "is", "he", "life" };

                    string[] number7 = { "nine" };
                    string[] upper7 = { "pm" };

                    string[] number8 = { "twelve" };
                    string[] upper8 = { "mars", "we", "captain davis", "everyone" };

                    string[] number9 = { "seven", "ten" };
                    string[] upper9 = { "sarah" };

                string[] hardWord = { "noticed", "exclaimed", "something", "proudly", "minutes", "waiting", "flashlight", "countdown", "decisions" };

                    // Adapt to the length of the input string dynamically
                    if (finalchoise.Contains('1'))  // Check if '1' is present in the input, regardless of position
                    {
                        number[0] = "7:30";
                        number[1] = "5";

                        number1[0] = "18";
                        number1[1] = "10";
                        number1[2] = "3";
                        number1[3] = "5";

                        number2[0] = "9";
                        number2[1] = "5";
                        number2[2] = "1";
                        number2[3] = "3";

                        number3[0] = "100";
                        number3[1] = "5";
                        number3[2] = "98";

                        number2[0] = "5";
                        number2[1] = "3";
                        number2[3] = "2";

                        number6[0] = "2024";
                        number6[1] = "1";

                        number7[0] = "9";

                        number8[0] = "12";

                        number9[0] = "7";
                        number9[1] = "10";
                    }

                    if (finalchoise.Contains('2')) // if the user choose the punctuation type 
                    {
                        punctuation[0] = ",";
                        punctuation[1] = "!";
                        punctuation[2] = ".";
                        punctuation[3] = "-";
                        punctuation[4] = "'";
                        punctuation[5] = ":";
                        punctuation[6] = "?";
                    }

                    if (finalchoise.Contains('3')) //  if the user choose the upper cases type 
                    {
                        upper[0] = "At";
                        upper[1] = "AM";
                        upper[2] = "Jake";
                        upper[3] = "Wait";
                        upper[4] = "The";
                        upper[5] = "NO";
                        upper[6] = "But";
                        upper[7] = "Hurry";
                        upper[8] = "SUCCESS";
                        upper[9] = "Just";
                        upper[10] = "With";

                        upper1[0] = "I";
                        upper1[1] = "Emily";
                        upper1[2] = "Time";
                        upper1[3] = "Her";
                        upper1[4] = "They";
                        upper1[5] = "This";
                        upper1[6] = "Best";
                        upper1[7] = "Let";

                        upper2[0] = "At";
                        upper2[1] = "PM";
                        upper2[2] = "Lily";
                        upper2[3] = "Next";
                        upper2[4] = "By";

                        upper3[0] = "I";
                        upper3[1] = "Tom";
                        upper3[2] = "He";
                        upper3[3] = "Found";
                        upper3[4] = "Wait";
                        upper3[5] = "Where";
                        upper3[6] = "The";

                        upper4[0] = "Only";
                        upper4[1] = "Mike";
                        upper4[2] = "His";
                        upper4[3] = "With";
                        upper4[4] = "Swish";
                        upper4[5] = "Yes";
                        upper4[6] = "We Won";

                        upper6[0] = "In";
                        upper6[1] = "John";
                        upper6[2] = "But";
                        upper6[3] = "Is";
                        upper6[4] = "He";
                        upper6[5] = "Life";

                        upper7[0] = "PM";

                        upper8[0] = "Mars";
                        upper8[1] = "We";
                        upper8[2] = "Captain Davis";
                        upper8[3] = "Everyone";

                        upper9[0] = "Sarah";
                    }

                    if (finalchoise.Contains('4')) //  if the user choose the hard words type
                    {
                    hardWord[0] = "decitno";
                    hardWord[1] = "medexaicl";
                    hardWord[2] = "emosingth";
                    hardWord[3] = "oudylrp";
                    hardWord[4] = "nuestim";
                    hardWord[5] = "iawngti";
                    hardWord[6] = "ahsightllaf";
                    hardWord[7] = "nwodtnuoc";
                    hardWord[8] = "snoisiced";
                }

                if (finalchoise == "5") //  if the user choose the hard words type
                    {
                        waveOutEvent.Stop();
                        Console.Clear();
                        titleScreen.Main();
                    }
                    if (finalchoise == "6") //  if the user choose the hard words type
                    {
                        waveOutEvent.Stop();
                        Console.Clear();
                        leaderboard.showLeaderBoard();
                    }


                if (Console.KeyAvailable)
                    {
                        // Read the key that was pressed
                        var keyInfo = Console.ReadKey(intercept: true);

                        // Check if the Enter key was pressed
                        if (keyInfo.Key == ConsoleKey.Enter)
                        {
                            // Code to execute when Enter key is pressed
                            Console.WriteLine("Enter key was pressed after reading input!");
                        }
                    }


                    Console.Clear();
                    Console.Write("\n\n\n\n\n\n");
                    string[] storeStory = new string[9]; // the story that will type the users
                    Random randomStory = new Random(); // the story will be random selected
                    int randomNum = randomStory.Next(0, storeStory.Length);
            storeStory[0] = $"{upper[0]} {number[0]} {upper[1]}{punctuation[0]} {upper[2]} saw the bus{punctuation[2]} {punctuation[4]}{upper[3]}{punctuation[1]}{punctuation[4]} he yelled{punctuation[2]} {upper[4]} doors closed{punctuation[2]} {punctuation[4]}{upper[5]}{punctuation[1]}{punctuation[4]} {upper[6]} then{punctuation[0]} the bus driver {hardWord[0]} him{punctuation[2]} {punctuation[4]}{upper[7]}{punctuation[1]} {number[1]} seconds{punctuation[1]}{punctuation[4]} {upper[2]} leapt on board{punctuation[2]} {upper[8]}{punctuation[1]} {upper[9]} in time{punctuation[2]} ";
            storeStory[1] = $"{punctuation[4]}{upper1[0]}{punctuation[4]}m {number1[0]} today{punctuation[1]}{punctuation[4]} {upper1[1]} shouted{punctuation[2]} {punctuation[4]}{upper1[2]} for a party{punctuation[1]}{punctuation[4]} {upper1[3]} friends cheered{punctuation[2]} {upper1[4]} had {number1[1]} balloons{punctuation[0]} {number1[2]} cakes{punctuation[0]} and {number1[3]} gifts{punctuation[2]} {punctuation[4]}{upper1[5]} is the {upper1[6]}{punctuation[1]}{punctuation[4]} {upper1[1]} {hardWord[1]}{punctuation[0]} smiling widely{punctuation[2]} {punctuation[4]}{upper1[7]}{punctuation[4]}s make it unforgettable{punctuation[1]}{punctuation[4]}";
            storeStory[2] = $"{upper2[0]} {number2[0]} {upper2[1]}{punctuation[0]} {upper2[2]} decided to try {hardWord[2]} new{punctuation[2]} {punctuation[4]}{number2[1]} steps{punctuation[1]}{punctuation[4]} she told herself{punctuation[2]} First{punctuation[0]} she opened the book{punctuation[2]} {upper2[3]}{punctuation[0]} she read{punctuation[2]} {punctuation[4]}{number2[2]} chapter down{punctuation[0]} {number2[3]} more to go{punctuation[1]}{punctuation[4]} {upper2[4]} midnight{punctuation[0]} success{punctuation[1]}";
            storeStory[3] = $"{punctuation[4]}{upper3[0]} have {number3[0]} dollars{punctuation[1]}{punctuation[4]} {upper3[1]} said {hardWord[3]}{punctuation[2]} {punctuation[4]}{upper6[2]}{punctuation[0]} {number3[1]} bills are missing{punctuation[2]}{punctuation[4]} {upper3[2]} searched everywhere{punctuation[2]} {punctuation[4]}{upper3[3]} them{punctuation[1]}{punctuation[4]} he exclaimed{punctuation[0]} counting{punctuation[2]} {punctuation[4]}{upper[4]}{punctuation[2]}{punctuation[2]}{punctuation[2]} only {number3[2]}{punctuation[6]} {upper3[5]} are the others{punctuation[6]}{punctuation[4]} {upper3[6]} hunt continued until midnight{punctuation[1]}";
            storeStory[4] = $"{punctuation[4]}{upper4[0]} {number4[0]} {hardWord[4]} left{punctuation[1]}{punctuation[4]} {upper4[1]} shouted{punctuation[0]} looking at the clock{punctuation[2]} {upper4[2]} team was down by {number4[1]} points{punctuation[2]} {upper[10]} {number4[2]} seconds to go{punctuation[0]} he shot{punctuation[2]} {upper4[4]}{punctuation[1]} {punctuation[4]}{upper4[5]}{punctuation[1]} {upper4[6]}{punctuation[1]}{punctuation[4]} {upper[4]} crowd went wild{punctuation[2]}";
            storeStory[5] = $"{punctuation[4]}{upper6[0]} {number6[0]}{punctuation[0]} {upper6[1]} ran {number2[0]} miles faster than ever{punctuation[1]} {upper6[2]} at mile {number2[1]}{punctuation[0]} he saw her{punctuation[5]} {number6[1]} woman{punctuation[0]} {hardWord[5]}{punctuation[2]} {punctuation[4]}{upper6[3]} it your turn{punctuation[6]}{punctuation[4]} she asked{punctuation[2]} {upper6[4]} nodded{punctuation[2]} {upper6[5]} never stops moving{punctuation[2]}{punctuation[4]}";
            storeStory[6] = $"{punctuation[4]}{upper[0]} {number7[0]} {upper7[0]}{punctuation[0]} {upper1[1]} found the note{punctuation[5]} {punctuation[4]}{number2[1]} steps ahead{punctuation[0]} {number2[0]} miles to go{punctuation[2]}{punctuation[4]} {upper2[3]} only {number6[1]} {hardWord[6]}{punctuation[0]} she ran{punctuation[2]} {upper[4]} wind howled{punctuation[0]} the trees whispered{punctuation[0]} but she knew{punctuation[3]}time was running out{punctuation[2]}{punctuation[4]}";
            storeStory[7] = $"{punctuation[4]}{number2[2]} weeks{punctuation[0]} {number2[0]} days{punctuation[0]} {number2[1]} hours: the {hardWord[7]} had begun{punctuation[2]} {upper[4]} rocket launched at {number8[0]} {upper7[0]}{punctuation[0]} hurtling towards {upper8[0]}{punctuation[2]} {upper[4]} crew cheered{punctuation[2]} {punctuation[4]}{upper8[1]} are making history{punctuation[0]}{punctuation[4]} {upper8[2]} declared{punctuation[2]} {upper8[3]} smiled{punctuation[2]}{punctuation[4]}";
            storeStory[8] = $"{punctuation[4]}{number9[0]} {upper[1]}{punctuation[0]} and the clock struck{punctuation[2]} {number2[1]} {hardWord[8]} were left{punctuation[2]} {number2[0]} minutes until the meeting began{punctuation[2]} {upper9[0]} heart raced{punctuation[3]}could she handle it{punctuation[6]} {upper[4]} boardroom was waiting{punctuation[2]} {upper[4]} fate of {number9[1]} employees was at stake{punctuation[2]}{punctuation[4]}";
                string story = storeStory[randomNum];
                    string[] story2 = story.Split(' ');

                    if (randomNum == 0) // to make the story centered
                    {
                        Console.Write("\t\t\t\t");
                        Console.WriteLine(story);
                    }
                    else if (randomNum == 1)
                    {
                        Console.Write("\t");
                        Console.WriteLine(story);
                    }
                    else if (randomNum == 2)
                    {
                        Console.Write("\t");
                        Console.WriteLine(story);
                    }
                    else if (randomNum == 3)
                    {
                        Console.Write("\t");
                        Console.WriteLine(story);
                    }
                    else if (randomNum == 4)
                    {
                        Console.Write("\t");
                        Console.WriteLine(story);
                    }
                    else if (randomNum == 5)
                    {
                        Console.Write("\t");
                        Console.WriteLine(story);
                    }
                    else if (randomNum == 6)
                    {
                        Console.Write("\t");
                        Console.WriteLine(story);
                    }
                    else if (randomNum == 7)
                    {
                        Console.Write("\t");
                        Console.WriteLine(story);
                    }
                    else if (randomNum == 8)
                    {
                        Console.Write("\t");
                        Console.WriteLine(story);
                    }


                    Console.Write("\n\t\t\t\t\t\t\t\t\t\t\t\t YOU MY START IN: ");
                    for (int i = 3; i >= 1; i--) // indicate to start typing
                    {
                        Console.Write(i + " ");
                        Thread.Sleep(1000);
                    }

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\tType the Displayed Text to Sharpen your Keyboard Skills");
                    Console.ResetColor();
                    string[] storyWords = story.Split(' '); // each word in the stories are independent 

                Stopwatch timer = new Stopwatch();
                timer.Start();
                Thread timerThread = new Thread(() => TimerLogic(timer));
                timerThread.Start();
                Console.WriteLine("\n\t\t\t\t\t\t\t\t\t\t\t\t      NOW TYPE!!");
                Console.Write("\t");
                string typing = Console.ReadLine();
                string[] typedWords = typing.Split(' ');
                timer.Stop();
                timerThread.Join();

                List<string> highlightedStory = new List<string>(); // store the mistype error that the user type
                    List<string> highlightedStory2 = new List<string>(); // store the missing words that the user type
                    List<string> highlightedStory3 = new List<string>(); //store the extra words that the user type              
                    
                    int error = 0;
                    if (story == typing) // stories displayed is same as the user type
                    {
                        Console.ForegroundColor = ConsoleColor.Green; // if the given stories is all type correctly by the user
                        Console.WriteLine("ALL CORRECT. EXCELLENT"); // if the given stories is all type correctly by the user
                        Console.ResetColor();
                    }
                    else // if there is an mistake type by the user
                    {
                        int minLength = Math.Min(storyWords.Length, typedWords.Length);
                        for (int i = 0; i < minLength; i++) // the program will know if the user mistype
                        {
                            if (storyWords[i] != typedWords[i]) // if the words in the story is not the same as the the user type 
                            {
                                highlightedStory.Add(typedWords[i]);
                                error++; // mark as an mistake by the user
                            }
                            else // correct type by the user
                            {
                                highlightedStory.Add(storyWords[i]);
                            }
                        }

                        if (typedWords.Length < storyWords.Length) // highlighthing the error
                        {
                            for (int i = typedWords.Length; i < storyWords.Length; i++)
                            {
                                highlightedStory2.Add(storyWords[i]);
                                error++;
                            }
                        }

                        if (typedWords.Length > storyWords.Length)
                        {
                            for (int i = storyWords.Length; i < typedWords.Length; i++)
                            {
                                highlightedStory3.Add(typedWords[i]);
                                error++;
                            }
                        }


                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"\n\t\t\t\t\t\t\t\t\t\t\t      Time taken: {timer.Elapsed.TotalSeconds:F2} seconds");
                        Console.ResetColor();

                        bool condition = true;// color coding for error of the user
                        while (condition)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nTotal Error: " + error);
                            Console.ResetColor();
                            Console.Write("Do you want to show your error? (y/n):");
                            string response = Console.ReadLine().ToLower();

                            if (response == "y")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("\t\t\t\t\t\t\t\tRed for Error, ");
                                Console.ResetColor();

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("Yellow for Missing, ");
                                Console.ResetColor();

                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("Blue for Extra Word, ");
                                Console.ResetColor();

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("Green for Correct Word");
                                Console.ResetColor();
                                Console.WriteLine("\n");

                                int minLength2 = Math.Min(storyWords.Length, typedWords.Length);
                                for (int i = 0; i < minLength; i++)
                                {
                                    if (storyWords[i] == typedWords[i])
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write(typedWords[i] + " ");
                                        Console.ResetColor();
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write(storyWords[i] + " ");
                                        Console.ResetColor();
                                    }
                                }

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(string.Join(" ", highlightedStory2) + " ");
                                Console.ResetColor();

                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write(string.Join(" ", highlightedStory3) + " ");
                                Console.ResetColor();

                                condition = false;
                            }
                            else if (response == "n")
                            {
                                condition = false;
                            }
                            else
                            {

                                Console.WriteLine("Please type a correct response.");
                            }

                        }
                    }

                    if (error >= storyWords.Length * 1.0) // scoring for typing
                    {
                        score += 0;
                    }
                    else if (error >= storyWords.Length * 0.75)
                    {
                        score += 25;
                    }
                    else if (error >= storyWords.Length * 0.50)
                    {
                        score += 50;
                    }
                    else if (error >= storyWords.Length * 0.25)
                    {
                        score += 75;
                    }
                    else if(error >= storyWords.Length * 0)
                    {
                        score += 100;
                    }
                    

                    Console.WriteLine("\nCurrent Score: " + score); // showing score of the user
                    Console.WriteLine("\n");
                    bool condition2 = true;
                    while (condition2)
                    {
                         Console.Write("Do you want to choose another option again? (y/n): ");
                         string another = Console.ReadLine().ToLower();
                         Database.UpdateScore(titleScreen.name, score);

                    if (another == "y")
                    {
                        waveOutEvent.Stop();
                        Console.Clear();
                        difficultiesSelection.Option1();
                        condition2 = false;
                    }
                    else if (another == "n")
                    {
                        score = 0;
                        titleScreen.name = "";
                        waveOutEvent.Stop();
                        Console.Clear();
                        titleScreen.Main();
                        condition2 = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("INVALID INPUT");
                        Console.ResetColor();
                    }
                }
            }
                catch (FormatException ex) // catching logical error made by users
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t\t\t\t\t\t\t\t\t\t\t\tLETTER INSTEAD OF NUMBER");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                    Option1();
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("OUT OF RANGE");
                    Console.WriteLine($"Error Details: {ex.Message}");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("\n                                                                                                          INPUT TO0 LARGE");
                    Thread.Sleep(1000);
                    Option1();
                }

                // Allow any numerical input, no specific length required
                Console.WriteLine("\n\n\t\t\t\t\t\t\t\t  -------------------------------------------------------------------------------------");
                
            }

        public static void TimerLogic(Stopwatch stopwatch)
        {
            bool scoreAdded30 = false;
            bool scoreAdded60 = false;

            // Loop to keep checking the elapsed time in the background
            while (stopwatch.IsRunning)
            {
                // Check if 30 seconds have passed and we haven't added score yet
                if (!scoreAdded30 && stopwatch.Elapsed.TotalSeconds >= 30 && stopwatch.Elapsed.TotalSeconds < 60)
                {
                    score += 30;
                    scoreAdded30 = true; // Prevent adding score again
                }
                // Check if 1 minute (60 seconds) has passed and we haven't added score yet
                else if (!scoreAdded60 && stopwatch.Elapsed.TotalSeconds >= 60 && stopwatch.Elapsed.TotalSeconds < 90)
                {
                    score -= 15;
                    scoreAdded60 = true; // Prevent adding score again
                }
                else if (!scoreAdded60 && stopwatch.Elapsed.TotalSeconds >= 90)
                {
                    score -= 15;
                }
                // Sleep for 1 second to reduce CPU usage
                Thread.Sleep(1000);
            }
        }
    }
}
