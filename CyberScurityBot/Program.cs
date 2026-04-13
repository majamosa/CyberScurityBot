using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CyberScurityBot
{
    internal class Program
    {
        // we use interface to hide the stuff like method or variables
        interface UserOfQuestion
        {
            void Display();
            void Displayinfo();
        }
        class Userinfo : maja//we call this one inheritance the parant is giving the child the power
        {
            public void Display()
            {
                final final = new final();
                while (string.IsNullOrWhiteSpace(name))//where we check if the variable name is empty or not
                {
                    try
                    {
                        //we use ForegroundColour for colour
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Enter your name: ");

                        Console.ForegroundColor = ConsoleColor.White;
                        name = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(name))
                        {
                            throw new Exception("Name cannot be empty.");
                        }
                    }
                    catch (Exception ex)//Exception includes all the exception prombles
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error: " + ex.Message);
                        Console.ResetColor();
                    }
                }
            }
        }

        class Questioninfo : Userinfo 
        {
            public void Displayinfo()
            {
                string you;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nHey {name}, you can select an option:");

                while (true)
                {
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("╔══════════════ MENU ══════════════╗");
                        Console.WriteLine("║ 1. How are you                   ║");
                        Console.WriteLine("║ 2. What is your purpose          ║");
                        Console.WriteLine("║ 3. What can I ask you about      ║");
                        Console.WriteLine("║ 4. Password safety               ║");
                        Console.WriteLine("║ 5. Phishing                      ║");
                        Console.WriteLine("║ 6. Safe browsing                 ║");
                        Console.WriteLine("║ 7. Exit                          ║");
                        Console.WriteLine("╚══════════════════════════════════╝");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Enter your choice: ");

                        Console.ForegroundColor = ConsoleColor.White;
                        you = Console.ReadLine();

                        if (you == null)
                        {
                            throw new Exception("Input cannot be null.");
                        }

                        you = you.ToLower();//we are make sure that if the use enetr a anaswer in Upper the program will make it into lower case

                        Console.ForegroundColor = ConsoleColor.Green;

                        if (you.Contains("how are you") || you == "1")// we use this as ||(or) so f thr user press the number or juset write the anawer it will not crush
                        {
                            Console.WriteLine("I'm doing great! Thanks for asking ");
                        }
                        else if (you.Contains("purpose") || you == "2")
                        {
                            Console.WriteLine("My purpose is to help answer your questions.");
                        }
                        else if (you.Contains("ask") || you == "3")
                        {
                            Console.WriteLine("You can ask me about security and safety.");
                        }
                        else if (you.Contains("password") || you == "4")
                        {
                            Console.WriteLine("Use strong passwords and never share them.");
                        }
                        else if (you.Contains("phishing") || you == "5")
                        {
                            Console.WriteLine("Avoid clicking suspicious links.");
                        }
                        else if (you.Contains("safe browsing") || you == "6")
                        {
                            Console.WriteLine("Only visit secure and trusted websites.");
                        }
                        else if (you.Contains("exit") || you == "7")
                        {
                            Console.WriteLine("Goodbye!");
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("I don't understand. Can you rephrase?");
                        }

                        Console.ResetColor();
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error: " + ex.Message);
                        Console.ResetColor();
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Playmusic("C:\\Users\\User\\source\\repos\\CyberScurityBot\\CyberScurityBot\\AUD-20260315-WA0004.wav");
            Console.WriteLine("play file");
            Console.WriteLine(@"
        ______________________
       /                      \
      |   [ 0 ]       [ 0 ]   |
      |                        |
      |        \______/        |
      |       /  ____  \       |
      |      |  |____|  |      |
      |      |__________|      |
      |                        |
      |    ---  ----  ---      |
       \______________________/
           |            |
        ___|____________|___
       /                    \
      /______________________\
        ");
            try
            {
                Questioninfo q = new Questioninfo();
                q.Display();
                q.Displayinfo();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Unexpected error: " + ex.Message);
                Console.ResetColor();
            }
        }
        public static void Playmusic(string filepath)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = filepath;
            player.PlaySync();
        }

    }
}

